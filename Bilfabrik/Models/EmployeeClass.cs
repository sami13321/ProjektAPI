using System.Text.Json.Serialization;

namespace Bilfabrik.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmployeeClass
    {
        Produktionsledare,

        Montör,

        Lagledare,

        Truckförare
    }
}
