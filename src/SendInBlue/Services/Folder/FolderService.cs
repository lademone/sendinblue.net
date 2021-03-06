﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class FolderService : SendInBlueServiceBase
    {
        public static ServiceResponse<FolderCreateResponse> Create(FolderCreateOptions options)
        {
            Request request = new Request()
            {
                Url = Urls.FolderCreate,
                Method = "POST",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<FolderCreateResponse>(request);
        }

        public static ServiceResponse<EmptyResponse> Update(int folderId, FolderUpdateOptions options)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.FolderUpdate, folderId),
                Method = "PUT",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<EmptyResponse>(request);
        }

        public static ServiceResponse<EmptyResponse> Delete(int folderId)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.FolderDelete, folderId),
                Method = "DELETE"
            };

            return Requestor.ExecuteRequest<EmptyResponse>(request);
        }

        public static ServiceResponse<FolderGetResponse> Get(int folderId)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.FolderGet, folderId),
                Method = "GET"
            };

            return Requestor.ExecuteRequest<FolderGetResponse>(request);
        }

        public static ServiceResponse<FolderGetAllResponse> GetAll(FolderGetAllOptions options)
        {
            Request request = new Request()
            {
                Url = String.Format(Urls.FolderGetAll, options.Page, options.PageLimit),
                Method = "GET",
                Content = Serialize(options)
            };

            return Requestor.ExecuteRequest<FolderGetAllResponse>(request);
        }
    }
}
