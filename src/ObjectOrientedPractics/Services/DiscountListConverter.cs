using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Кастомный конвертер для List<IDiscount>
    /// </summary>
    public class DiscountListConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<IDiscount>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var result = new List<IDiscount>();

            JArray array = JArray.Load(reader);
            foreach (JObject item in array)
            {
                var typeName = item["$type"]?.ToString();
                if (typeName.Contains("PointsDiscount"))
                {
                    var pointsDiscount = item.ToObject<PointsDiscount>(serializer);
                    result.Add(pointsDiscount);
                }
                else if (typeName.Contains("PercentDiscount"))
                {
                    var percentDiscount = item.ToObject<PercentDiscount>(serializer);
                    result.Add(percentDiscount);
                }
            }

            // Гарантируем наличие PointsDiscount
            if (!result.Any(d => d is PointsDiscount))
            {
                result.Add(new PointsDiscount());
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var list = (List<IDiscount>)value;
            writer.WriteStartArray();
            foreach (var discount in list)
            {
                JObject.FromObject(discount, serializer).WriteTo(writer);
            }
            writer.WriteEndArray();
        }
    }
}
