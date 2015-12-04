using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class ListService : SendInBlueServiceBase
    {
        public static ServiceResponse<ListAddUserResponse> AddUser(int listId, ListAddUserOptions options)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.ListAddUser, listId),
                Method = "POST",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<ListAddUserResponse>(request);
        }

        public static ServiceResponse<ListDeleteUserResponse> DeleteUser(int listId, ListDeleteUserOptions options)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.ListDeleteUser, listId),
                Method = "PUT",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<ListDeleteUserResponse>(request);
        }
    }
}
