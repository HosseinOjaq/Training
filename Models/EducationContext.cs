using Hossein.Entities;
using Hossein.Configuraions;
using Hossein.Entities.Exam;
using Microsoft.EntityFrameworkCore;

namespace Hossein.Models;

public class EducationContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\V19;Database=Training;User Id=sa;Password=1;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AllConfig).Assembly);
    }

    public DbSet<CalendarCostType> CalendarCostTypes { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Duty> Duties { get; set; }
    public DbSet<EvaluationQuestion> EvaluationQuestions { get; set; }
    public DbSet<PostTrainingStandard> JobPositionTrainingStandards { get; set; }
    public DbSet<PostTrainingStandardAttachment> JobPositionTrainingStandardAttachments { get; set; }
    public DbSet<Personel> Personels { get; set; }
    public DbSet<PersonelTrainingCalendar> PersonelTrainingCalendars { get; set; }
    public DbSet<PersonelTrainingCalendarCost> PersonelTrainingCalendarCosts { get; set; }
    public DbSet<PersonelTrainingCalendarMeeting> PersonelTrainingCalendarMeetings { get; set; }
    public DbSet<PersonelTrainingCalendarMeetingAttachment> PersonelTrainingCalendarMeetingAttachments { get; set; }
    public DbSet<PersonelTrainingCalendarMeetingAttendance> PersonelTrainingCalendarMeetingAttendances { get; set; }
    public DbSet<PersonelTrainingCalendarMeetingScore> PersonelTrainingCalendarMeetingScores { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostDuty> PostDuties { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TrainingCalendar> TrainingCalendars { get; set; }
    public DbSet<TrainingCalendarAttachment> TrainingCalendarAttachments { get; set; }
    public DbSet<TrainingCalendarEvaluationQuestion> TrainingCalendarEvaluationQuestions { get; set; }
    public DbSet<TrainingCalendarEvaluationQuestionAnswer> TrainingCalendarEvaluationQuestionAnswers { get; set; }
    public DbSet<TrainingCalendarPrerequisite> TrainingCalendarPrerequisites { get; set; }
    public DbSet<TrainingCalendarStandard> TrainingCalendarStandards { get; set; }
    public DbSet<TrainingCalendarTeacher> TrainingCalendarTeachers { get; set; }
    public DbSet<TrainingStandard> TrainingStandards { get; set; }
    public DbSet<TrainingStandardAttachment> TrainingStandardAttachments { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionOption> QuestionOptions { get; set; }
    public DbSet<TrainingCalendarQuestion> TrainingCalendarQuestions { get; set; }
    public DbSet<TrainingCalendarQuestionAnswer> TrainingCalendarQuestionAnswers { get; set; }
}