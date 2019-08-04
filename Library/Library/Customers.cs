using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class Customers : Form
	{
		private LIBRARYEntities Dblib;
		private CUSTOMER customer;
		private int idcustumer;
		public Customers()
		{
			InitializeComponent();
			Dblib = new LIBRARYEntities();
		}

		private void Customers_Load(object sender, EventArgs e)
		{
			FilldgvCustomer();
		}

		private async void Addcustomer_Click(object sender, EventArgs e)
		{
			string Name = txtCustomername.Text.Trim();
			string SurName = txtCustomersurname.Text.Trim();
			string mob = txtMobilNum.Text.Trim();
			string address = txtCustomerAddress.Text.Trim();
			string idcard = txtCustomerCardnum.Text.Trim();

			if (checkCustumers(Name, SurName, mob,address,idcard))
			{
				CUSTOMER custs = new CUSTOMER();

				custs.CUSTNAME = Name;
				custs.CUSTSURNAME = SurName;
				custs.MOBIL = mob;
				custs.ADDRESS = address;
				custs.IDENTITYCARDNUMBER = idcard;
				Dblib.CUSTOMERs.Add(custs);
				await Dblib.SaveChangesAsync();
				FilldgvCustomer();
			}
			cleartextbox();
		}

		//* Musterilerin yoxlanilmasi
		private bool checkCustumers(string name,string surname,string mobil, string address, string idcard)
		{

			if (name ==""||surname==""||mobil==""|| address == ""||idcard=="")
			{
				MessageBox.Show("Zehmet olmasa butun xanalari doldurun","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return false;
			}

			if (Dblib.CUSTOMERs.Any(cust => cust.MOBIL == mobil || cust.ADDRESS == address))
			{
				MessageBox.Show("Bele bir istifadeci artiq movcuddur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		//Musteri dgvnin doldurulmasi
		private void FilldgvCustomer()
		{
			dgvCustomers.DataSource = null;
			dgvCustomers.DataSource = Dblib.CUSTOMERs.Where(cust=>cust.DELETED==false).Select(cust => new
			{
				cust.ID,
				Ad_ve_SOyad = cust.CUSTNAME + " " + cust.CUSTSURNAME,
				Sexsiyyet_Vesiqesi_N = cust.IDENTITYCARDNUMBER,
				cust.MOBIL,
				cust.ADDRESS
			}).OrderByDescending(cust => cust.ID).ToList();
		}

		private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			idcustumer = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
			customer = Dblib.CUSTOMERs.Find(idcustumer);
			txtCustomername.Text = customer.CUSTNAME;
			txtCustomersurname.Text = customer.CUSTSURNAME;
			txtMobilNum.Text = customer.MOBIL;
			txtCustomerAddress.Text = customer.ADDRESS;
			txtCustomerCardnum.Text = customer.IDENTITYCARDNUMBER;
		}

		private async void Update_Click(object sender, EventArgs e)
		{
			customer = Dblib.CUSTOMERs.Find(idcustumer);
			customer.CUSTNAME = txtCustomername.Text.Trim();
			customer.CUSTSURNAME = txtCustomersurname.Text.Trim();
			customer.ADDRESS = txtCustomerAddress.Text.Trim();
			customer.MOBIL = txtMobilNum.Text.Trim();
			customer.IDENTITYCARDNUMBER = txtCustomerCardnum.Text.Trim();
			await Dblib.SaveChangesAsync();
			FilldgvCustomer();
			cleartextbox();

		}

		//textboxlarin iclerinin temizlenmesi
		private void cleartextbox()
		{
			txtCustomername.Clear();
			txtCustomersurname.Clear();
			txtMobilNum.Clear();
			txtCustomerCardnum.Clear();
			txtCustomerAddress.Clear();
		}

		private async void DeleteCustumer_Click(object sender, EventArgs e)
		{
			customer = Dblib.CUSTOMERs.Find(idcustumer);
			customer.DELETED = true;
			await Dblib.SaveChangesAsync();
			FilldgvCustomer();
			cleartextbox();
			MessageBox.Show($"{customer.CUSTNAME} secilmis musteri silindi","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
