# sendinblue.net
SendInBlue .Net is a client for SendInBlue.com API

Note: It's not contain all API services (only list and user) for the moment

[NuGet downloads](https://img.shields.io/nuget/dt/sendinblue.net.svg)
[NuGet version](https://img.shields.io/nuget/v/sendinblue.net.svg)(http://www.nuget.org/packages/sendinblue.net)

### Add an user

	var options = new UserCreateUpdateOptions()
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