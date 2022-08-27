using System.Text.Json;
using System.Text.Json.Serialization;
using School.Models;

namespace School.REST.Configuration;

public class PersonSerializer : JsonConverter<Person>
{
	// Should not be possible right?
	public override Person? Read( ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options )
	{
		throw new NotImplementedException();
	}

	public override void Write( Utf8JsonWriter writer, Person value, JsonSerializerOptions options )
	{
		writer.WriteRawValue( JsonSerializer.Serialize( (object) value ) );
	}
}
