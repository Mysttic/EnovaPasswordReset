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
            this.NewPasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExecuteBT = new System.Windows.Forms.Button();
            this.DatabaseCB = new System.Windows.Forms.ComboBox();
            this.OperatorCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SQLUserTB = new System.Windows.Forms.TextBox();
            this.SQLPasswordTB = new System.Windows.Forms.TextBox();
            this.WindowsAuthCB = new System.Windows.Forms.CheckBox();
            this.RefreshBT = new System.Windows.Forms.Button();
            this.SecurityCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InstanceCB = new System.Windows.Forms.ComboBox();
            this.LoadBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPasswordTB.Location = new System.Drawing.Point(12, 337);
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.Size = new System.Drawing.Size(312, 23);
            this.NewPasswordTB.TabIndex = 2;
            this.NewPasswordTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "New password";
            // 
            // ExecuteBT
            // 
            this.ExecuteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExecuteBT.Location = new System.Drawing.Point(12, 366);
            this.ExecuteBT.Name = "ExecuteBT";
            this.ExecuteBT.Size = new System.Drawing.Size(312, 30);
            this.ExecuteBT.TabIndex = 7;
            this.ExecuteBT.Text = "Execute";
            this.ExecuteBT.UseVisualStyleBackColor = true;
            this.ExecuteBT.Click += new System.EventHandler(this.ExecuteBT_Click);
            // 
            // DatabaseCB
            // 
            this.DatabaseCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseCB.FormattingEnabled = true;
            this.DatabaseCB.Location = new System.Drawing.Point(12, 243);
            this.DatabaseCB.Name = "DatabaseCB";
            this.DatabaseCB.Size = new System.Drawing.Size(312, 24);
            this.DatabaseCB.TabIndex = 9;
            this.DatabaseCB.SelectedIndexChanged += new System.EventHandler(this.DatabaseCB_SelectedIndexChanged);
            // 
            // OperatorCB
            // 
            this.OperatorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OperatorCB.FormattingEnabled = true;
            this.OperatorCB.Location = new System.Drawing.Point(12, 290);
            this.OperatorCB.Name = "OperatorCB";
            this.OperatorCB.Size = new System.Drawing.Size(312, 24);
            this.OperatorCB.TabIndex = 10;
            this.OperatorCB.SelectedIndexChanged += new System.EventHandler(this.OperatorCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Operator";
            // 
            // SQLUserTB
            // 
            this.SQLUserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SQLUserTB.Location = new System.Drawing.Point(12, 111);
            this.SQLUserTB.Name = "SQLUserTB";
            this.SQLUserTB.Size = new System.Drawing.Size(312, 23);
            this.SQLUserTB.TabIndex = 16;
            // 
            // SQLPasswordTB
            // 
            this.SQLPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SQLPasswordTB.Location = new System.Drawing.Point(12, 157);
            this.SQLPasswordTB.Name = "SQLPasswordTB";
            this.SQLPasswordTB.Size = new System.Drawing.Size(312, 23);
            this.SQLPasswordTB.TabIndex = 17;
            this.SQLPasswordTB.UseSystemPasswordChar = true;
            // 
            // WindowsAuthCB
            // 
            this.WindowsAuthCB.AutoSize = true;
            this.WindowsAuthCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WindowsAuthCB.Location = new System.Drawing.Point(12, 58);
            this.WindowsAuthCB.Name = "WindowsAuthCB";
            this.WindowsAuthCB.Size = new System.Drawing.Size(112, 21);
            this.WindowsAuthCB.TabIndex = 18;
            this.WindowsAuthCB.Text = "WindowsAuth";
            this.WindowsAuthCB.UseVisualStyleBackColor = true;
            this.WindowsAuthCB.CheckedChanged += new System.EventHandler(this.WindowsAuth_CheckedChanged);
            // 
            // RefreshBT
            // 
            this.RefreshBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshBT.Location = new System.Drawing.Point(12, 186);
            this.RefreshBT.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshBT.Name = "RefreshBT";
            this.RefreshBT.Size = new System.Drawing.Size(312, 30);
            this.RefreshBT.TabIndex = 19;
            this.RefreshBT.Text = "Refresh";
            this.RefreshBT.UseVisualStyleBackColor = true;
            this.RefreshBT.Click += new System.EventHandler(this.RefreshBT_Click);
            // 
            // SecurityCB
            // 
            this.SecurityCB.AutoSize = true;
            this.SecurityCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecurityCB.Location = new System.Drawing.Point(130, 58);
            this.SecurityCB.Name = "SecurityCB";
            this.SecurityCB.Size = new System.Drawing.Size(78, 21);
            this.SecurityCB.TabIndex = 20;
            this.SecurityCB.Text = "Security";
            this.SecurityCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Instance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "SQL User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "SQL Pass";
            // 
            // InstanceCB
            // 
            this.InstanceCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstanceCB.FormattingEnabled = true;
            this.InstanceCB.Location = new System.Drawing.Point(12, 28);
            this.InstanceCB.Name = "InstanceCB";
            this.InstanceCB.Size = new System.Drawing.Size(227, 24);
            this.InstanceCB.TabIndex = 24;
            // 
            // LoadBT
            // 
            this.LoadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadBT.Location = new System.Drawing.Point(249, 28);
            this.LoadBT.Margin = new System.Windows.Forms.Padding(0);
            this.LoadBT.Name = "LoadBT";
            this.LoadBT.Size = new System.Drawing.Size(75, 24);
            this.LoadBT.TabIndex = 25;
            this.LoadBT.Text = "Load";
            this.LoadBT.UseVisualStyleBackColor = true;
            this.LoadBT.Click += new System.EventHandler(this.LoadBT_Click);
            // 
            // FrmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 419);
            this.Controls.Add(this.LoadBT);
            this.Controls.Add(this.InstanceCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecurityCB);
            this.Controls.Add(this.RefreshBT);
            this.Controls.Add(this.WindowsAuthCB);
            this.Controls.Add(this.SQLPasswordTB);
            this.Controls.Add(this.SQLUserTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OperatorCB);
            this.Controls.Add(this.DatabaseCB);
            this.Controls.Add(this.ExecuteBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPasswordTB);
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
		private System.Windows.Forms.TextBox NewPasswordTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ExecuteBT;
        private System.Windows.Forms.ComboBox DatabaseCB;
        private System.Windows.Forms.ComboBox OperatorCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SQLUserTB;
        private System.Windows.Forms.TextBox SQLPasswordTB;
        private System.Windows.Forms.CheckBox WindowsAuthCB;
        private System.Windows.Forms.Button RefreshBT;
        private System.Windows.Forms.CheckBox SecurityCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox InstanceCB;
        private System.Windows.Forms.Button LoadBT;
    }
}

