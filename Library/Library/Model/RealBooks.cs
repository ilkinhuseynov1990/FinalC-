using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
	public class RealBooks
	{
		public int id { get; set;}
		public string bookkname { get; set;}
		public int? bookcount { get; set;}
		public string author { get; set;}
		public string booktype { get; set;}

		public override string ToString()
		{
			return bookkname;
		}
	}
}
