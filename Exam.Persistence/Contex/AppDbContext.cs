using Exam.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam.Persistence.Contex;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
   


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Answer and StudentResult relations one to one
        modelBuilder.Entity<Answer>()
            .HasOne(a => a.StudentResut)
            .WithOne(sr => sr.Answer)
            .HasForeignKey<StudentResult>(sr => sr.AnswerId)
            .OnDelete(DeleteBehavior.Restrict);

        //Question and StudentResult relations one to one
        modelBuilder.Entity<Question>()
            .HasOne(q => q.StudentResut)
            .WithOne(sr => sr.Question)
            .HasForeignKey<StudentResult>(sr => sr.QuestionId)
            .OnDelete(DeleteBehavior.Restrict);

        // StudentExam and StudentResult relations one to one
        modelBuilder.Entity<StudentExam>()
            .HasOne(se => se.StudentResut)
            .WithOne(sr => sr.StudentExam)
            .HasForeignKey<StudentResult>(sr => sr.StudentExamId)
            .OnDelete(DeleteBehavior.Restrict);

        //Exam and Question relations one to many
        modelBuilder.Entity<Domain.Entities.Exam>()
             .HasMany(e => e.Questions)
             .WithOne(q => q.Exam)
             .HasForeignKey(q => q.ExamId)
             .OnDelete(DeleteBehavior.Restrict);

        //Question and Answer relations one to many
        modelBuilder.Entity<Question>()
             .HasMany(q => q.Answers)
             .WithOne(a => a.Question)
             .HasForeignKey(a => a.QuestionId)
             .OnDelete(DeleteBehavior.Restrict);

        //User and StudentExam relations many to Any
       
        modelBuilder.Entity<StudentExam>()
             .HasOne(se => se.User)
             .WithMany(u => u.StudentExams)
             .HasForeignKey(se => se.UserId)
             .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<StudentExam>()
            .HasOne(se => se.Exam)
            .WithMany(e => e.StudentExams)
            .HasForeignKey(se => se.ExamId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Answer> Answers { get; set; }
    public DbSet<Domain.Entities.Exam> Exams { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<StudentExam> StudentExams { get; set; }
    public DbSet<StudentResult> StudentResutls { get; set; }

}
