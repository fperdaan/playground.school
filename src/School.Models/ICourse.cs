namespace School.Models;

public interface ICourse : IStorable
{
	public string Title { get; }
	public Topic Topic { get; }
}