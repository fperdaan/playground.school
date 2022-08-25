using School.Models;
using Microsoft.EntityFrameworkCore;

namespace School.DAL;

public partial class SchoolStorageContext : DbContext
{
	public virtual DbSet<Student>? Student { get; set; }

	public SchoolStorageContext( DbContextOptions<SchoolStorageContext> options ) : base( options ) {}

	protected override void OnModelCreating( ModelBuilder modelBuilder )
	{
		modelBuilder.Entity<Student>().HasData( 
			new Student{
				ID = 1,
				FirstName = "Jane",
				SirName = "Doe"
			},
			new Student{
				ID = 2,
				FirstName = "John",
				SirName = "Doe"
			} 
		);
	}
}