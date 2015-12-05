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

        public static string FolderCreate
        {
            get { return BaseUrl + "/folder"; }
        }

        public static string FolderUpdate
        {
            get { return BaseUrl + "/folder/{0}"; }
        }

        public static string FolderDelete
        {
            get { return BaseUrl + "/folder/{0}"; }
        }

        public static string FolderGet
        {
            get { return BaseUrl + "/folder/{0}"; }
        }

        public static string FolderGetAll
        {
            get { return BaseUrl + "/folder/index/page/{0}/page_limit/{1}"; }
        }

        public static string ListCreate
        {
            get { return BaseUrl + "/list"; }
        }

        public static string ListUpdate
        {
            get { return BaseUrl + "/list/{0}"; }
        }

        public static string ListDelete
        {
            get { return BaseUrl + "/list/{0}"; }
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
