namespace Enova.PasswordReset
{
	partial class FrmPasswordReset
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordReset));
            this.tPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLicz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WAlabel = new System.Windows.Forms.Label();
            this.DataSource = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.WindowsAuth = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PersistSecurityInfo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(12, 183);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(152, 20);
            this.tPass.TabIndex = 2;
            this.tPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nowe hasło.";
            // 
            // btnLicz
            // 
            this.btnLicz.Location = new System.Drawing.Point(12, 209);
            this.btnLicz.Name = "btnLicz";
            this.btnLicz.Size = new System.Drawing.Size(152, 23);
            this.btnLicz.TabIndex = 7;
            this.btnLicz.Text = "Wykonaj";
            this.btnLicz.UseVisualStyleBackColor = true;
            this.btnLicz.Click += new System.EventHandler(this.btnLicz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "\r\nPo tej operacji wyłącz i włącz ponownie enova365.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Baza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Operator";
            // 
            // WAlabel
            // 
            this.WAlabel.AutoSize = true;
            this.WAlabel.BackColor = System.Drawing.Color.Red;
            this.WAlabel.Location = new System.Drawing.Point(244, 108);
            this.WAlabel.Name = "WAlabel";
            this.WAlabel.Size = new System.Drawing.Size(10, 13);
            this.WAlabel.TabIndex = 14;
            this.WAlabel.Text = " ";
            // 
            // DataSource
            // 
            this.DataSource.Location = new System.Drawing.Point(12, 12);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(152, 20);
            this.DataSource.TabIndex = 15;
            this.DataSource.TextChanged += new System.EventHandler(this.DataSource_TextChanged);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(12, 61);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(152, 20);
            this.User.TabIndex = 16;
            this.User.TextChanged += new System.EventHandler(this.User_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 87);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(152, 20);
            this.Password.TabIndex = 17;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // WindowsAuth
            // 
            this.WindowsAuth.AutoSize = true;
            this.WindowsAuth.Location = new System.Drawing.Point(12, 38);
            this.WindowsAuth.Name = "WindowsAuth";
            this.WindowsAuth.Size = new System.Drawing.Size(92, 17);
            this.WindowsAuth.TabIndex = 18;
            this.WindowsAuth.Text = "WindowsAuth";
            this.WindowsAuth.UseVisualStyleBackColor = true;
            this.WindowsAuth.CheckedChanged += new System.EventHandler(this.WindowsAuth_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(190, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "@";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersistSecurityInfo
            // 
            this.PersistSecurityInfo.AutoSize = true;
            this.PersistSecurityInfo.Location = new System.Drawing.Point(100, 38);
            this.PersistSecurityInfo.Name = "PersistSecurityInfo";
            this.PersistSecurityInfo.Size = new System.Drawing.Size(64, 17);
            this.PersistSecurityInfo.TabIndex = 20;
            this.PersistSecurityInfo.Text = "Security";
            this.PersistSecurityInfo.UseVisualStyleBackColor = true;
            this.PersistSecurityInfo.CheckedChanged += new System.EventHandler(this.PersistSecurityInfo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Instancja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "SQL User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "SQL Pass";
            // 
            // FrmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 270);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersistSecurityInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WindowsAuth);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.DataSource);
            this.Controls.Add(this.WAlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLicz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPasswordReset";
            this.Text = "Reseter haseł enova365";
            this.Load += new System.EventHandler(this.FrmPasswordReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLicz;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label WAlabel;
        private System.Windows.Forms.TextBox DataSource;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.CheckBox WindowsAuth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox PersistSecurityInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}

