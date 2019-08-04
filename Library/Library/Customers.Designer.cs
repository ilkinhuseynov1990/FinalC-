namespace Library
{
	partial class Customers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomername = new System.Windows.Forms.TextBox();
			this.txtCustomersurname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMobilNum = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Addcustomer = new System.Windows.Forms.Button();
			this.txtCustomerCardnum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Update = new System.Windows.Forms.Button();
			this.DeleteCustumer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvCustomers.Location = new System.Drawing.Point(0, 214);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.Size = new System.Drawing.Size(800, 236);
			this.dgvCustomers.TabIndex = 0;
			this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name";
			// 
			// txtCustomername
			// 
			this.txtCustomername.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCustomername.Location = new System.Drawing.Point(16, 36);
			this.txtCustomername.Name = "txtCustomername";
			this.txtCustomername.Size = new System.Drawing.Size(170, 32);
			this.txtCustomername.TabIndex = 9;
			// 
			// txtCustomersurname
			// 
			this.txtCustomersurname.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCustomersurname.Location = new System.Drawing.Point(16, 99);
			this.txtCustomersurname.Name = "txtCustomersurname";
			this.txtCustomersurname.Size = new System.Drawing.Size(170, 32);
			this.txtCustomersurname.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(16, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "Surname";
			// 
			// txtMobilNum
			// 
			this.txtMobilNum.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtMobilNum.Location = new System.Drawing.Point(220, 36);
			this.txtMobilNum.Name = "txtMobilNum";
			this.txtMobilNum.Size = new System.Drawing.Size(170, 32);
			this.txtMobilNum.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(221, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 24);
			this.label3.TabIndex = 12;
			this.label3.Text = "Mobil";
			// 
			// txtCustomerAddress
			// 
			this.txtCustomerAddress.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCustomerAddress.Location = new System.Drawing.Point(220, 99);
			this.txtCustomerAddress.Name = "txtCustomerAddress";
			this.txtCustomerAddress.Size = new System.Drawing.Size(170, 32);
			this.txtCustomerAddress.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(223, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "Address";
			// 
			// Addcustomer
			// 
			this.Addcustomer.Location = new System.Drawing.Point(415, 100);
			this.Addcustomer.Name = "Addcustomer";
			this.Addcustomer.Size = new System.Drawing.Size(80, 32);
			this.Addcustomer.TabIndex = 16;
			this.Addcustomer.Text = "Add";
			this.Addcustomer.UseVisualStyleBackColor = true;
			this.Addcustomer.Click += new System.EventHandler(this.Addcustomer_Click);
			// 
			// txtCustomerCardnum
			// 
			this.txtCustomerCardnum.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCustomerCardnum.Location = new System.Drawing.Point(415, 36);
			this.txtCustomerCardnum.Name = "txtCustomerCardnum";
			this.txtCustomerCardnum.Size = new System.Drawing.Size(170, 32);
			this.txtCustomerCardnum.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(416, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(177, 24);
			this.label5.TabIndex = 17;
			this.label5.Text = "Id Card Number";
			// 
			// Update
			// 
			this.Update.Location = new System.Drawing.Point(501, 100);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(80, 32);
			this.Update.TabIndex = 19;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// DeleteCustumer
			// 
			this.DeleteCustumer.Location = new System.Drawing.Point(587, 100);
			this.DeleteCustumer.Name = "DeleteCustumer";
			this.DeleteCustumer.Size = new System.Drawing.Size(80, 32);
			this.DeleteCustumer.TabIndex = 20;
			this.DeleteCustumer.Text = "Delete";
			this.DeleteCustumer.UseVisualStyleBackColor = true;
			this.DeleteCustumer.Click += new System.EventHandler(this.DeleteCustumer_Click);
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DeleteCustumer);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.txtCustomerCardnum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Addcustomer);
			this.Controls.Add(this.txtCustomerAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMobilNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomersurname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCustomername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCustomers);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Customers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Musterilerin qeydiyyata alinmasi";
			this.Load += new System.EventHandler(this.Customers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomername;
		private System.Windows.Forms.TextBox txtCustomersurname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMobilNum;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Addcustomer;
		private System.Windows.Forms.TextBox txtCustomerCardnum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button DeleteCustumer;
	}
}