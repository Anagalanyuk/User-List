namespace User_List
{
	internal class RegistrationService
	{
		private bool isNameCorrect;
		private bool isPasswordCorrect;
		private bool isConfirmPasswordCorrect;
		private bool isRepeatName;
		private AuthenticationService AuthenticationService;

		public RegistrationService(AuthenticationService authenticationService, UserListPresenter userListPresenter)
		{
			this.AuthenticationService = authenticationService;
		}

		public bool IsRepeatName(string name)
		{
			isRepeatName = false;
				foreach (User user in AuthenticationService.UsersList)
				{
					if (name == user.Name)
					{
						isRepeatName = true;
					}
				}
			return isRepeatName;
		}

		public bool IconName(string name)
		{
			isNameCorrect = false;
			if (name.Length >= 5)
			{
				isNameCorrect = true;
			}
			return isNameCorrect;
		}

		public bool IconPassword(string password)
		{
			isPasswordCorrect = false;
			if (password.Length > 0)
			{
				isPasswordCorrect = true;
			}
			return isPasswordCorrect;
		}

		public bool IsConfirmPasswordCorrect(string confirmPassword, string password)
		{
			isConfirmPasswordCorrect = false;
			if( confirmPassword.Length > 0 && confirmPassword == password)
			{
				isConfirmPasswordCorrect = true;
			}
			return isConfirmPasswordCorrect;
		}
	}
}