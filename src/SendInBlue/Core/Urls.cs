namespace SendInBlue
{
    public static class Urls
    {
        public static string UserCreateUpdate
        {
            get { return BaseUrl + "/user/createdituser"; }
        }

        public static string UserGet
        {
            get { return BaseUrl + "/user/{0}"; }
        }

        public static string ListAddUser
        {
            get { return BaseUrl + "/list/{0}/users"; }
        }

        public static string ListDeleteUser
        {
            get { return BaseUrl + "/list/{0}/delusers"; }
        }

        private static string BaseUrl
        {
            get { return "https://api.sendinblue.com/v2.0"; }
        }
    }
}
