using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    /// <summary>
    /// Because SendInBlue store boolean with integer...
    /// </summary>
    public class BooleanConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            bool? boolVal = value as bool?;

            if (boolVal.HasValue)
            {
                if (boolVal.Value)
                    writer.WriteRawValue("1");
                else
                    writer.WriteRawValue("0");
            }
            else
                writer.WriteRawValue("null");
            
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) return null;

            if (reader.TokenType == JsonToken.Integer)
            {
                if (reader.Value is Int64)
                    return (Int64)reader.Value == 1;
                
                if (reader.Value is Int32)
                    return (Int32)reader.Value == 1;

                if (reader.Value is Int16)
                    return (Int16)reader.Value == 1;
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
