using School.Models;

// See https://aka.ms/new-console-template for more information

var building1 = new Building{ Name= "Building 1" };
var building2 = new Building{ Name= "Building 2" };

IList<IClassroom> rooms = new List<IClassroom>();

rooms.Add( new Classroom( name: "Room 101", location: building1, roomSize: 12 ) ); 
rooms.Add( new Classroom( name: "Room 102", location: building1, roomSize: 12, topics: Topic.History ) ); 
rooms.Add( new Classroom( name: "Room 103", location: building1, roomSize: 12, topics: Topic.Language ) ); 
rooms.Add( new Classroom( name: "Room 201", location: building1, roomSize: 12, topics: Topic.Math | Topic.History ) ); 
rooms.Add( new Classroom( name: "Room 202", location: building1, roomSize: 12, topics: Topic.Math | Topic.History ) ); 

rooms.Add( new Classroom( name: "Room A", location: building2, roomSize: 12, topics: Topic.Science ) ); 
rooms.Add( new Classroom( name: "Room B", location: building2, roomSize: 12 ) ); 


foreach( IClassroom room in rooms )
{
	Console.WriteLine( room );
}

// var teacher = new Teacher();

// // Add values
// teacher.Topics  = Topic.Math | Topic.History | Topic.Science;

// // Remove value
// teacher.Topics &= ~Topic.Math;

var course = new Course();

course.Topic = Topic.History;


Console.WriteLine( course );
