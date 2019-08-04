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
	public partial class LibraryBooks : Form
	{
		private LIBRARYEntities Dblib;
		private BOOK book;
		private int bookid;
		private int bookcount;
		public LibraryBooks()
		{
			InitializeComponent();
			Dblib = new LIBRARYEntities();
	}

		private void LibraryBooks_Load(object sender, EventArgs e)
		{
			FilldgvBook();
		}

		private async void AddButton_Click(object sender, EventArgs e)
		{
				string bookname = txtBookName.Text.Trim();
				string bookaut = txtBookAutor.Text.Trim();
				string booktype = txtBooktype.Text.Trim();
			    int count=0;
				int.TryParse(txtBookcount.Text,out count);
			    bookcount = count;

				if (checkbook(bookname, booktype, bookaut, bookcount))
				{
				BOOK libbook = new BOOK();
				libbook.BOOKNAME = bookname;
				libbook.AUTHOR = bookaut;
				libbook.BOOKTYPE = booktype;
				libbook.BOOKCOUNT = bookcount;

				Dblib.BOOKS.Add(libbook);
				await Dblib.SaveChangesAsync();
				FilldgvBook();
				clearfields();
				}
			
		}

		//inputlarin yoxlanilmasi
		private bool checkbook(string bname,string btype, string bauthor,int? bcount)
		{
			if (bname ==""||btype==""||bauthor==""||bcount==0)
			{
				MessageBox.Show("Zehmet olmasa butun xanalari doldurun","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return false;
			}

			if (Dblib.BOOKS.Any(book=> book.BOOKNAME == bname))
			{
				MessageBox.Show("Bu kitab artiq Movcuddur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}
		//datagridin doldurulmasi
		private void FilldgvBook()
		{
			dgvBooks.DataSource = null;
			dgvBooks.DataSource = Dblib.BOOKS.Where(book=>book.DELETED == false).Select(book => new {
				book.ID,
				book.BOOKNAME,
				book.BOOKTYPE,
				book.AUTHOR,
				book.BOOKCOUNT
			}).OrderByDescending(book => book.ID).ToList();
		}
		//inputlarin temizlenmesi3
		private void clearfields()
		{
			txtBookName.Clear();
			txtBookAutor.Clear();
			txtBooktype.Clear();
			txtBookcount.Clear();

		}
		//inputlarin datagridden doldurulmasi
		private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bookid = (int)dgvBooks.Rows[e.RowIndex].Cells[0].Value;
			book = Dblib.BOOKS.Find(bookid);
			txtBookName.Text = book.BOOKNAME;
			txtBookAutor.Text = book.AUTHOR;
			txtBooktype.Text = book.BOOKTYPE;
			txtBookcount.Text = book.BOOKCOUNT.ToString();
		}
		//kitablarin yenilenmesi
		private async void Update_Click(object sender, EventArgs e)
		{
			book = Dblib.BOOKS.Find(bookid);
			book.BOOKNAME = txtBookName.Text.Trim();
			book.AUTHOR = txtBookAutor.Text.Trim();
			book.BOOKCOUNT = int.Parse(txtBookcount.Text);
			book.BOOKTYPE = txtBooktype.Text.Trim();
			await Dblib.SaveChangesAsync();
			FilldgvBook();
			clearfields();
		}
		//kitablarin silinmesi
		private async void Delete_Click(object sender, EventArgs e)
		{
			book = Dblib.BOOKS.Find(bookid);
			book.DELETED = true;
			await Dblib.SaveChangesAsync();
			FilldgvBook();
			clearfields();
		}
	}
}
