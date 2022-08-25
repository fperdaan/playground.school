namespace School.Models;

public class Course : StorableEntity, ICourse
{
	public string Title { get; set; } = "";

	private Topic _topic;
	public Topic Topic { 
		get => _topic; 
		set {
			if( !Enum.IsDefined( typeof( Topic ), value ) )
			{	
				throw new ArgumentOutOfRangeException(
					paramName: "Topic",
					message: "A course is focused around one singular topic"
				);
			}

			_topic = value;
		}
	}
}