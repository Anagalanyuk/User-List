using System;
using System.Windows.Forms;

namespace User_List
{
	public partial class AuthenticationView : Form
	{
		private ApplicationContext login;
		public AuthenticationView(ApplicationContext login)
		{
			this.login = login;

			InitializeComponent();
		}

		public string NameView => userNameBox.Text;
		public string PasswordView => passwordBox.Text;

		public EventHandler<EventArgs> Login;
		public EventHandler<EventArgs> NameChange;
		public EventHandler<EventArgs> PasswordChange;
		public EventHandler<EventArgs> Register;


		public void isLogin(bool isLogin)
		{
			loginButton.Enabled = isLogin;
		}

		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Login?.Invoke(this, EventArgs.Empty);
		}

		public void NameIcon(bool pictureChage)
		{
			if (pictureChage)
			{
				userNamePicture.Image = Properties.Resources.Correct;
			}
			else
			{
				userNamePicture.Image = Properties.Resources.Incorrect;
			}
		}

		private void PasswordBox_TextChanged(object sender, EventArgs e)
		{
			PasswordChange?.Invoke(this, EventArgs.Empty);
		}

		public void PasswordIcon(bool pictureChange)
		{
			if (pictureChange)
			{
				passwordPicture.Image = Properties.Resources.Correct;
			}
			else
			{
				passwordPicture.Image = Properties.Resources.Incorrect;
			}
		}

		public new void Show()
		{
			login.MainForm = this;
			Application.Run(login);
		}

		private void UserNameBox_TextChanged(object sender, EventArgs e)
		{
			NameChange?.Invoke(this, EventArgs.Empty);
		}

		public void ErrorMessage()
		{
			MessageBox.Show("incorrect username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			Register?.Invoke(this, EventArgs.Empty);
		}
	}
}