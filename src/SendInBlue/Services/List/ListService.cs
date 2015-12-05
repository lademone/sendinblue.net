using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class ListService : SendInBlueServiceBase
    {
        public static ServiceResponse<ListCreateResponse> Create(ListCreateOptions options)
        {
            Request request = new Request()
            {
                Url = Urls.ListCreate,
                Method = "POST",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<ListCreateResponse>(request);
        }

        public static ServiceResponse<EmptyResponse> Update(int listId, ListCreateOptions options)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.ListUpdate, listId),
                Method = "PUT",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<EmptyResponse>(request);
        }

        public static ServiceResponse<EmptyResponse> Delete(int listId)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.ListDelete, listId),
                Method = "DELETE"
            };

            return Requestor.ExecuteRequest<EmptyResponse>(request);
        }

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
