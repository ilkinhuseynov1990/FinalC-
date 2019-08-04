
using Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class Registrationcs : Form
	{
		private Form _login;
		private LIBRARYEntities DBlib;
		private USER user;
		public Registrationcs(Form Login)
		{
			InitializeComponent();
			_login = Login;
			DBlib = new LIBRARYEntities();
		}

		private void Registrationcs_FormClosing(object sender, FormClosingEventArgs e)
		{
			_login.Close();
		}

		private async void Registrationondatabase_Click(object sender, EventArgs e)
		{

			string Name = txtRegName.Text.Trim();
			string Surname = txtRegSurname.Text.Trim();
			string Password = txtRegpass.Text.Trim();
			string Email = txtRegEmail.Text.Trim();
			string Mobile = txtRegMob.Text.Trim();
			string Phone = txtRegPhone.Text.Trim();
			string Date = txtRegadmit.Text.Trim();


			// cheking registration fields
			bool regCheker = CheckRegfields(Name,Surname,Email,Mobile,Phone,Date,Password);

			if (regCheker)
			{
				string password = Helper.Hashpass(Password);

				user = new USER();
				user.NAME = Name;
				user.SURNAME = Surname;
				user.EMAIL = Email;
				user.MOBILNUMBER = int.Parse(Mobile);
				user.PHONENUMBER = int.Parse(Phone);
				user.ADMITT = DateTime.Parse(Date);
				user.PASSWORD = password;

				if (RegCheckAdmin.Checked)
				{
					user.LEVEL = true;
					user.STATUS = true;
				}

				if (RegCheckUser.Checked)
				{
					user.LEVEL = false;
					user.STATUS = true;
				}

				DBlib.USERS.Add(user);
				await DBlib.SaveChangesAsync();
				MessageBox.Show("Yeni Istifadeci uqurla elave olundu. Zehmet olmasa tesdiqlenmeye gozleyin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtRegName.Clear();
				txtRegSurname.Clear();
				txtRegpass.Clear();
				txtRegEmail.Clear();
				txtRegMob.Clear();
				txtRegPhone.Clear();
				txtRegadmit.Clear();
				RegCheckUser.Checked = false;
				RegCheckAdmin.Checked = false;


			}

		}
		/// <summary>
		/// checking fields in regform
		/// </summary>
		/// <param name="name"> insert name</param>
		/// <param name="surname">insert surname</param>
		/// <param name="email">insert email</param>
		/// <param name="mobile">insert mobile number</param>
		/// <param name="phone">insert phone number</param>
		/// <param name="date">inser date to admitt</param>
		/// <returns> true or false</returns>
		/// 
		private bool CheckRegfields(string name, string surname,string email,string mobile,string phone, string date,string pass)
		{
			if (name ==""||surname==""||email==""|| mobile==""||phone==""||date==""||pass=="")
			{
				MessageBox.Show("Zehmet Olmasa butun saheleri qeyd edin","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
				return false;
			}
			try
			{
				MailAddress mail = new MailAddress(email);
			}
			catch (Exception)
			{
				MessageBox.Show("Zehmet olmasa doqru mail adresi daxil edin","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return false;
			}

			if (DBlib.USERS.Any(use => use.EMAIL == email || use.NAME ==name))
			{
				MessageBox.Show("Bu Mail Adress ve Istifadeci artiq movcuddur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		private void RegCheckAdmin_CheckedChanged(object sender, EventArgs e)
		{
			if (RegCheckAdmin.Checked)
			{
				RegCheckUser.Visible = false;
			}
			else
			{
				RegCheckUser.Visible = true;
			}
		
		}

		private void RegCheckUser_CheckedChanged(object sender, EventArgs e)
		{
			if (RegCheckUser.Checked) {
				RegCheckAdmin.Visible = false;
			}
			else
			{
				RegCheckAdmin.Visible = true;
			}
			
		}
	}
}
