using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonefyStats.ChartJs.JsonConverters
{
    public class JsonDeserializationPropertyColorRgbaConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is ColorRgba colorRgba))
            {
                writer.WriteValue("");
            }
            else
            {
                writer.WriteValue($"rgba({colorRgba.Red},{colorRgba.Green},{colorRgba.Blue},{colorRgba.Alpha})");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass;
        }
        public override bool CanRead => false;
        public override bool CanWrite => true;

    }
}
