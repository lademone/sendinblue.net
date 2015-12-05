﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SendInBlue
{
    public class FolderGetAllResponse
    {
        [JsonProperty("folders")]
        public List<Folder> Folders { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_limit")]
        public int PageLimit { get; set; }

        [JsonProperty("total_folder_records")]
        public int TotalFoldeRecords { get; set; }

        public class Folder
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("lists")]
            public List<List> Lists { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("total_blacklisted")]
            public int TotalBlacklisted { get; set; }

            [JsonProperty("total_subscribers")]
            public int TotalSubscribers { get; set; }

            [JsonProperty("unique_subscribers")]
            public int UniqueSubscribers { get; set; }

            public class List
            {
                [JsonProperty("id")]
                public int Id { get; set; }

                [JsonProperty("name")]
                public string Name { get; set; }

                [JsonProperty("total_blacklisted")]
                public int TotalBlacklisted { get; set; }

                [JsonProperty("total_subscribers")]
                public int TotalSubscribers { get; set; }
            }
        }
    }
}
