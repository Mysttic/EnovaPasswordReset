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
            this.SuspendLayout();
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(12, 68);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(152, 20);
            this.tPass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nowe hasło.";
            // 
            // btnLicz
            // 
            this.btnLicz.Location = new System.Drawing.Point(12, 94);
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
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "\r\nPo tej operacji wyłącz i włącz ponownie enova365.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Baza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Operator";
            // 
            // WAlabel
            // 
            this.WAlabel.AutoSize = true;
            this.WAlabel.BackColor = System.Drawing.Color.Red;
            this.WAlabel.Location = new System.Drawing.Point(242, 12);
            this.WAlabel.Name = "WAlabel";
            this.WAlabel.Size = new System.Drawing.Size(10, 13);
            this.WAlabel.TabIndex = 14;
            this.WAlabel.Text = " ";
            // 
            // FrmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 152);
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
    }
}

