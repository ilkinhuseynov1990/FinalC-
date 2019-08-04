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
	public partial class AdminDashboard : Form
	{
		private Form _login;
		private LIBRARYEntities Dblib;
		private USER _user;
		public AdminDashboard(Form Login, USER user)
		{
			InitializeComponent();
			_login = Login;
			_user = user;
			Dblib = new LIBRARYEntities();
		}

		private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			_login.Close();
		}

		private void AdminDashboard_Load(object sender, EventArgs e)
		{

			FillDatagridview(); // admin data gridin doldurulmasi
			int count = Dblib.USERS.Where(user => user.STATUS == false).Count();
			waitConfirmation.Text += " " + count;
			RealUsers.DataSource = Dblib.USERS.Where(user => user.DELETED == false).Select(g => new RealEmployee {
				id = g.ID,
				name = g.NAME,
			}).ToList();
		}

		private void waitConfirmation_Click(object sender, EventArgs e)
		{
			dgvAdmin.DataSource = Dblib.USERS.Where(user => user.STATUS == false).Select(user => new
			{
				user.ID,
				user.NAME,
				user.SURNAME,
				user.EMAIL,
				user.MOBILNUMBER,
				user.PHONENUMBER,
				Ise_qebul_olunma_tarixi = user.ADMITT,
				user.STATUS,
				user.LEVEL,
			}).ToList();
		}

		private void dgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int person = (int)dgvAdmin.Rows[e.RowIndex].Cells[0].Value;
			USER user = Dblib.USERS.Find(person);

			DialogResult result = MessageBox.Show($"{user.NAME} isdifadecini tesdiq edirsinizmi?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result==DialogResult.Yes) {
				user.STATUS = true;
				MessageBox.Show("Emeliyyat uqurla yerine yetirildi");
			}
			else
			{
				DialogResult resultSecond = MessageBox.Show("Qerarinizda eminsinizmi?","Tehluke",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

				if (resultSecond == DialogResult.OK)
				{
					user.DELETED = true;
				}
				else
				{
					MessageBox.Show("Hec bir emeliyyat yerine yetirilmedi","Imformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
					FillDatagridview();
				}
			}

		}

		// Admindata gridin doldurulmasi
		private void FillDatagridview()
		{
			dgvAdmin.DataSource = Dblib.USERS.Where(user => user.DELETED == false).Select(user => new
			{
				user.ID,
				user.NAME,
				user.SURNAME,
				user.EMAIL,
				user.MOBILNUMBER,
				user.PHONENUMBER,
				Ise_qebul_olunma_tarixi = user.ADMITT,
				user.STATUS,
				user.LEVEL,
			}).OrderByDescending(user => user.ID).ToList();
		}

		private void RealUsers_SelectedValueChanged(object sender, EventArgs e)
		{
			int selecteditem = (RealUsers.SelectedItem as RealEmployee).id;

			dgvUseraction.DataSource = Dblib.ORDERS.Where(ord => ord.USERSID == selecteditem).Select(ord => new
			{
				ord.ID,
				ord.BOOK.BOOKNAME,
				Musteri_adi = ord.CUSTOMER.CUSTNAME + " " + ord.CUSTOMER.CUSTSURNAME,
				ord.BOOK.AUTHOR,
				Goturulme_tarixi=ord.CUSTOMERORDERDATE,
				Tehvil_Verme_tarixi =ord.DELIVARYORDERDATE

			}).OrderByDescending(ord=> ord.ID).ToList();
		}
	}
}
