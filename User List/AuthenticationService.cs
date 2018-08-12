using System.Collections.ObjectModel;

namespace User_List
{
	class AuthenticationService
	{
		private Collection<User> userList;
		private bool isUser;
		private bool nameValid;
		private bool passwordValid;
		private bool correctNameLogin;

		public AuthenticationService()
		{
			userList = new Collection<User>();
		}

		public Collection<User> UsersList => userList; 

		public bool isRepeat(User userItem)
		{
			isUser = false;
			foreach (User user in userList)
			{
				if (user.Name == userItem.Name && user.Password == userItem.Password)
				{
					isUser = true;
					break;
				}
			}
			return isUser;
		}

		public bool nameCorrect(string name)
		{
			nameValid = false;
			if(name.Length >= 5)
			{
				nameValid = true;
			}
			return nameValid;
		}

		public bool passwordCorrect (string password)
		{
			passwordValid = false;
			if(password.Length > 0)
			{
				passwordValid = true;
			}
			return passwordValid;
		}

		public bool IsLogin(string name, string password)
		{
			correctNameLogin = false;
            if(name.Length >= 5 && password.Length > 0)
			{
				correctNameLogin = true; 
			}
			return correctNameLogin;
		}
	}
}
