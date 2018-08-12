using System;
using System.Windows.Forms;

namespace User_List
{
	public partial class UserListView : Form
	{
		private Button button1;
		private ListBox usersList;
		private Button deleteButton;
		private ApplicationContext userList;
		
		public UserListView(ApplicationContext userList)
		{
			this.userList = userList;

			InitializeComponent();
		}

		public void AddUser(string name)
		{
			usersList.Items.Add(name);
		}

		public new void Show()
		{
			userList.MainForm = this;
			base.Show();
		}

		private void InitializeComponent()
		{
			this.usersList = new System.Windows.Forms.ListBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usersList
			// 
			this.usersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.usersList.FormattingEnabled = true;
			this.usersList.ItemHeight = 20;
			this.usersList.Location = new System.Drawing.Point(12, 22);
			this.usersList.Name = "usersList";
			this.usersList.Size = new System.Drawing.Size(260, 184);
			this.usersList.TabIndex = 0;
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.Enabled = false;
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteButton.Location = new System.Drawing.Point(12, 215);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(260, 34);
			this.deleteButton.TabIndex = 1;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// UserListView
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.usersList);
			this.Name = "UserListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Users List";
			this.ResumeLayout(false);

		}
	}
}