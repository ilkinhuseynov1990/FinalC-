namespace Library
{
	partial class AdminDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
			this.dgvAdmin = new System.Windows.Forms.DataGridView();
			this.waitConfirmation = new System.Windows.Forms.Button();
			this.RealUsers = new System.Windows.Forms.ComboBox();
			this.dgvUseraction = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUseraction)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAdmin
			// 
			this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvAdmin.Location = new System.Drawing.Point(0, 204);
			this.dgvAdmin.Name = "dgvAdmin";
			this.dgvAdmin.Size = new System.Drawing.Size(850, 258);
			this.dgvAdmin.TabIndex = 0;
			this.dgvAdmin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellDoubleClick);
			// 
			// waitConfirmation
			// 
			this.waitConfirmation.Location = new System.Drawing.Point(12, 121);
			this.waitConfirmation.Name = "waitConfirmation";
			this.waitConfirmation.Size = new System.Drawing.Size(177, 54);
			this.waitConfirmation.TabIndex = 1;
			this.waitConfirmation.Text = "Tesdiq sayi gozleyenler: ";
			this.waitConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.waitConfirmation.UseVisualStyleBackColor = true;
			this.waitConfirmation.Click += new System.EventHandler(this.waitConfirmation_Click);
			// 
			// RealUsers
			// 
			this.RealUsers.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RealUsers.FormattingEnabled = true;
			this.RealUsers.Location = new System.Drawing.Point(12, 25);
			this.RealUsers.Name = "RealUsers";
			this.RealUsers.Size = new System.Drawing.Size(177, 32);
			this.RealUsers.TabIndex = 3;
			this.RealUsers.SelectedValueChanged += new System.EventHandler(this.RealUsers_SelectedValueChanged);
			// 
			// dgvUseraction
			// 
			this.dgvUseraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUseraction.Location = new System.Drawing.Point(195, 25);
			this.dgvUseraction.Name = "dgvUseraction";
			this.dgvUseraction.Size = new System.Drawing.Size(643, 150);
			this.dgvUseraction.TabIndex = 4;
			// 
			// AdminDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(850, 462);
			this.Controls.Add(this.dgvUseraction);
			this.Controls.Add(this.RealUsers);
			this.Controls.Add(this.waitConfirmation);
			this.Controls.Add(this.dgvAdmin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminDashboard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
			this.Load += new System.EventHandler(this.AdminDashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUseraction)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAdmin;
		private System.Windows.Forms.Button waitConfirmation;
		private System.Windows.Forms.ComboBox RealUsers;
		private System.Windows.Forms.DataGridView dgvUseraction;
	}
}