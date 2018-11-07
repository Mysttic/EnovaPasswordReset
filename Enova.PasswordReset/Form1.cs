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

namespace Enova.PasswordReset
{
	public partial class FrmPasswordReset : Form
	{
		public FrmPasswordReset()
		{
			InitializeComponent();
		}

		static byte[] passwordKey = new byte[] { 54, 94, 185, 184, 123, 100, 223, 213, 253, 51, 5, 87, 27, 64, 88, 111, 67, 94, 63, 82, 175, 129, 134, 211 };
		static MACTripleDES passwordDES = new MACTripleDES(passwordKey);
        public static string dbGuid;        
        public static string opGuid;
        public static string newPass;
        public string dataSource;
        public string user;
        public string password;
        public bool windowsAuth;
        public bool persistSecurityInfo;


        private void btnLicz_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] arrayDbGuid = new Guid(dbGuid).ToByteArray();
				byte[] arrayPass = Encoding.Unicode.GetBytes(tPass.Text);
				byte[] arrayOperatorGuid = new Guid(opGuid).ToByteArray();
				byte[] arrayOutput = new byte[arrayDbGuid.Length + arrayPass.Length + arrayOperatorGuid.Length];
				arrayDbGuid.CopyTo(arrayOutput, 0);
				arrayPass.CopyTo(arrayOutput, arrayDbGuid.Length);
				arrayOperatorGuid.CopyTo(arrayOutput, arrayDbGuid.Length + arrayPass.Length);

				newPass = ByteArrayToString(passwordDES.ComputeHash(arrayOutput));
                Commit();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Błąd podczas generowania nowego hasła. Sprawdź czy poprawnie wkleiłeś Guidy.");
			}
		}

		static string ByteArrayToString(byte[] t)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < t.Length; i++)
			{
				ByteToHex(t[i], stringBuilder);
			}
			return stringBuilder.ToString();
		}

		static void ByteToHex(byte b, StringBuilder sb)
		{
			sb.Append(getCharUpp((b & 240) >> 4));
			sb.Append(getCharUpp((int)(b & 15)));
		}

		static char getCharUpp(int v)
		{
			if (v < 10)
			{
				return (char)(48 + v);
			}
			return (char)(65 + v - 10);
		}
        private void FrmPasswordReset_Load(object sender, EventArgs e)
        {

            dataSource = Properties.Settings1.Default.DataSource;
            user = Properties.Settings1.Default.User;
            password = Properties.Settings1.Default.Password;
            windowsAuth = Properties.Settings1.Default.WindowsAuth;
            persistSecurityInfo = Properties.Settings1.Default.PersistSecurityInfo;

            DataSource.Text = dataSource;
            if (windowsAuth == true)            
                WindowsAuth.Checked = true;


            if (!String.IsNullOrEmpty(dataSource))
            {
                ComboBox cbx = comboBox1;
                cbx.DataSource = GetDataBaseList();
            }
        }       
        
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
            catch
            {
                WAlabel.BackColor = Color.Red;
                comboBox1.DataSource = null;
                comboBox2.DataSource = null;
                MessageBox.Show("Nie udało się zalogować do serwera");
            }
            return list;
        }
        public SqlConnection getDBConnection(string DataBaseName)
        {            
            if (windowsAuth)
            {
                
                try
                {
                    WAlabel.BackColor = Color.Green;
                    SqlConnection conn = new SqlConnection(@"Data Source=" + dataSource + ";Initial Catalog=" + DataBaseName + ";Integrated Security=True;");
                    return conn;
                }
                catch { return null; }
            }
            else
            {
                try
                {
                    WAlabel.BackColor = Color.Green;
                    bool security = persistSecurityInfo;                                        
                    SqlConnection conn = new SqlConnection(@"Data Source=" + dataSource + ";Initial Catalog=" + DataBaseName + ";Persist Security Info=" + security + ";User ID=" + user + ";Password=" + password + "");
                    return conn;
                }
                catch { return null; }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = getDBConnection(comboBox1.SelectedValue.ToString()))
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
                    comboBox2.DataSource = list;
                    
                }    
                            
            }
            catch(Exception ex) { }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = getDBConnection(comboBox1.SelectedValue.ToString()))
                {
                    connection.Open();    
                    using (SqlCommand cmd = new SqlCommand("SELECT Guid FROM dbo.Operators WHERE Name like '"+comboBox2.SelectedValue.ToString()+"' ", connection))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                opGuid = dr[0].ToString();
                        }
                    }                    
                }

            }
            catch (Exception ex) { }
        }                
        public void Commit()
        {
            try
            {
                using (SqlConnection connection = getDBConnection(comboBox1.SelectedValue.ToString()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Operators SET Password = '" + newPass + "' WHERE Name like '" + comboBox2.SelectedValue.ToString() + "' ", connection);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Wykonano!");
            }
            catch (Exception ex) { MessageBox.Show("Błąd!\n"+ex); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dataSource))
            {
                ComboBox cbx = comboBox1;
                cbx.DataSource = GetDataBaseList();
            }            
        }

        private void WindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowsAuth.Checked)
            {                
                User.Enabled = false;
                Password.Enabled = false;                
            }
            else
            {
                User.Enabled = true;
                Password.Enabled = true;
                User.Text = user;
                Password.Text = password;
            }
            windowsAuth = WindowsAuth.Checked;
        }

        private void DataSource_TextChanged(object sender, EventArgs e)
        {
            dataSource = DataSource.Text;
        }

        private void PersistSecurityInfo_CheckedChanged(object sender, EventArgs e)
        {
            persistSecurityInfo = PersistSecurityInfo.Checked;
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            user = User.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            password = Password.Text;
        }
    }
}
