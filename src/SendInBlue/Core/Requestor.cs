using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SendInBlue
{
    internal class Requestor
    {
        internal static ServiceResponse<T> ExecuteRequest<T>(Request request)
        {
            string apiKey = SendInBlueConfiguration.GetApiKey();

            if (String.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException("apiKey");

            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(request.Url);
                webRequest.Method = request.Method;
                webRequest.ContentType = "application/json";
                webRequest.Headers.Add("api-key", apiKey);
                webRequest.UserAgent = "SendInBlue.net (https://github.com/lademone/sendinblue.net)";

                if (request.Method == "POST" || request.Method == "PUT")
                {
                    if (!String.IsNullOrEmpty(request.Content))
                        using (Stream reqStream = webRequest.GetRequestStream())
                        using (StreamWriter reqStreamWriter = new StreamWriter(reqStream))
                            reqStreamWriter.Write(request.Content);
                }

                Stream responseStream = null;

                responseStream = ((HttpWebResponse)webRequest.GetResponse()).GetResponseStream() as Stream;

                using (var reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    string source = reader.ReadToEnd();

                    var rawResponse = JsonConvert.DeserializeObject<ServerResponse>(source, new JsonSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    });

                    var response = new ServiceResponse<T>()
                    {
                        Code = rawResponse.Code,
                        Message = rawResponse.Message
                    };

                    if (rawResponse.Data != null &&
                        rawResponse.Data["data"] != null &&
                        rawResponse.Data["data"].HasValues &&
                        rawResponse.Data["data"] is JObject)
                    {
                        response.Data = JsonConvert.DeserializeObject<T>(rawResponse.Data["data"].ToString());
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw new SendInBlueException(ResponseTypes.Error, ex.Message, ex);
            }
        }
    }
}