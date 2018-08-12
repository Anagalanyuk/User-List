namespace User_List
{
	internal class UserListPresenter
	{
		private UserListView userList;
		private UserListService userService;

		public UserListPresenter(UserListView userList, UserListService userService)
		{
			this.userList = userList;
			this.userService = userService;
		}

		public void AddUser(string user)
		{
			userList.AddUser(user);
		}


		public void Run()
		{
			userList.Show();
		}
	}
}