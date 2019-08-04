namespace Library
{
	partial class Delivarybookss
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivarybookss));
			this.dgvDelivarybook = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDelivarybook)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDelivarybook
			// 
			this.dgvDelivarybook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDelivarybook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDelivarybook.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvDelivarybook.Location = new System.Drawing.Point(0, 0);
			this.dgvDelivarybook.Name = "dgvDelivarybook";
			this.dgvDelivarybook.Size = new System.Drawing.Size(800, 248);
			this.dgvDelivarybook.TabIndex = 0;
			// 
			// Delivarybookss
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvDelivarybook);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Delivarybookss";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivarybookss";
			this.Load += new System.EventHandler(this.Delivarybookss_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDelivarybook)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDelivarybook;
	}
}