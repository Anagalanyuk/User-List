using System;
using System.Windows.Forms;

namespace User_List
{
	internal partial class RegistrationView : Form
	{
		private Label userName;
		private Label password;
		private Label confirmPassword;
		private TextBox userNameBox;
		private TextBox passwordBox;
		private TextBox confirmPasswordBox;
		private Button cancelButton;
		private Button registerButton;
		private PictureBox pictureName;
		private PictureBox picturePassword;
		private PictureBox pictureConfirmPassword;
		private ApplicationContext register;

		public RegistrationView(ApplicationContext register)
		{
			this.register = register;

			InitializeComponent();
		}

		public EventHandler<EventArgs> IconConfirmPassword;
		public EventHandler<EventArgs> IconName;
		public EventHandler<EventArgs> IconPassword;
		public EventHandler<EventArgs> CancelClick;
		public EventHandler<EventArgs> RegisterClick;

		public string ConfirmPassword => confirmPasswordBox.Text;
		public string NameUser => userNameBox.Text;
		public string Password => passwordBox.Text;

		public new void Show()
		{
			register.MainForm = this;
			base.Show();
		}

		private void InitializeComponent()
		{
			this.userName = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.confirmPassword = new System.Windows.Forms.Label();
			this.userNameBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.confirmPasswordBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.pictureName = new System.Windows.Forms.PictureBox();
			this.picturePassword = new System.Windows.Forms.PictureBox();
			this.pictureConfirmPassword = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureConfirmPassword)).BeginInit();
			this.SuspendLayout();
			// 
			// userName
			// 
			this.userName.AutoSize = true;
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userName.Location = new System.Drawing.Point(61, 26);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(83, 20);
			this.userName.TabIndex = 0;
			this.userName.Text = "Username";
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.password.Location = new System.Drawing.Point(66, 63);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(78, 20);
			this.password.TabIndex = 1;
			this.password.Text = "Password";
			// 
			// confirmPassword
			// 
			this.confirmPassword.AutoSize = true;
			this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.confirmPassword.Location = new System.Drawing.Point(12, 99);
			this.confirmPassword.Name = "confirmPassword";
			this.confirmPassword.Size = new System.Drawing.Size(136, 20);
			this.confirmPassword.TabIndex = 2;
			this.confirmPassword.Text = "Confirm password";
			// 
			// userNameBox
			// 
			this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userNameBox.Location = new System.Drawing.Point(165, 26);
			this.userNameBox.Name = "userNameBox";
			this.userNameBox.Size = new System.Drawing.Size(265, 26);
			this.userNameBox.TabIndex = 3;
			this.userNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
			// 
			// passwordBox
			// 
			this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordBox.Location = new System.Drawing.Point(165, 63);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(265, 26);
			this.passwordBox.TabIndex = 4;
			this.passwordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
			// 
			// confirmPasswordBox
			// 
			this.confirmPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.confirmPasswordBox.Location = new System.Drawing.Point(165, 99);
			this.confirmPasswordBox.Name = "confirmPasswordBox";
			this.confirmPasswordBox.Size = new System.Drawing.Size(265, 26);
			this.confirmPasswordBox.TabIndex = 5;
			this.confirmPasswordBox.TextChanged += new System.EventHandler(this.ConfirmPasswordBox_TextChanged);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cancelButton.Location = new System.Drawing.Point(298, 138);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(132, 29);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Enabled = false;
			this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.registerButton.Location = new System.Drawing.Point(165, 138);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(127, 29);
			this.registerButton.TabIndex = 7;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// pictureName
			// 
			this.pictureName.Image = global::User_List.Properties.Resources.Incorrect;
			this.pictureName.Location = new System.Drawing.Point(436, 26);
			this.pictureName.Name = "pictureName";
			this.pictureName.Size = new System.Drawing.Size(31, 26);
			this.pictureName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureName.TabIndex = 8;
			this.pictureName.TabStop = false;
			// 
			// picturePassword
			// 
			this.picturePassword.Image = global::User_List.Properties.Resources.Incorrect;
			this.picturePassword.Location = new System.Drawing.Point(436, 63);
			this.picturePassword.Name = "picturePassword";
			this.picturePassword.Size = new System.Drawing.Size(30, 26);
			this.picturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturePassword.TabIndex = 9;
			this.picturePassword.TabStop = false;
			// 
			// pictureConfirmPassword
			// 
			this.pictureConfirmPassword.Image = global::User_List.Properties.Resources.Incorrect;
			this.pictureConfirmPassword.Location = new System.Drawing.Point(436, 99);
			this.pictureConfirmPassword.Name = "pictureConfirmPassword";
			this.pictureConfirmPassword.Size = new System.Drawing.Size(31, 25);
			this.pictureConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureConfirmPassword.TabIndex = 10;
			this.pictureConfirmPassword.TabStop = false;
			// 
			// RegistrationView
			// 
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(473, 173);
			this.Controls.Add(this.pictureConfirmPassword);
			this.Controls.Add(this.picturePassword);
			this.Controls.Add(this.pictureName);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.confirmPasswordBox);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.userNameBox);
			this.Controls.Add(this.confirmPassword);
			this.Controls.Add(this.password);
			this.Controls.Add(this.userName);
			this.Name = "RegistrationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration";
			((System.ComponentModel.ISupportInitialize)(this.pictureName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureConfirmPassword)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public void IsRegister(bool isRegister)
		{
			registerButton.Enabled = isRegister;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			CancelClick?.Invoke(this, EventArgs.Empty);
		}

		private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
		{
			IconConfirmPassword?.Invoke(this, EventArgs.Empty);
		}

		public void ConfirmPasswordIcon(bool isCorrect)
		{
			if(isCorrect)
			{
				pictureConfirmPassword.Image = Properties.Resources.Correct;
			}
			else
			{
				pictureConfirmPassword.Image = Properties.Resources.Incorrect;
			}
		}

		private void PasswordBox_TextChanged(object sender, EventArgs e)
		{
			IconPassword?.Invoke(this, EventArgs.Empty);
		}

		public void PasswordIcon(bool iscorrect)
		{
			if(iscorrect)
			{
				picturePassword.Image = Properties.Resources.Correct;
			}
			else
			{
				picturePassword.Image = Properties.Resources.Incorrect;
			}
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			RegisterClick?.Invoke(this, EventArgs.Empty);
		}

		private void UserNameBox_TextChanged(object sender, EventArgs e)
		{
			IconName?.Invoke(this, EventArgs.Empty);
		}

		public void NameIcon(bool isCorrect)
		{
			if (isCorrect)
			{
				pictureName.Image = Properties.Resources.Correct;
			}
			else
			{
				pictureName.Image = Properties.Resources.Incorrect;
			}
		}
	}
}