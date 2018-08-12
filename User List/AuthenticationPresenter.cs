using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_List
{
	internal class AuthenticationPresenter
	{
		private AuthenticationView login;
		private UserListPresenter users;
		private AuthenticationService service;
		private RegistrationPresenter register;

		public AuthenticationPresenter(AuthenticationView login, UserListPresenter users, AuthenticationService service, RegistrationPresenter register)
		{
			this.login = login;
			this.users = users;
			this.service = service;
			this.register = register;

			SubscribeToViewEvents();
		}

		private void SubscribeToViewEvents()
		{
			login.Login += Login_View;
			login.NameChange += NameChanged_View;
			login.PasswordChange += PasswordChange_View;
			login.Register += Register_View;
		}

		private void Register_View(object sender, EventArgs e)
		{
			register.Run();
			login.Close();
		}

		private void PasswordChange_View(object sender, EventArgs e)
		{
			login.isLogin(service.IsLogin(login.NameView, login.PasswordView));
			login.PasswordIcon(service.passwordCorrect(login.PasswordView));
		}

		private void NameChanged_View(object sender, EventArgs e)
		{
			login.isLogin(service.IsLogin(login.NameView, login.PasswordView));
			login.NameIcon(service.nameCorrect(login.NameView));
		}

		private void Login_View(object sender, EventArgs e)
		{
			User user = new User(login.NameView, login.PasswordView);
			if (!service.nameCorrect(login.NameView) || !service.passwordCorrect(login.PasswordView))
			{
				login.ErrorMessage();
			}
			else
			{
				users.Run();
				login.Close();
			}
		}

		public void Run()
		{
			login.Show();
		}
	}
}