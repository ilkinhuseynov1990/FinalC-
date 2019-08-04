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
	public partial class Library : Form
	{
		private LIBRARYEntities DBlib;
		public USER user;
		public Library()
		{
			InitializeComponent();
			DBlib = new LIBRARYEntities();
		}

		private void Registrationbutton_Click(object sender, EventArgs e)
		{
			Registrationcs registrationcs = new Registrationcs(this);
			this.Hide();
			registrationcs.Show();
		}

		private void LoginTosystem_Click(object sender, EventArgs e)
		{
			string name = txtUserLogin.Text.Trim();
			string pass = txtUserPass.Text.Trim();


			if (CheckLogin(name, pass)) {

				if (user.LEVEL == true)
				{
					AdminDashboard adminDashboard = new AdminDashboard(this,user);
					adminDashboard.Show();
					this.Hide();
				}
				else
				{
					UserDashboard userDashboard = new UserDashboard(this,user);
					userDashboard.Show();
					this.Hide();
				}


			}


		}


		private bool CheckLogin(string name,string pass)
		{
			if (name == "" || pass == "")
			{
				MessageBox.Show("Zehmet olmasa Parol ve ya Login daxil edin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}

			string hashPass = Helper.Hashpass(pass);

			user = DBlib.USERS.Where(use => use.NAME == name && use.PASSWORD == hashPass && use.DELETED == false).FirstOrDefault();

			if (user == null)
			{
				MessageBox.Show("Bele bir istifadeci yoxdur ", "Information");
				return false;
			}

			if (user.STATUS == false)
			{
				MessageBox.Show("Bu istifadeci tesdiq olunmani gozleyir", "Information");
				return false;
			}
			return true;
		}
	}
}
