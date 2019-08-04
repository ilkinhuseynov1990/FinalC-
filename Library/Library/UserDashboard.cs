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
	public partial class UserDashboard : Form
	{
		private Form _login;
		private LIBRARYEntities DBlib;
		private int realCustomers;
		private int realBooks;
		private CUSTOMER custumers;
		private BOOK books;
		private USER _user;
		private ORDER custorder;
		private int orderID;

		public UserDashboard(Form Login, USER user)
		{
			InitializeComponent();
			_login = Login;
			DBlib = new LIBRARYEntities();
			_user = user;
		}

		private void UserDashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			_login.Close();
			

		}

		private void UserDashboard_Load(object sender, EventArgs e)
		{
			
			filldgvUserdashboard();
			fillallcustomers();
			fillallbooks();
		}

		private void musterininElaveEdilmesiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//oxucu eleve etmek
			Customers customer = new Customers();
			customer.ShowDialog();
		}

		private void kitablarinElaveEdilmesiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//kitablari eleve  etmek
			LibraryBooks books = new LibraryBooks();
			books.ShowDialog();
		}

		private void fillallcustomers()
		{
			//oxucularin doldurulmasi
			allCustumers.DataSource = null;
			allCustumers.DataSource = DBlib.CUSTOMERs.Where(cust => cust.DELETED == false).Select(cust => new RealCustomers
			{
				Id = cust.ID,
				custName = cust.CUSTNAME,
				custSurname = cust.CUSTSURNAME,
				custumermobilnum = cust.MOBIL
			}).ToList();
			allCustumers.Text = "";
		}

		private void fillallbooks()
		{
			//kitablarin doldurulmasi
			Allbooks.DataSource = null;
			Allbooks.DataSource = DBlib.BOOKS.Where(book => book.DELETED == false).Select(book => new RealBooks
			{
				id = book.ID,
				bookkname = book.BOOKNAME,
				bookcount = book.BOOKCOUNT,
				author = book.AUTHOR,
				booktype= book.BOOKTYPE
			}).ToList();
			Allbooks.Text = "";
		}

		private void filldgvUserdashboard()
		{
			//istifadeciler ucun sifaris cedvelinin doldurlmasi
			dgvUser.DataSource = null;
			dgvUser.DataSource = DBlib.ORDERS.Where(ord => ord.DELEVERYBOOK == false).Select(ord => new
			{
				ord.ID,
				Sifaris_tarixi = ord.CUSTOMERORDERDATE,
				Tehvil_Tarixi = ord.DELIVARYORDERDATE,
				Oxucu_adi = ord.CUSTOMER.CUSTNAME,
				Oxucu_soyadi = ord.CUSTOMER.CUSTSURNAME,
				Kitab_Adi = ord.BOOK.BOOKNAME,
				Kitabin_Novu = ord.BOOK.BOOKTYPE,
				Kitabin_Muellifi = ord.BOOK.AUTHOR,
				Oxucucun_Kitab_Sayi = ord.BOOKCOUNT,
				Kitab_sayi = ord.BOOK.BOOKCOUNT,
				Qaytarilmamis_kitablar = ord.DELEVERYBOOK
			}).OrderByDescending(ord => ord.ID).ToList();
		}

		private void UpdateFom_Click(object sender, EventArgs e)
		{
			fillallcustomers();
			fillallbooks();
		}

		private async void Add_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bu kitablari goturmek isdediyinizden eminsinizmi", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			
			if (result == DialogResult.Yes) {
				custorder = new ORDER();
				custorder.CUSTOMERORDERDATE = takeBooktime.Value;
				custorder.DELIVARYORDERDATE = backtolibrary.Value;
				custorder.CUSTOMERID = custumers.ID;
				custorder.BOOKSID = books.ID;
				custorder.BOOKCOUNT = int.Parse(txtBookCount.Text);
				custorder.USERSID = _user.ID;
				DBlib.ORDERS.Add(custorder);
				int kCount = books.BOOKCOUNT - custorder.BOOKCOUNT;
				books.BOOKCOUNT = kCount;
				txtBookCount.Clear();
				await DBlib.SaveChangesAsync();
				filldgvUserdashboard();
				MessageBox.Show("Emeliyyat uqurla yerine yetirildi", "Information",MessageBoxButtons.OK);

			}
			else
			{
				MessageBox.Show("Hec bir emeliyyat Yerine Yetirilmedi","Information");
			}
		}

		private void allCustumers_SelectedValueChanged(object sender, EventArgs e)
		{
			realCustomers = (allCustumers.SelectedItem as RealCustomers).Id;
			custumers = DBlib.CUSTOMERs.Find(realCustomers);

		}

		private void Allbooks_SelectedValueChanged(object sender, EventArgs e)
		{
			realBooks = (Allbooks.SelectedItem as RealBooks).id;
			books = DBlib.BOOKS.Find(realBooks);
		}

		private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			orderID = (int)dgvUser.Rows[e.RowIndex].Cells[0].Value;
			custorder =	DBlib.ORDERS.Find(orderID);

			takeBooktime.Value = custorder.CUSTOMERORDERDATE.Value;
			backtolibrary.Value = custorder.DELIVARYORDERDATE.Value;
			txtBookCount.Text = custorder.BOOKCOUNT.ToString();
			allCustumers.Text = custorder.CUSTOMER.CUSTNAME +" "+ custorder.CUSTOMER.CUSTSURNAME +" "+ custorder.CUSTOMER.MOBIL;
			Allbooks.Text = custorder.BOOK.BOOKNAME;
		}

		private async void Update_Click(object sender, EventArgs e)
		{
			try
			{
				DBlib.CUSTOMERs.Find(orderID);
				custorder.CUSTOMERORDERDATE = takeBooktime.Value;
				custorder.DELIVARYORDERDATE = backtolibrary.Value;
				custorder.CUSTOMERID = custumers.ID;
				custorder.BOOKSID = books.ID;
				custorder.BOOKCOUNT = int.Parse(txtBookCount.Text);
				custorder.USERSID = _user.ID;
				int kCount = books.BOOKCOUNT - custorder.BOOKCOUNT;
				books.BOOKCOUNT = kCount;
				txtBookCount.Clear();
				await DBlib.SaveChangesAsync();
				filldgvUserdashboard();
				MessageBox.Show("Emeliyyat uqurla yerine yetirildi", "Information", MessageBoxButtons.OK);
			}
			catch (Exception)
			{

				MessageBox.Show("Yenilemek ucun hec bir secim etmemisiz", "Information", MessageBoxButtons.OK);
			}
			
		}

		private async void Delete_Click(object sender, EventArgs e)
		{
			try
			{
				DBlib.CUSTOMERs.Find(orderID);
				custorder.DELEVERYBOOK = true;
				books.BOOKCOUNT += custorder.BOOKCOUNT;
				await DBlib.SaveChangesAsync();
				filldgvUserdashboard();
				MessageBox.Show("Emeliyyat uqurla yerine yetirildi", "Information", MessageBoxButtons.OK);
			}
			catch (Exception)
			{
				MessageBox.Show("Silmek ucun secim etmemisiz", "Information", MessageBoxButtons.OK);

			}
			
		}

		private void kitabiTehvilVerenlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Delivarybookss delivarybookss = new Delivarybookss();
			delivarybookss.Show();
		}

		private void oxuculardaQalanKitablarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BooksOnClient booksOnClient = new BooksOnClient();
			booksOnClient.Show();
		}
	}
}
