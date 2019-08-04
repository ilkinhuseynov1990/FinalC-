namespace Library
{
	partial class UserDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.musterininElaveEdilmesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kitablarinElaveEdilmesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allCustumers = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Allbooks = new System.Windows.Forms.ComboBox();
			this.UpdateFom = new System.Windows.Forms.Button();
			this.takeBooktime = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.backtolibrary = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBookCount = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.kitabiTehvilVerenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oxuculardaQalanKitablarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUser
			// 
			this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvUser.Location = new System.Drawing.Point(0, 216);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.Size = new System.Drawing.Size(800, 234);
			this.dgvUser.TabIndex = 0;
			this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musterininElaveEdilmesiToolStripMenuItem,
            this.kitablarinElaveEdilmesiToolStripMenuItem,
            this.kitabiTehvilVerenlerToolStripMenuItem,
            this.oxuculardaQalanKitablarToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// musterininElaveEdilmesiToolStripMenuItem
			// 
			this.musterininElaveEdilmesiToolStripMenuItem.Name = "musterininElaveEdilmesiToolStripMenuItem";
			this.musterininElaveEdilmesiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.musterininElaveEdilmesiToolStripMenuItem.Text = "Musterinin Elave Edilmesi";
			this.musterininElaveEdilmesiToolStripMenuItem.Click += new System.EventHandler(this.musterininElaveEdilmesiToolStripMenuItem_Click);
			// 
			// kitablarinElaveEdilmesiToolStripMenuItem
			// 
			this.kitablarinElaveEdilmesiToolStripMenuItem.Name = "kitablarinElaveEdilmesiToolStripMenuItem";
			this.kitablarinElaveEdilmesiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.kitablarinElaveEdilmesiToolStripMenuItem.Text = "Kitablarin Elave Edilmesi";
			this.kitablarinElaveEdilmesiToolStripMenuItem.Click += new System.EventHandler(this.kitablarinElaveEdilmesiToolStripMenuItem_Click);
			// 
			// allCustumers
			// 
			this.allCustumers.FormattingEnabled = true;
			this.allCustumers.Location = new System.Drawing.Point(12, 63);
			this.allCustumers.Name = "allCustumers";
			this.allCustumers.Size = new System.Drawing.Size(224, 21);
			this.allCustumers.TabIndex = 2;
			this.allCustumers.SelectedValueChanged += new System.EventHandler(this.allCustumers_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "Musteriler";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(272, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 23;
			this.label2.Text = "Kitablar";
			// 
			// Allbooks
			// 
			this.Allbooks.FormattingEnabled = true;
			this.Allbooks.Location = new System.Drawing.Point(276, 63);
			this.Allbooks.Name = "Allbooks";
			this.Allbooks.Size = new System.Drawing.Size(224, 21);
			this.Allbooks.TabIndex = 24;
			this.Allbooks.SelectedValueChanged += new System.EventHandler(this.Allbooks_SelectedValueChanged);
			// 
			// UpdateFom
			// 
			this.UpdateFom.Location = new System.Drawing.Point(522, 38);
			this.UpdateFom.Name = "UpdateFom";
			this.UpdateFom.Size = new System.Drawing.Size(65, 46);
			this.UpdateFom.TabIndex = 25;
			this.UpdateFom.Text = "Sehifeni yenile";
			this.UpdateFom.UseVisualStyleBackColor = true;
			this.UpdateFom.Click += new System.EventHandler(this.UpdateFom_Click);
			// 
			// takeBooktime
			// 
			this.takeBooktime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.takeBooktime.Location = new System.Drawing.Point(12, 130);
			this.takeBooktime.Name = "takeBooktime";
			this.takeBooktime.Size = new System.Drawing.Size(94, 20);
			this.takeBooktime.TabIndex = 26;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(12, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(268, 24);
			this.label3.TabIndex = 27;
			this.label3.Text = "Kitabin Goturulme Tarixi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(12, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(288, 24);
			this.label4.TabIndex = 28;
			this.label4.Text = "Kitabin Tehvil verilme tarix";
			// 
			// backtolibrary
			// 
			this.backtolibrary.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.backtolibrary.Location = new System.Drawing.Point(12, 183);
			this.backtolibrary.Name = "backtolibrary";
			this.backtolibrary.Size = new System.Drawing.Size(94, 20);
			this.backtolibrary.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(326, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 24);
			this.label5.TabIndex = 30;
			this.label5.Text = "Kitab Sayi";
			// 
			// txtBookCount
			// 
			this.txtBookCount.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBookCount.Location = new System.Drawing.Point(321, 148);
			this.txtBookCount.Name = "txtBookCount";
			this.txtBookCount.Size = new System.Drawing.Size(119, 32);
			this.txtBookCount.TabIndex = 32;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(522, 134);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(65, 46);
			this.Add.TabIndex = 33;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Update
			// 
			this.Update.Location = new System.Drawing.Point(593, 134);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(65, 46);
			this.Update.TabIndex = 34;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(664, 134);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(65, 46);
			this.Delete.TabIndex = 35;
			this.Delete.Text = "Return to Library";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// kitabiTehvilVerenlerToolStripMenuItem
			// 
			this.kitabiTehvilVerenlerToolStripMenuItem.Name = "kitabiTehvilVerenlerToolStripMenuItem";
			this.kitabiTehvilVerenlerToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.kitabiTehvilVerenlerToolStripMenuItem.Text = "Kitabi Tehvil Verenler";
			this.kitabiTehvilVerenlerToolStripMenuItem.Click += new System.EventHandler(this.kitabiTehvilVerenlerToolStripMenuItem_Click);
			// 
			// oxuculardaQalanKitablarToolStripMenuItem
			// 
			this.oxuculardaQalanKitablarToolStripMenuItem.Name = "oxuculardaQalanKitablarToolStripMenuItem";
			this.oxuculardaQalanKitablarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.oxuculardaQalanKitablarToolStripMenuItem.Text = "Oxucularda Qalan kitablar";
			this.oxuculardaQalanKitablarToolStripMenuItem.Click += new System.EventHandler(this.oxuculardaQalanKitablarToolStripMenuItem_Click);
			// 
			// UserDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.txtBookCount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.backtolibrary);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.takeBooktime);
			this.Controls.Add(this.UpdateFom);
			this.Controls.Add(this.Allbooks);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.allCustumers);
			this.Controls.Add(this.dgvUser);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "UserDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserDashboard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDashboard_FormClosing);
			this.Load += new System.EventHandler(this.UserDashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUser;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem musterininElaveEdilmesiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kitablarinElaveEdilmesiToolStripMenuItem;
		private System.Windows.Forms.ComboBox allCustumers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Allbooks;
		private System.Windows.Forms.Button UpdateFom;
		private System.Windows.Forms.DateTimePicker takeBooktime;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker backtolibrary;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBookCount;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.ToolStripMenuItem kitabiTehvilVerenlerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oxuculardaQalanKitablarToolStripMenuItem;
	}
}