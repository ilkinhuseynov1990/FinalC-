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
	public partial class Delivarybookss : Form
	{
		private LIBRARYEntities Dblib;
		public Delivarybookss()
		{
			InitializeComponent();
			Dblib = new LIBRARYEntities();
		}

		private void Delivarybookss_Load(object sender, EventArgs e)
		{
			dgvDelivarybook.DataSource = Dblib.ORDERS.Where(ord => ord.DELEVERYBOOK == true).Select(ord => new
			{
				ord.ID,
				Tehvil_tarixi=ord.DELIVARYORDERDATE,
				Oxucu_Ad_Soyad=ord.CUSTOMER.CUSTNAME +" "+ ord.CUSTOMER.CUSTSURNAME,
				Tehvi_verilen_Kitab = ord.BOOK.BOOKNAME
			}).OrderByDescending(ord=>ord.ID).ToList();
		}
	}
}
