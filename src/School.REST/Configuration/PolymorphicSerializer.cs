using System.Text.Json;
using System.Text.Json.Serialization;

namespace School.REST.Configuration;

public class PolymorphicSerializer<T> : JsonConverter<T> where T : class
{
	// Fallback on default deserialization method
	public override T? Read( ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options ) => 
		JsonSerializer.Deserialize<T>( ref reader, CopyOptionsAndRemove( options ) );

	// Overwrite the write method to convert to the polymorphic type ( if availible )
	public override void Write( Utf8JsonWriter writer, T value, JsonSerializerOptions options ) => 
		writer.WriteRawValue( JsonSerializer.Serialize( (object) value ) );

	// Copy the options set and filter out self to prevent looping
	private JsonSerializerOptions CopyOptionsAndRemove( JsonSerializerOptions options )
	{
        var copy = new JsonSerializerOptions( options );
		
        for ( var i = copy.Converters.Count - 1; i >= 0; i--)
		{
            if ( copy.Converters[ i ] == this )
			{
                copy.Converters.RemoveAt( i );
				break;
			}
		}

        return copy;
	}
}
