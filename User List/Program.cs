using System;
using System.Windows.Forms;

namespace User_List
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var applicationContext = new ApplicationContext();

			AuthenticationView login = new AuthenticationView(applicationContext);
			UserListView userList = new UserListView(applicationContext);
			RegistrationView register = new RegistrationView(applicationContext);

			UserListService userService = new UserListService();
			UserListPresenter userPresenter = new UserListPresenter(userList, userService);
			AuthenticationService authenticationService = new AuthenticationService();
			RegistrationService registration = new RegistrationService(authenticationService, userPresenter);
			//AuthenticationPresenter presenter = new AuthenticationPresenter(login, userPresenter, authenticationService, registerPresenter);
			RegistrationPresenter registerPresenter = new RegistrationPresenter(register, registration, userPresenter,login,authenticationService);
			AuthenticationPresenter presenter = new AuthenticationPresenter(login, userPresenter, authenticationService, registerPresenter);
			presenter.Run();
		}
	}
}