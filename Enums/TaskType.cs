using System.Text.Json.Serialization;
namespace AttemptChores2.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TaskType{

  House,
  Pets,
  Laundry,
  Food
}

