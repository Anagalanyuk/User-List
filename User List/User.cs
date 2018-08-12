using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_List
{
	internal sealed class User
	{
		private readonly string name = string.Empty;
		private readonly string password = string.Empty;

		public User(string name, string password)
		{
			this.name = name;
			this.password = password;
		}

		public string Name => name;
		public string Password => password;
	}
}
