﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
	public class RealEmployee
	{
		public int id { get; set; }

		public string  name { get; set; }

		public string surname { get; set; }

		public override string ToString()
		{
			return name;
		}
	}
}
