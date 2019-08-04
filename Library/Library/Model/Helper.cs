using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
	public static class Helper
	{
		public static string Hashpass(string str)
		{
			byte[] passHassCode = Encoding.ASCII.GetBytes(str);
			byte[] pass = new SHA256Managed().ComputeHash(passHassCode);
			return Encoding.ASCII.GetString(pass);
		}
	}
}
