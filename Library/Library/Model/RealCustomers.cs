using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
	public class RealCustomers
	{
		public int Id { get; set; }
		public string custName { get; set; }
		public string custSurname { get; set; }
		public string custumermobilnum { get; set; }
		public override string ToString()
		{
			return custName+" "+custSurname+" "+custumermobilnum;
		}
	}
}
