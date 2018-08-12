using System;
using System.Windows.Forms;

namespace User_List
{
	internal class RegistrationPresenter
	{
		private RegistrationView register;
		private RegistrationService registration;
		private UserListPresenter userListPresenter;
		private AuthenticationView AuthenticationView;
		private AuthenticationService AuthenticationService;

		public RegistrationPresenter(RegistrationView register, RegistrationService registration, UserListPresenter userListPresenter, AuthenticationView authenticationView, AuthenticationService authenticationService)
		{
			this.register = register;
			this.registration = registration;
			this.userListPresenter = userListPresenter;
			this.AuthenticationView = authenticationView;
			this.AuthenticationService = authenticationService;

			SubscribeToViewEvents();
		}

		private void SubscribeToViewEvents()
		{
			register.IconConfirmPassword += IconConfirmPassword_View;
			register.IconName += IconNameView;
			register.IconPassword += IconPassword_View;
			register.CancelClick += CancelClick_View;
			register.RegisterClick += RegisterClick_View;
		}

		private void RegisterClick_View(object sender, EventArgs e)
		{
			User user = new User(register.NameUser, register.Password);
			userListPresenter.AddUser(register.NameUser);
			AuthenticationService.UsersList.Add(user);
			MessageBox.Show("User " + register.NameUser + " successfully registered", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			register.IsRegister(!registration.IsRepeatName(register.NameUser) && registration.IconName(register.NameUser) && registration.IconPassword(register.Password) &&
			registration.IsConfirmPasswordCorrect(register.ConfirmPassword, register.Password));
		}

		private void CancelClick_View(object sender, EventArgs e)
		{
			userListPresenter.Run();
			register.Close();

		}

		private void IconConfirmPassword_View(object sender, EventArgs e)
		{
			register.IsRegister(!registration.IsRepeatName(register.NameUser) && registration.IconName(register.NameUser) && registration.IconPassword(register.Password) &&
			registration.IsConfirmPasswordCorrect(register.ConfirmPassword, register.Password));

			register.ConfirmPasswordIcon(registration.IsConfirmPasswordCorrect(register.ConfirmPassword, register.Password));
		}

		private void IconNameView(object sender, EventArgs e)
		{
			register.IsRegister(!registration.IsRepeatName(register.NameUser) && registration.IconName(register.NameUser) && registration.IconPassword(register.Password) &&
			registration.IsConfirmPasswordCorrect(register.ConfirmPassword, register.Password));

			register.NameIcon(registration.IconName(register.NameUser));
		}

		private void IconPassword_View(object sender, EventArgs e)
		{
			register.IsRegister(!registration.IsRepeatName(register.NameUser) && registration.IconName(register.NameUser) && registration.IconPassword(register.Password) &&
			registration.IsConfirmPasswordCorrect(register.ConfirmPassword, register.Password));

			register.ConfirmPasswordIcon(registration.IsConfirmPasswordCorrect(register.ConfirmPassword, register.Password));

			register.PasswordIcon(registration.IconPassword(register.Password));
		}

		public void Run()
		{
			register.Show();
		}
	}
}