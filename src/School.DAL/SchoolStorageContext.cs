using School.Models;
using Microsoft.EntityFrameworkCore;

namespace School.DAL;

public partial class SchoolStorageContext : DbContext
{
	public virtual DbSet<Student>? Student { get; set; }
	public virtual DbSet<Teacher>? Teacher { get; set; }
	public virtual DbSet<Person>? Persons { get; set; }

	public SchoolStorageContext( DbContextOptions<SchoolStorageContext> options ) : base( options ) {}

	protected override void OnModelCreating( ModelBuilder modelBuilder )
	{
		modelBuilder.Entity<Student>().HasData( 			
			new Student {
				ID = 1,
				FirstName = "Larissa",
				LastName = "Farley",
				EnrollmentDate = DateTime.Parse( "2022-08-18 18:39:19" )
			},
			new Student {
				ID = 2,
				FirstName = "Shelley",
				LastName = "Anthony",
				EnrollmentDate = DateTime.Parse( "2022-08-03 05:24:25" )
			},
			new Student {
				ID = 3,
				FirstName = "Eaton",
				LastName = "Clements",
				EnrollmentDate = DateTime.Parse( "2022-11-20 05:32:10" )
			},
			new Student {
				ID = 4,
				FirstName = "Carter",
				LastName = "Giles",
				EnrollmentDate = DateTime.Parse( "2023-03-05 05:00:36" )
			},
			new Student {
				ID = 5,
				FirstName = "Lysandra",
				LastName = "Stokes",
				EnrollmentDate = DateTime.Parse( "2021-04-12 17:56:39" )
			},
			new Student {
				ID = 6,
				FirstName = "Calista",
				LastName = "Spencer",
				EnrollmentDate = DateTime.Parse( "2022-06-08 11:29:39" )
			},
			new Student {
				ID = 7,
				FirstName = "Aurora",
				LastName = "Vargas",
				EnrollmentDate = DateTime.Parse( "2022-11-20 19:29:39" )
			},
			new Student {
				ID = 8,
				FirstName = "Alexander",
				LastName = "Medina",
				EnrollmentDate = DateTime.Parse( "2022-09-03 09:03:35" )
			},
			new Student {
				ID = 9,
				FirstName = "Amy",
				LastName = "Boone",
				EnrollmentDate = DateTime.Parse( "2022-09-08 02:41:38" )
			},
			new Student {
				ID = 10,
				FirstName = "Alyssa",
				LastName = "Baldwin",
				EnrollmentDate = DateTime.Parse( "2021-10-28 20:04:17" )
			},
			new Student {
				ID = 11,
				FirstName = "Indira",
				LastName = "Gibbs",
				EnrollmentDate = DateTime.Parse( "2022-06-11 13:30:01" )
			},
			new Student {
				ID = 12,
				FirstName = "Kai",
				LastName = "Hughes",
				EnrollmentDate = DateTime.Parse( "2022-10-22 14:16:00" )
			},
			new Student {
				ID = 13,
				FirstName = "Fletcher",
				LastName = "Mendez",
				EnrollmentDate = DateTime.Parse( "2022-04-30 15:20:01" )
			},
			new Student {
				ID = 14,
				FirstName = "Winifred",
				LastName = "Vargas",
				EnrollmentDate = DateTime.Parse( "2022-07-22 09:07:29" )
			},
			new Student {
				ID = 15,
				FirstName = "Palmer",
				LastName = "Sawyer",
				EnrollmentDate = DateTime.Parse( "2023-05-12 05:38:32" )
			},
			new Student {
				ID = 16,
				FirstName = "Jillian",
				LastName = "Michael",
				EnrollmentDate = DateTime.Parse( "2021-06-22 22:42:19" )
			},
			new Student {
				ID = 17,
				FirstName = "Orson",
				LastName = "Jordan",
				EnrollmentDate = DateTime.Parse( "2022-10-21 14:36:15" )
			},
			new Student {
				ID = 18,
				FirstName = "Ezra",
				LastName = "Mosley",
				EnrollmentDate = DateTime.Parse( "2023-06-17 02:32:09" )
			},
			new Student {
				ID = 19,
				FirstName = "Cullen",
				LastName = "Mcguire",
				EnrollmentDate = DateTime.Parse( "2023-03-12 12:03:31" )
			},
			new Student {
				ID = 20,
				FirstName = "Giacomo",
				LastName = "Barber",
				EnrollmentDate = DateTime.Parse( "2021-12-10 07:55:21" )
			},
			new Student {
				ID = 21,
				FirstName = "Odette",
				LastName = "Cash",
				EnrollmentDate = DateTime.Parse( "2021-02-25 03:27:08" )
			},
			new Student {
				ID = 22,
				FirstName = "Ezra",
				LastName = "Blanchard",
				EnrollmentDate = DateTime.Parse( "2022-01-16 00:11:51" )
			},
			new Student {
				ID = 23,
				FirstName = "Kirsten",
				LastName = "Howe",
				EnrollmentDate = DateTime.Parse( "2022-03-28 07:53:30" )
			},
			new Student {
				ID = 24,
				FirstName = "Quin",
				LastName = "Rowe",
				EnrollmentDate = DateTime.Parse( "2021-10-13 15:43:18" )
			},
			new Student {
				ID = 25,
				FirstName = "Prescott",
				LastName = "Emerson",
				EnrollmentDate = DateTime.Parse( "2021-07-22 15:42:21" )
			},
			new Student {
				ID = 26,
				FirstName = "Bert",
				LastName = "Brooks",
				EnrollmentDate = DateTime.Parse( "2022-02-20 19:19:14" )
			},
			new Student {
				ID = 27,
				FirstName = "Kirestin",
				LastName = "Vaughan",
				EnrollmentDate = DateTime.Parse( "2021-10-15 10:02:32" )
			},
			new Student {
				ID = 28,
				FirstName = "Isaac",
				LastName = "Marshall",
				EnrollmentDate = DateTime.Parse( "2023-08-15 03:34:32" )
			},
			new Student {
				ID = 29,
				FirstName = "Nomlanga",
				LastName = "Brock",
				EnrollmentDate = DateTime.Parse( "2020-11-05 16:39:57" )
			},
			new Student {
				ID = 30,
				FirstName = "Savannah",
				LastName = "Figueroa",
				EnrollmentDate = DateTime.Parse( "2023-05-18 11:50:34" )
			},
			new Student {
				ID = 31,
				FirstName = "Quinn",
				LastName = "Norton",
				EnrollmentDate = DateTime.Parse( "2022-09-18 21:22:55" )
			},
			new Student {
				ID = 32,
				FirstName = "Troy",
				LastName = "York",
				EnrollmentDate = DateTime.Parse( "2021-05-20 10:52:41" )
			},
			new Student {
				ID = 33,
				FirstName = "Judith",
				LastName = "Black",
				EnrollmentDate = DateTime.Parse( "2021-05-29 02:39:04" )
			},
			new Student {
				ID = 34,
				FirstName = "Reed",
				LastName = "Herman",
				EnrollmentDate = DateTime.Parse( "2020-11-23 03:51:09" )
			},
			new Student {
				ID = 35,
				FirstName = "Giacomo",
				LastName = "Foley",
				EnrollmentDate = DateTime.Parse( "2021-05-26 04:23:58" )
			},
			new Student {
				ID = 36,
				FirstName = "Kirestin",
				LastName = "Hooper",
				EnrollmentDate = DateTime.Parse( "2021-12-13 06:06:25" )
			},
			new Student {
				ID = 37,
				FirstName = "Reagan",
				LastName = "Boyle",
				EnrollmentDate = DateTime.Parse( "2020-12-04 19:17:59" )
			},
			new Student {
				ID = 38,
				FirstName = "Unity",
				LastName = "Morales",
				EnrollmentDate = DateTime.Parse( "2022-03-26 02:22:02" )
			},
			new Student {
				ID = 39,
				FirstName = "Ahmed",
				LastName = "Jacobs",
				EnrollmentDate = DateTime.Parse( "2022-01-07 20:49:06" )
			},
			new Student {
				ID = 40,
				FirstName = "Kamal",
				LastName = "Valenzuela",
				EnrollmentDate = DateTime.Parse( "2021-04-04 15:02:47" )
			},
			new Student {
				ID = 41,
				FirstName = "Barry",
				LastName = "Whitney",
				EnrollmentDate = DateTime.Parse( "2022-04-19 23:37:37" )
			},
			new Student {
				ID = 42,
				FirstName = "Jade",
				LastName = "Gill",
				EnrollmentDate = DateTime.Parse( "2022-11-02 18:37:11" )
			},
			new Student {
				ID = 43,
				FirstName = "Irene",
				LastName = "Huff",
				EnrollmentDate = DateTime.Parse( "2022-08-12 21:30:37" )
			},
			new Student {
				ID = 44,
				FirstName = "Tallulah",
				LastName = "Erickson",
				EnrollmentDate = DateTime.Parse( "2022-05-23 06:25:01" )
			},
			new Student {
				ID = 45,
				FirstName = "Tanner",
				LastName = "Carr",
				EnrollmentDate = DateTime.Parse( "2020-11-21 04:54:57" )
			},
			new Student {
				ID = 46,
				FirstName = "Skyler",
				LastName = "Gonzales",
				EnrollmentDate = DateTime.Parse( "2023-07-24 22:22:53" )
			},
			new Student {
				ID = 47,
				FirstName = "Linus",
				LastName = "Sellers",
				EnrollmentDate = DateTime.Parse( "2020-10-01 18:04:39" )
			},
			new Student {
				ID = 48,
				FirstName = "Hasad",
				LastName = "Perry",
				EnrollmentDate = DateTime.Parse( "2023-02-10 01:25:38" )
			},
			new Student {
				ID = 49,
				FirstName = "Vaughan",
				LastName = "Jackson",
				EnrollmentDate = DateTime.Parse( "2022-09-23 23:36:57" )
			},
			new Student {
				ID = 50,
				FirstName = "Troy",
				LastName = "Monroe",
				EnrollmentDate = DateTime.Parse( "2023-07-09 21:42:23" )
			},
			new Student {
				ID = 51,
				FirstName = "Silas",
				LastName = "Farley",
				EnrollmentDate = DateTime.Parse( "2022-03-01 11:43:02" )
			},
			new Student {
				ID = 52,
				FirstName = "Ashely",
				LastName = "Combs",
				EnrollmentDate = DateTime.Parse( "2021-11-04 22:39:06" )
			},
			new Student {
				ID = 53,
				FirstName = "Rashad",
				LastName = "Yang",
				EnrollmentDate = DateTime.Parse( "2023-07-11 20:38:26" )
			},
			new Student {
				ID = 54,
				FirstName = "Colby",
				LastName = "Stafford",
				EnrollmentDate = DateTime.Parse( "2020-11-05 10:52:46" )
			},
			new Student {
				ID = 55,
				FirstName = "Stella",
				LastName = "Duke",
				EnrollmentDate = DateTime.Parse( "2022-04-27 00:25:31" )
			},
			new Student {
				ID = 56,
				FirstName = "Sybil",
				LastName = "Burgess",
				EnrollmentDate = DateTime.Parse( "2020-10-28 19:52:33" )
			},
			new Student {
				ID = 57,
				FirstName = "Ivy",
				LastName = "Pierce",
				EnrollmentDate = DateTime.Parse( "2022-12-14 17:33:21" )
			},
			new Student {
				ID = 58,
				FirstName = "Troy",
				LastName = "Myers",
				EnrollmentDate = DateTime.Parse( "2021-09-21 01:33:44" )
			},
			new Student {
				ID = 59,
				FirstName = "Eaton",
				LastName = "Pratt",
				EnrollmentDate = DateTime.Parse( "2023-03-14 12:29:40" )
			},
			new Student {
				ID = 60,
				FirstName = "Ebony",
				LastName = "Summers",
				EnrollmentDate = DateTime.Parse( "2021-09-23 03:39:25" )
			},
			new Student {
				ID = 61,
				FirstName = "Carter",
				LastName = "Deleon",
				EnrollmentDate = DateTime.Parse( "2022-10-23 12:12:21" )
			},
			new Student {
				ID = 62,
				FirstName = "Tobias",
				LastName = "Maldonado",
				EnrollmentDate = DateTime.Parse( "2023-01-21 13:51:03" )
			},
			new Student {
				ID = 63,
				FirstName = "Nasim",
				LastName = "Melendez",
				EnrollmentDate = DateTime.Parse( "2023-03-04 06:31:08" )
			},
			new Student {
				ID = 64,
				FirstName = "Vladimir",
				LastName = "Barron",
				EnrollmentDate = DateTime.Parse( "2021-05-14 09:41:24" )
			},
			new Student {
				ID = 65,
				FirstName = "Ursula",
				LastName = "Mckinney",
				EnrollmentDate = DateTime.Parse( "2021-05-12 22:14:13" )
			},
			new Student {
				ID = 66,
				FirstName = "Hoyt",
				LastName = "Holcomb",
				EnrollmentDate = DateTime.Parse( "2022-08-03 10:03:51" )
			},
			new Student {
				ID = 67,
				FirstName = "Reese",
				LastName = "Gallegos",
				EnrollmentDate = DateTime.Parse( "2021-07-09 15:15:50" )
			},
			new Student {
				ID = 68,
				FirstName = "Alisa",
				LastName = "Durham",
				EnrollmentDate = DateTime.Parse( "2022-02-13 07:51:51" )
			},
			new Student {
				ID = 69,
				FirstName = "Tyler",
				LastName = "Kennedy",
				EnrollmentDate = DateTime.Parse( "2020-10-01 12:08:53" )
			},
			new Student {
				ID = 70,
				FirstName = "Kelsie",
				LastName = "Bartlett",
				EnrollmentDate = DateTime.Parse( "2022-01-29 01:58:49" )
			},
			new Student {
				ID = 71,
				FirstName = "Ryder",
				LastName = "Rowland",
				EnrollmentDate = DateTime.Parse( "2020-12-08 08:32:16" )
			},
			new Student {
				ID = 72,
				FirstName = "Bradley",
				LastName = "Tran",
				EnrollmentDate = DateTime.Parse( "2022-04-19 18:00:48" )
			},
			new Student {
				ID = 73,
				FirstName = "Kiona",
				LastName = "Cohen",
				EnrollmentDate = DateTime.Parse( "2022-06-10 13:14:20" )
			},
			new Student {
				ID = 74,
				FirstName = "Rogan",
				LastName = "Sparks",
				EnrollmentDate = DateTime.Parse( "2022-01-22 12:52:59" )
			},
			new Student {
				ID = 75,
				FirstName = "Brody",
				LastName = "Hampton",
				EnrollmentDate = DateTime.Parse( "2021-02-11 22:43:06" )
			},
			new Student {
				ID = 76,
				FirstName = "Cadman",
				LastName = "Hurley",
				EnrollmentDate = DateTime.Parse( "2022-02-20 20:50:44" )
			},
			new Student {
				ID = 77,
				FirstName = "Keely",
				LastName = "Cooley",
				EnrollmentDate = DateTime.Parse( "2021-09-27 16:56:11" )
			},
			new Student {
				ID = 78,
				FirstName = "Burke",
				LastName = "Coleman",
				EnrollmentDate = DateTime.Parse( "2021-10-17 07:02:31" )
			},
			new Student {
				ID = 79,
				FirstName = "Latifah",
				LastName = "Blankenship",
				EnrollmentDate = DateTime.Parse( "2023-07-06 17:22:22" )
			},
			new Student {
				ID = 80,
				FirstName = "Raymond",
				LastName = "Lawson",
				EnrollmentDate = DateTime.Parse( "2021-03-30 05:20:28" )
			},
			new Student {
				ID = 81,
				FirstName = "Veronica",
				LastName = "Little",
				EnrollmentDate = DateTime.Parse( "2023-07-29 05:34:55" )
			},
			new Student {
				ID = 82,
				FirstName = "Carter",
				LastName = "Romero",
				EnrollmentDate = DateTime.Parse( "2022-10-20 06:37:32" )
			},
			new Student {
				ID = 83,
				FirstName = "Chava",
				LastName = "Fletcher",
				EnrollmentDate = DateTime.Parse( "2022-05-22 18:43:34" )
			},
			new Student {
				ID = 84,
				FirstName = "Clayton",
				LastName = "Alexander",
				EnrollmentDate = DateTime.Parse( "2022-04-25 12:28:03" )
			},
			new Student {
				ID = 85,
				FirstName = "Azalia",
				LastName = "Hall",
				EnrollmentDate = DateTime.Parse( "2021-11-14 04:48:49" )
			},
			new Student {
				ID = 86,
				FirstName = "Isaiah",
				LastName = "Mclean",
				EnrollmentDate = DateTime.Parse( "2023-02-19 08:13:50" )
			},
			new Student {
				ID = 87,
				FirstName = "Keegan",
				LastName = "Sawyer",
				EnrollmentDate = DateTime.Parse( "2022-08-04 21:09:02" )
			},
			new Student {
				ID = 88,
				FirstName = "Gregory",
				LastName = "Thornton",
				EnrollmentDate = DateTime.Parse( "2021-01-27 05:08:58" )
			},
			new Student {
				ID = 89,
				FirstName = "Hedda",
				LastName = "Keith",
				EnrollmentDate = DateTime.Parse( "2021-09-04 10:37:02" )
			},
			new Student {
				ID = 90,
				FirstName = "Lillith",
				LastName = "Robertson",
				EnrollmentDate = DateTime.Parse( "2021-03-11 16:37:34" )
			},
			new Student {
				ID = 91,
				FirstName = "Germaine",
				LastName = "Bradshaw",
				EnrollmentDate = DateTime.Parse( "2022-03-28 12:44:42" )
			},
			new Student {
				ID = 92,
				FirstName = "MacKenzie",
				LastName = "Peters",
				EnrollmentDate = DateTime.Parse( "2022-07-23 04:42:11" )
			},
			new Student {
				ID = 93,
				FirstName = "Fulton",
				LastName = "Schmidt",
				EnrollmentDate = DateTime.Parse( "2021-08-06 22:23:33" )
			},
			new Student {
				ID = 94,
				FirstName = "Ruby",
				LastName = "Hensley",
				EnrollmentDate = DateTime.Parse( "2022-07-07 05:07:52" )
			},
			new Student {
				ID = 95,
				FirstName = "Scarlett",
				LastName = "Spears",
				EnrollmentDate = DateTime.Parse( "2021-07-05 16:52:16" )
			},
			new Student {
				ID = 96,
				FirstName = "Malik",
				LastName = "Randall",
				EnrollmentDate = DateTime.Parse( "2023-02-08 04:14:21" )
			},
			new Student {
				ID = 97,
				FirstName = "Dolan",
				LastName = "Harper",
				EnrollmentDate = DateTime.Parse( "2023-05-17 22:05:39" )
			},
			new Student {
				ID = 98,
				FirstName = "Dennis",
				LastName = "Rivers",
				EnrollmentDate = DateTime.Parse( "2023-06-04 00:55:27" )
			},
			new Student {
				ID = 99,
				FirstName = "Althea",
				LastName = "Mckay",
				EnrollmentDate = DateTime.Parse( "2021-08-01 16:38:37" )
			},
			new Student {
				ID = 100,
				FirstName = "Kelly",
				LastName = "Langley",
				EnrollmentDate = DateTime.Parse( "2021-04-19 15:27:40" )
			}
		);

		modelBuilder.Entity<Teacher>().HasData( 
			new Teacher {
				ID = 101,
				FirstName = "Christine",
				LastName = "Contreras",
				Topics = Topic.Language
			},
			new Teacher {
				ID = 102,
				FirstName = "Brynn",
				LastName = "Norman",
				Topics = Topic.Math | Topic.Science | Topic.Language
			},
			new Teacher {
				ID = 103,
				FirstName = "Dai",
				LastName = "Montoya",
				Topics = Topic.Math | Topic.Language
			},
			new Teacher {
				ID = 104,
				FirstName = "Colin",
				LastName = "Dickson",
				Topics = Topic.History | Topic.Math | Topic.Language
			},
			new Teacher {
				ID = 105,
				FirstName = "Barclay",
				LastName = "Beasley",
				Topics = Topic.Language
			},
			new Teacher {
				ID = 106,
				FirstName = "Uma",
				LastName = "Rich",
				Topics = Topic.Language | Topic.Science
			},
			new Teacher {
				ID = 107,
				FirstName = "Gillian",
				LastName = "Hogan",
				Topics = Topic.History | Topic.Science | Topic.Math
			},
			new Teacher {
				ID = 108,
				FirstName = "Xyla",
				LastName = "Haynes",
				Topics = Topic.History | Topic.Language
			},
			new Teacher {
				ID = 109,
				FirstName = "Jeremy",
				LastName = "Gill",
				Topics = Topic.History | Topic.Science
			},
			new Teacher {
				ID = 110,
				FirstName = "Fleur",
				LastName = "Leblanc",
				Topics = Topic.Language | Topic.Science | Topic.Math
			}
		);
	}
}