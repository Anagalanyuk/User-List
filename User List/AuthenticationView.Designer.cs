namespace User_List
{
	partial class AuthenticationView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.userName = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.userNameBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordPicture = new System.Windows.Forms.PictureBox();
			this.userNamePicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userNamePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// userName
			// 
			this.userName.AutoSize = true;
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userName.Location = new System.Drawing.Point(12, 23);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(91, 20);
			this.userName.TabIndex = 0;
			this.userName.Text = "User name:";
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.password.Location = new System.Drawing.Point(21, 66);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(82, 20);
			this.password.TabIndex = 1;
			this.password.Text = "Password:";
			// 
			// userNameBox
			// 
			this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userNameBox.Location = new System.Drawing.Point(109, 22);
			this.userNameBox.Name = "userNameBox";
			this.userNameBox.Size = new System.Drawing.Size(265, 26);
			this.userNameBox.TabIndex = 2;
			this.userNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
			// 
			// passwordBox
			// 
			this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordBox.Location = new System.Drawing.Point(109, 60);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(265, 26);
			this.passwordBox.TabIndex = 3;
			this.passwordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
			// 
			// registerButton
			// 
			this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.registerButton.Location = new System.Drawing.Point(109, 92);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(135, 25);
			this.registerButton.TabIndex = 4;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Enabled = false;
			this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.loginButton.Location = new System.Drawing.Point(250, 92);
			this.loginButton.Name = "loginButton";
			this.loginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.loginButton.Size = new System.Drawing.Size(124, 25);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// passwordPicture
			// 
			this.passwordPicture.Enabled = false;
			this.passwordPicture.Image = global::User_List.Properties.Resources.Incorrect;
			this.passwordPicture.Location = new System.Drawing.Point(381, 60);
			this.passwordPicture.Name = "passwordPicture";
			this.passwordPicture.Size = new System.Drawing.Size(20, 26);
			this.passwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.passwordPicture.TabIndex = 7;
			this.passwordPicture.TabStop = false;
			// 
			// userNamePicture
			// 
			this.userNamePicture.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.userNamePicture.Enabled = false;
			this.userNamePicture.Image = global::User_List.Properties.Resources.Incorrect;
			this.userNamePicture.Location = new System.Drawing.Point(381, 22);
			this.userNamePicture.Name = "userNamePicture";
			this.userNamePicture.Size = new System.Drawing.Size(20, 26);
			this.userNamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userNamePicture.TabIndex = 6;
			this.userNamePicture.TabStop = false;
			// 
			// AuthenticationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(413, 130);
			this.Controls.Add(this.passwordPicture);
			this.Controls.Add(this.userNamePicture);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.userNameBox);
			this.Controls.Add(this.password);
			this.Controls.Add(this.userName);
			this.MinimizeBox = false;
			this.Name = "AuthenticationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Authentication";
			((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userNamePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label userName;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.TextBox userNameBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.PictureBox userNamePicture;
		private System.Windows.Forms.PictureBox passwordPicture;
	}
}

