namespace Library
{
	partial class LibraryBooks
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryBooks));
			this.dgvBooks = new System.Windows.Forms.DataGridView();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBooktype = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBookAutor = new System.Windows.Forms.TextBox();
			this.txtBookcount = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBooks
			// 
			this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvBooks.Location = new System.Drawing.Point(0, 249);
			this.dgvBooks.Name = "dgvBooks";
			this.dgvBooks.Size = new System.Drawing.Size(800, 201);
			this.dgvBooks.TabIndex = 0;
			this.dgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
			// 
			// txtBookName
			// 
			this.txtBookName.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBookName.Location = new System.Drawing.Point(22, 48);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(170, 32);
			this.txtBookName.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(23, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 24);
			this.label1.TabIndex = 21;
			this.label1.Text = "Book Name";
			// 
			// txtBooktype
			// 
			this.txtBooktype.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBooktype.Location = new System.Drawing.Point(22, 121);
			this.txtBooktype.Name = "txtBooktype";
			this.txtBooktype.Size = new System.Drawing.Size(170, 32);
			this.txtBooktype.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(23, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 24);
			this.label2.TabIndex = 23;
			this.label2.Text = "Book Type";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(222, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 24);
			this.label3.TabIndex = 25;
			this.label3.Text = "Author";
			// 
			// txtBookAutor
			// 
			this.txtBookAutor.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBookAutor.Location = new System.Drawing.Point(221, 48);
			this.txtBookAutor.Name = "txtBookAutor";
			this.txtBookAutor.Size = new System.Drawing.Size(170, 32);
			this.txtBookAutor.TabIndex = 26;
			// 
			// txtBookcount
			// 
			this.txtBookcount.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtBookcount.Location = new System.Drawing.Point(221, 121);
			this.txtBookcount.Name = "txtBookcount";
			this.txtBookcount.Size = new System.Drawing.Size(170, 32);
			this.txtBookcount.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(222, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 24);
			this.label4.TabIndex = 27;
			this.label4.Text = "Book Count";
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(413, 48);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(60, 32);
			this.AddButton.TabIndex = 29;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// Update
			// 
			this.Update.Location = new System.Drawing.Point(413, 94);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(60, 32);
			this.Update.TabIndex = 30;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(479, 49);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(60, 32);
			this.Delete.TabIndex = 31;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// LibraryBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.txtBookcount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBookAutor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBooktype);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBookName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvBooks);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LibraryBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LibraryBooks";
			this.Load += new System.EventHandler(this.LibraryBooks_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBooks;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBooktype;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBookAutor;
		private System.Windows.Forms.TextBox txtBookcount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Delete;
	}
}