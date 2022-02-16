using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EnovaPasswordReset
{
	public partial class FrmPasswordReset : Form
	{
        static byte[] passwordKey = new byte[] { 54, 94, 185, 184, 123, 100, 223, 213, 253, 51, 5, 87, 27, 64, 88, 111, 67, 94, 63, 82, 175, 129, 134, 211 };
        static MACTripleDES passwordDES = new MACTripleDES(passwordKey);
        public static string dbGuid;
        public static string opGuid;

        public FrmPasswordReset()
		{
			InitializeComponent();
		}
        private void FrmPasswordReset_Load(object sender, EventArgs e)
        {
            InstanceCB.Text = Properties.Settings1.Default.DataSource;
            SQLUserTB.Text = Properties.Settings1.Default.User;
            SQLPasswordTB.Text = Properties.Settings1.Default.Password;
            WindowsAuthCB.Checked = Properties.Settings1.Default.WindowsAuth;
            SecurityCB.Checked = Properties.Settings1.Default.PersistSecurityInfo;
                        
            if (!String.IsNullOrEmpty(InstanceCB.Text))
                DatabaseCB.DataSource = GetDataBaseList();
            
        }
        /// <summary>
        /// Populate the DataSourceCB with allowed local server instances
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBT_Click(object sender, EventArgs e) => InstanceCB.Items.AddRange(GetDataSources().ToArray());
        /// <summary>
        /// Controls the visibility of items and sets a value for @windowsAuth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            SQLUserTB.Enabled = SQLPasswordTB.Enabled = !WindowsAuthCB.Checked;
        }
        /// <summary>
        /// Reconnects to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshBT_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(InstanceCB.Text))                
                DatabaseCB.DataSource = GetDataBaseList();                
        }
        /// <summary>
        /// Primary event that does the job
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteBT_Click(object sender, EventArgs e) => Commit();
        /// <summary>        
        /// Depending on the database selected, it retrieves information about its Guid and assigns it to @dbGuid, then collects operators from this database and fills the OperatorCB data source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = getDBConnection(DatabaseCB.SelectedValue.ToString()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Value FROM dbo.SystemInfos WHERE Ident = 7", connection))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                dbGuid = dr[0].ToString();
                        }
                    }
                    List<string> list = new List<string>();
                    using (SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Operators", connection))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                list.Add(dr[0].ToString());
                        }
                    }
                    OperatorCB.DataSource = list;
                }

            }
            catch (Exception ex) { MessageBox.Show("Error occured\n" + ex.Message); }
        }
        /// <summary>
        /// Depending on the selected operator, it gets information about its Guid and assigns it to @opGuid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = getDBConnection(DatabaseCB.SelectedValue.ToString()))
                {
                    connection.Open();    
                    using (SqlCommand cmd = new SqlCommand("SELECT Guid FROM dbo.Operators WHERE Name like '"+OperatorCB.SelectedValue.ToString()+"' ", connection))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                opGuid = dr[0].ToString();
                        }
                    }                    
                }
            }
            catch (Exception ex) { MessageBox.Show("Error occured\n" + ex.Message); }
        }
        /// <summary>
        /// Converts byte[] in @t parameter to string result
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        static string ByteArrayToString(byte[] t)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < t.Length; i++)            
                ByteToHex(t[i], stringBuilder);            
            return stringBuilder.ToString();
        }
        /// <summary>
        /// Converts byte in @b parameter and appends its modified value into @sb parameter
        /// </summary>
        /// <param name="b"></param>
        /// <param name="sb"></param>
        static void ByteToHex(byte b, StringBuilder sb)
        {
            sb.Append(getCharUpp((b & 240) >> 4));
            sb.Append(getCharUpp((int)(b & 15)));
        }
        /// <summary>
        /// Converts value into big char
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static char getCharUpp(int v)
        {
            if (v < 10)            
                return (char)(48 + v);            
            return (char)(65 + v - 10);
        }
        /// <summary>
        /// Gathers a list of databases and fills them in the comboBox
        /// </summary>
        /// <returns>list of databases</returns>
        public List<string> GetDataBaseList()
        {
            List<string> list = new List<string>();
            try
            {
                using (SqlConnection conn = getDBConnection("master"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", conn))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                list.Add(dr[0].ToString());
                        }
                    }
                }
                list.Sort(delegate (string x, string y)
                {
                    return x.CompareTo(y);
                });
            }
            catch(Exception ex)
            {
                DatabaseCB.DataSource = null;
                OperatorCB.DataSource = null;
                MessageBox.Show("Failed to login to the server\n" + ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Creates connection with @dataSource and database named @DataBaseName
        /// Depending on @windowsAuth, it using Integrated Security or SQL Credentials 
        /// </summary>
        /// <param name="DataBaseName"></param>
        /// <returns>new SqlConnection</returns>
        public SqlConnection getDBConnection(string DataBaseName)
        {
            if (WindowsAuthCB.Checked)
            {

                try
                {
                    return new SqlConnection(@"Data Source=" + InstanceCB.Text + ";Initial Catalog=" + DataBaseName + ";Integrated Security=True;");
                }
                catch { return null; }
            }
            else
            {
                try
                {
                    return new SqlConnection(@"Data Source=" + InstanceCB.Text + ";Initial Catalog=" + DataBaseName + ";Persist Security Info=" + SecurityCB.Checked + ";User ID=" + SQLUserTB.Text + ";Password=" + SQLUserTB.Text + "");
                }
                catch { return null; }
            }

        }
        /// <summary>
        /// Changes the password for the selected operator in the selected database to the new one provided in the "New Password" field
        /// </summary>
        public void Commit()
        {
            try
            {
                byte[] arrayDbGuid = new Guid(dbGuid).ToByteArray();
                byte[] arrayPass = Encoding.Unicode.GetBytes(NewPasswordTB.Text);
                byte[] arrayOperatorGuid = new Guid(opGuid).ToByteArray();
                byte[] arrayOutput = new byte[arrayDbGuid.Length + arrayPass.Length + arrayOperatorGuid.Length];
                arrayDbGuid.CopyTo(arrayOutput, 0);
                arrayPass.CopyTo(arrayOutput, arrayDbGuid.Length);
                arrayOperatorGuid.CopyTo(arrayOutput, arrayDbGuid.Length + arrayPass.Length);

                string newPass = ByteArrayToString(passwordDES.ComputeHash(arrayOutput));
                using (SqlConnection connection = getDBConnection(DatabaseCB.SelectedValue.ToString()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Operators SET Password = '" + newPass + "' WHERE Name like '" + OperatorCB.SelectedValue.ToString() + "' ", connection);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Done");
            }
            catch (Exception ex) { MessageBox.Show("Error occured\n" + ex); }
        }
        /// <summary>
        /// Depending on the version of the system, it retrieves information about SQL server instances from the registry
        /// </summary>
        /// <returns>list of avalible server instances</returns>
        private List<string> GetDataSources()
        {
            List<string> list = new List<string>();
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                    foreach (var instanceName in instanceKey.GetValueNames())
                        if (instanceName == "MSSQLSERVER")
                            list.Add(".\\");
                        else
                            list.Add(".\\" + instanceName);
            }
            return list;
        }
    }

}
