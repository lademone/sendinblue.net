using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class UserService : SendInBlueServiceBase
    {
        public static ServiceResponse<UserCreateUpdateResponse> Create(UserCreateUpdateOptions options)
        {
            Request request = new Request()
            {
                Url = Urls.UserCreateUpdate,
                Method = "POST",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<UserCreateUpdateResponse>(request);
        }

        public static ServiceResponse<UserGetResponse> Get(UserGetOptions options)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.UserGet, options.Email),
                Method = "GET"
            };

            return Requestor.ExecuteRequest<UserGetResponse>(request);
        }
    }
}
