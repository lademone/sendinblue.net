# sendinblue.net
SendInBlue .Net is a client for SendInBlue.com API

### Add an user

	UserCreateUpdateOptions options = new UserCreateUpdateOptions()
	{
		Email = "johndoe@live.com"
	};

	UserService.Create(options);

### Add an user to a list

	var options = new ListAddUserOptions()
	{
		Users = new List<string>() { "johndoe@live.com" }
	};

	var listId = 1;
	
	ListService.AddUser(listId, options);