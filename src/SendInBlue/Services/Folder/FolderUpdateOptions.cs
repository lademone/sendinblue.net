﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class FolderUpdateOptions
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
