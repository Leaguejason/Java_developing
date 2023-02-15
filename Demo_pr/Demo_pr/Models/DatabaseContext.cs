using Microsoft.EntityFrameworkCore;

namespace Demo_pr.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1,
                Name = "John Curve",
                DateOfBirth = new DateTime(1981, 10, 20),
                Email = "john_curve@gmail.com",
                Address = "Britain"


            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 2,
                Name = "Chirstopher Jr",
                DateOfBirth = new DateTime(1960, 12, 20),
                Email = "chris@gmail.com",
                Address = "Los Angeles"


            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 3,
                Name = "Magic Land",
                DateOfBirth = new DateTime(2001, 02, 28),
                Email = "magic_land@gmail.com",
                Address = "London"


            });
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 1,
                    SubjectName = "Humanitarian",
                    SubjectCode = "H111",
                    Description = "It is not about emotion, it is also about thought and innovation",
                    StartDate = new DateTime(2022, 3, 28),
                    EndDate = new DateTime(2023, 1, 28)
                }
                );
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 2,
                    SubjectName = "History",
                    SubjectCode = "H034",
                    Description = "Nothing is important like how the past is formed",
                    StartDate = new DateTime(2022, 3, 28),
                    EndDate = new DateTime(2023, 1, 28)
                }
                );
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 3,
                    SubjectName = "Blockchain",
                    SubjectCode = "B07",
                    Description = "The future or just a contemporary trend",
                    StartDate = new DateTime(2022, 3, 28),
                    EndDate = new DateTime(2023, 1, 28)
                }
                );
            modelBuilder.Entity<Exam>().HasData(
                new Exam
                {
                    ExamId = 1,
                    Score = 9,
                    StudentId = 1,
                    SubjectId = 1
                });
            modelBuilder.Entity<Exam>().HasData(
               new Exam
               {
                   ExamId = 2,
                   Score = 8,
                   StudentId = 2,
                   SubjectId = 2
               });
            modelBuilder.Entity<Exam>().HasData(
               new Exam
               {
                   ExamId = 3,
                   Score = 10,
                   StudentId = 3,
                   SubjectId = 3
               });
        }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
