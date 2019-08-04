namespace Library
{
	partial class Library
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserLogin = new System.Windows.Forms.TextBox();
			this.txtUserPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginTosystem = new System.Windows.Forms.Button();
			this.Registrationbutton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(381, 227);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(26, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Login";
			// 
			// txtUserLogin
			// 
			this.txtUserLogin.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUserLogin.Location = new System.Drawing.Point(191, 11);
			this.txtUserLogin.Name = "txtUserLogin";
			this.txtUserLogin.Size = new System.Drawing.Size(170, 32);
			this.txtUserLogin.TabIndex = 2;
			// 
			// txtUserPass
			// 
			this.txtUserPass.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUserPass.Location = new System.Drawing.Point(191, 65);
			this.txtUserPass.Name = "txtUserPass";
			this.txtUserPass.Size = new System.Drawing.Size(170, 32);
			this.txtUserPass.TabIndex = 4;
			this.txtUserPass.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(26, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = " Password";
			// 
			// LoginTosystem
			// 
			this.LoginTosystem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginTosystem.BackgroundImage")));
			this.LoginTosystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.LoginTosystem.Location = new System.Drawing.Point(191, 103);
			this.LoginTosystem.Name = "LoginTosystem";
			this.LoginTosystem.Size = new System.Drawing.Size(170, 90);
			this.LoginTosystem.TabIndex = 5;
			this.LoginTosystem.UseVisualStyleBackColor = true;
			this.LoginTosystem.Click += new System.EventHandler(this.LoginTosystem_Click);
			// 
			// Registrationbutton
			// 
			this.Registrationbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Registrationbutton.BackgroundImage")));
			this.Registrationbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Registrationbutton.Location = new System.Drawing.Point(12, 103);
			this.Registrationbutton.Name = "Registrationbutton";
			this.Registrationbutton.Size = new System.Drawing.Size(170, 90);
			this.Registrationbutton.TabIndex = 6;
			this.Registrationbutton.UseVisualStyleBackColor = true;
			this.Registrationbutton.Click += new System.EventHandler(this.Registrationbutton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(13, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Registration";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(240, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "Login";
			// 
			// Library
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(381, 227);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Registrationbutton);
			this.Controls.Add(this.LoginTosystem);
			this.Controls.Add(this.txtUserPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUserLogin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Library";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserLogin;
		private System.Windows.Forms.TextBox txtUserPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LoginTosystem;
		private System.Windows.Forms.Button Registrationbutton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

