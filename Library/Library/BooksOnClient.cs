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
	public partial class BooksOnClient : Form
	{
		private  LIBRARYEntities DBlib;
		public BooksOnClient()
		{
			InitializeComponent();
			DBlib = new LIBRARYEntities();
		}

		private void BooksOnClient_Load(object sender, EventArgs e)
		{
			
		}

		private void Showdeliveritime_ValueChanged(object sender, EventArgs e)
		{
			DateTime deliverydate = Showdeliveritime.Value;
			dgvBookonclients.DataSource = null;
			dgvBookonclients.DataSource = DBlib.ORDERS.Where(ord => deliverydate >= ord.DELIVARYORDERDATE).Where(ord=>ord.DELEVERYBOOK == false).Select(ord => new
			{
				ord.ID,
				Goturme_tarixi = ord.CUSTOMERORDERDATE,
				Tehvil_tarixi = ord.DELIVARYORDERDATE,
				Ad_Soyad = ord.CUSTOMER.CUSTNAME + " " + ord.CUSTOMER.CUSTSURNAME,
				Mobil = ord.CUSTOMER.MOBIL,
				Kitab = ord.BOOK.BOOKNAME,
				Kitab_sayi = ord.BOOKCOUNT,
			}).ToList();
		}
	}
}
