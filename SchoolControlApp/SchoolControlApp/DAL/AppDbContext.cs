using Microsoft.EntityFrameworkCore;
using SchoolFaceControllApp.Models.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFaceControllApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TuitionFee> TuitionFees { get; set; }
        public DbSet<EducationPeriod> EducationPeriods { get; set; }
        public DbSet<Continuity> Continuities { get; set; }
        public DbSet<Corpus> Corpuses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<EducationalBase> EducationalBases { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Limitation> Limitations { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<TuitionFee>().ToTable("TuitionFees");
            modelBuilder.Entity<EducationPeriod>().ToTable("EducationPeriods");
            modelBuilder.Entity<Continuity>().ToTable("Continuities");
            modelBuilder.Entity<Corpus>().ToTable("Corpuses");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Duty>().ToTable("Duties");
            modelBuilder.Entity<EducationalBase>().ToTable("EducationalBases");
            modelBuilder.Entity<Group>().ToTable("Groups");
            modelBuilder.Entity<Limitation>().ToTable("Limitations");
            modelBuilder.Entity<Specialty>().ToTable("Specialties");
            modelBuilder.Entity<Temperature>().ToTable("Temperatures");

            modelBuilder.Entity<Student>()
                .HasOne(u => u.TuitionFee)
                    .WithMany(x => x.Students)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Student>()
                .HasOne(u => u.EducationPeriod)
                    .WithMany(x => x.Students)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Student>()
                .HasOne(u => u.Corpus)
                    .WithMany(x => x.Students)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Employee>()
                .HasOne(u => u.Corpus)
                    .WithMany(x => x.Employees)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Student>()
                .HasOne(u => u.Course)
                    .WithMany(x => x.Students)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Student>()
                .HasOne(u => u.Group)
                    .WithMany(x => x.Students)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Student>()
                .HasOne(u => u.EducationalBase)
                    .WithMany(x => x.Students)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Employee>()
               .HasOne(u => u.Duty)
                   .WithMany(x => x.Employees)
                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Group>()
               .HasOne(u => u.Specialty)
                   .WithMany(x => x.Groups)
                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Continuity>()
                .Property(x => x.MissingReason)
                    .HasConversion(x => x.ToString(),
                    x => (MissingReason)Enum.Parse(typeof(MissingReason), x));

            modelBuilder.Entity<Continuity>()
                .HasOne(x => x.Employee)
                    .WithMany(x => x.Continuities)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Continuity>()
                .HasOne(x => x.Student)
                    .WithMany(x => x.Continuities)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Temperature>()
               .HasOne(x => x.Employee)
                   .WithMany(x => x.Temperatures)
                       .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Temperature>()
                .HasOne(x => x.Student)
                    .WithMany(x => x.Temperatures)
                        .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }
    }
}

