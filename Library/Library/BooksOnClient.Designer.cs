namespace Library
{
	partial class BooksOnClient
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksOnClient));
			this.dgvBookonclients = new System.Windows.Forms.DataGridView();
			this.Showdeliveritime = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookonclients)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBookonclients
			// 
			this.dgvBookonclients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBookonclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBookonclients.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvBookonclients.Location = new System.Drawing.Point(0, 0);
			this.dgvBookonclients.Name = "dgvBookonclients";
			this.dgvBookonclients.Size = new System.Drawing.Size(800, 348);
			this.dgvBookonclients.TabIndex = 0;
			// 
			// Showdeliveritime
			// 
			this.Showdeliveritime.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Showdeliveritime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.Showdeliveritime.Location = new System.Drawing.Point(12, 354);
			this.Showdeliveritime.Name = "Showdeliveritime";
			this.Showdeliveritime.Size = new System.Drawing.Size(164, 32);
			this.Showdeliveritime.TabIndex = 1;
			this.Showdeliveritime.ValueChanged += new System.EventHandler(this.Showdeliveritime_ValueChanged);
			// 
			// BooksOnClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Showdeliveritime);
			this.Controls.Add(this.dgvBookonclients);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BooksOnClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BooksOnClient";
			this.Load += new System.EventHandler(this.BooksOnClient_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBookonclients)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBookonclients;
		private System.Windows.Forms.DateTimePicker Showdeliveritime;
	}
}