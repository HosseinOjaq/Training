using Hossein.Entities;
using Hossein.Entities.Exam;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hossein.Configuraions;

public class AllConfig
{
    #region ===== Base / Simple =====

    public class CalendarCostTypeConfig : IEntityTypeConfiguration<CalendarCostType>
    {
        public void Configure(EntityTypeBuilder<CalendarCostType> b)
        {
            b.ToTable("CalendarCostTypes");
            b.HasKey(x => x.Id);
            b.Property(x => x.Title).IsRequired().HasMaxLength(150);
            b.Property(x => x.IsActive).IsRequired();
        }
    }

    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> b)
        {
            b.ToTable("Courses");
            b.HasKey(x => x.Id);
            b.Property(x => x.Title).IsRequired().HasMaxLength(200);
        }
    }

    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> b)
        {
            b.ToTable("Departments");
            b.HasKey(x => x.Id);
            b.Property(x => x.Name).IsRequired().HasMaxLength(150);
        }
    }

    public class DutyConfig : IEntityTypeConfiguration<Duty>
    {
        public void Configure(EntityTypeBuilder<Duty> b)
        {
            b.ToTable("Duties");
            b.HasKey(x => x.Id);
            b.Property(x => x.Name).IsRequired().HasMaxLength(150);
            b.Property(x => x.IsActive).IsRequired();
        }
    }

    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> b)
        {
            b.ToTable("Posts");
            b.HasKey(x => x.Id);
            b.Property(x => x.Name).IsRequired().HasMaxLength(150);
            b.Property(x => x.IsActive).IsRequired();
        }
    }

    public class PostDutyConfig : IEntityTypeConfiguration<PostDuty>
    {
        public void Configure(EntityTypeBuilder<PostDuty> b)
        {
            b.ToTable("PostDuties");
            b.HasKey(x => x.Id);

            b.HasIndex(x => new { x.PostId, x.DutyId }).IsUnique();

            b.HasOne<Post>().WithMany().HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Duty>().WithMany().HasForeignKey(x => x.DutyId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

    #region ===== Personel =====

    public class PersonelConfig : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> b)
        {
            b.ToTable("Personels");
            b.HasKey(x => x.Id);
            b.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            b.Property(x => x.LastName).IsRequired().HasMaxLength(100);

            b.HasOne<Department>()
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

    #region ===== Job / Standard =====

    public class TrainingStandardConfig : IEntityTypeConfiguration<TrainingStandard>
    {
        public void Configure(EntityTypeBuilder<TrainingStandard> b)
        {
            b.ToTable("TrainingStandards");
            b.HasKey(x => x.Id);
            b.Property(x => x.Title).IsRequired().HasMaxLength(200);
            b.Property(x => x.Description).HasMaxLength(1000);
            b.Property(x => x.IsActive).IsRequired();
        }
    }

    public class TrainingStandardAttachmentConfig : IEntityTypeConfiguration<TrainingStandardAttachment>
    {
        public void Configure(EntityTypeBuilder<TrainingStandardAttachment> b)
        {
            b.ToTable("TrainingStandardAttachments");
            b.HasKey(x => x.Id);

            b.Property(x => x.Title).IsRequired().HasMaxLength(200);
            b.Property(x => x.FileName).IsRequired().HasMaxLength(300);
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<TrainingStandard>().WithMany().HasForeignKey(x => x.TrainingStandardId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class PostTrainingStandardConfig : IEntityTypeConfiguration<PostTrainingStandard>
    {
        public void Configure(EntityTypeBuilder<PostTrainingStandard> b)
        {
            b.ToTable("PostTrainingStandards");
            b.HasKey(x => x.Id);
            b.Property(x => x.IsMandatory).IsRequired();

            b.HasIndex(x => new { x.PostId, x.TrainingStandardId }).IsUnique();
            
            b.HasOne<TrainingStandard>().WithMany().HasForeignKey(x => x.TrainingStandardId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Post>().WithMany().HasForeignKey(x => x.PostId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class PostTrainingStandardAttachmentConfig : IEntityTypeConfiguration<PostTrainingStandardAttachment>
    {
        public void Configure(EntityTypeBuilder<PostTrainingStandardAttachment> b)
        {
            b.ToTable("PostTrainingStandardAttachments");
            b.HasKey(x => x.Id);

            b.Property(x => x.Title).IsRequired().HasMaxLength(200);
            b.Property(x => x.FileName).IsRequired().HasMaxLength(300);
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<PostTrainingStandard>().WithMany().HasForeignKey(x => x.PostTrainingStandardId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

    #region ===== Training Calendar =====

    public class TrainingCalendarConfig : IEntityTypeConfiguration<TrainingCalendar>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendar> b)
        {
            b.ToTable("TrainingCalendars");
            b.HasKey(x => x.Id);

            b.Property(x => x.Name).IsRequired().HasMaxLength(200);
            b.Property(x => x.StartAt).IsRequired();
            b.Property(x => x.EndAt).IsRequired();
            b.Property(x => x.Duration).IsRequired();
            b.Property(x => x.TotalCapacity).IsRequired();

            b.HasOne<Department>().WithMany().HasForeignKey(x => x.DepartmentId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Course>().WithMany().HasForeignKey(x => x.CourseId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarAttachmentConfig : IEntityTypeConfiguration<TrainingCalendarAttachment>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarAttachment> b)
        {
            b.ToTable("TrainingCalendarAttachments");
            b.HasKey(x => x.Id);

            b.Property(x => x.Title).IsRequired().HasMaxLength(200);
            b.Property(x => x.FileName).IsRequired().HasMaxLength(300);
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<TrainingCalendar>().WithMany().HasForeignKey(x => x.TrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarTeacherConfig : IEntityTypeConfiguration<TrainingCalendarTeacher>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarTeacher> b)
        {
            b.ToTable("TrainingCalendarTeachers");
            b.HasKey(x => x.Id);

            b.HasIndex(x => new { x.TrainingCalendarId, x.TeacherId }).IsUnique();

            b.HasOne<TrainingCalendar>().WithMany().HasForeignKey(x => x.TrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Teacher>().WithMany().HasForeignKey(x => x.TeacherId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarStandardConfig : IEntityTypeConfiguration<TrainingCalendarStandard>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarStandard> b)
        {
            b.ToTable("TrainingCalendarStandards");
            b.HasKey(x => x.Id);

            b.HasIndex(x => new { x.TrainingCalendarId, x.TrainingStandardId }).IsUnique();

            b.HasOne<TrainingCalendar>().WithMany().HasForeignKey(x => x.TrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<TrainingStandard>().WithMany().HasForeignKey(x => x.TrainingStandardId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarPrerequisiteConfig : IEntityTypeConfiguration<TrainingCalendarPrerequisite>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarPrerequisite> b)
        {
            b.ToTable("TrainingCalendarPrerequisites");
            b.HasKey(x => x.Id);

            b.Property(x => x.Type).IsRequired();

            b.HasOne<TrainingCalendar>().WithMany().HasForeignKey(x => x.TrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<TrainingStandard>().WithMany().HasForeignKey(x => x.TrainingStandardId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarEvaluationQuestionConfig : IEntityTypeConfiguration<TrainingCalendarEvaluationQuestion>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarEvaluationQuestion> b)
        {
            b.ToTable("TrainingCalendarEvaluationQuestions");
            b.HasKey(x => x.Id);

            b.Property(x => x.Priority).IsRequired();
            b.Property(x => x.Rate).IsRequired();

            b.HasOne<EvaluationQuestion>().WithMany().HasForeignKey(x => x.EvaluationQuestionId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<TrainingCalendar>().WithMany().HasForeignKey(x => x.TrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarEvaluationQuestionAnswerConfig : IEntityTypeConfiguration<TrainingCalendarEvaluationQuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarEvaluationQuestionAnswer> b)
        {
            b.ToTable("TrainingCalendarEvaluationQuestionAnswers");
            b.HasKey(x => x.Id);

            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<TrainingCalendarEvaluationQuestion>().WithMany().HasForeignKey(x => x.TrainingCalendarEvaluationQuestionId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

    #region ===== Personel Training Calendar =====

    public class PersonelTrainingCalendarConfig : IEntityTypeConfiguration<PersonelTrainingCalendar>
    {
        public void Configure(EntityTypeBuilder<PersonelTrainingCalendar> b)
        {
            b.ToTable("PersonelTrainingCalendars");
            b.HasKey(x => x.Id);

            b.HasIndex(x => new { x.PersonelId, x.TrainingCalendarId }).IsUnique();

            b.HasOne<Personel>().WithMany()
                .HasForeignKey(x => x.PersonelId)
                 .OnDelete(DeleteBehavior.Restrict);

            b.HasOne<TrainingCalendar>()
                .WithMany()
                .HasForeignKey(x => x.TrainingCalendarId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class PersonelTrainingCalendarCostConfig : IEntityTypeConfiguration<PersonelTrainingCalendarCost>
    {
        public void Configure(EntityTypeBuilder<PersonelTrainingCalendarCost> b)
        {
            b.ToTable("PersonelTrainingCalendarCosts");
            b.HasKey(x => x.Id);

            b.Property(x => x.Amount).IsRequired();
            b.Property(x => x.CreationDate).IsRequired();
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<PersonelTrainingCalendar>().WithMany().HasForeignKey(x => x.PersonelTrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<CalendarCostType>().WithMany().HasForeignKey(x => x.CalendarCostTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class PersonelTrainingCalendarMeetingConfig : IEntityTypeConfiguration<PersonelTrainingCalendarMeeting>
    {
        public void Configure(EntityTypeBuilder<PersonelTrainingCalendarMeeting> b)
        {
            b.ToTable("PersonelTrainingCalendarMeetings");
            b.HasKey(x => x.Id);

            b.Property(x => x.ScheduledStartAt).IsRequired();
            b.Property(x => x.ScheduledEndAt).IsRequired();
            b.Property(x => x.Capacity).IsRequired();
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<PersonelTrainingCalendar>().WithMany().HasForeignKey(x => x.PersonelTrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Teacher>().WithMany().HasForeignKey(x => x.TeacherId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class PersonelTrainingCalendarMeetingAttachmentConfig : IEntityTypeConfiguration<PersonelTrainingCalendarMeetingAttachment>
    {
        public void Configure(EntityTypeBuilder<PersonelTrainingCalendarMeetingAttachment> b)
        {
            b.ToTable("PersonelTrainingCalendarMeetingAttachments");
            b.HasKey(x => x.Id);

            b.Property(x => x.Title).IsRequired().HasMaxLength(200);
            b.Property(x => x.FileName).IsRequired().HasMaxLength(300);
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<PersonelTrainingCalendarMeeting>().WithMany().HasForeignKey(x => x.PersonelTrainingCalendarMeetingId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class PersonelTrainingCalendarMeetingAttendanceConfig : IEntityTypeConfiguration<PersonelTrainingCalendarMeetingAttendance>
    {
        public void Configure(EntityTypeBuilder<PersonelTrainingCalendarMeetingAttendance> b)
        {
            b.ToTable("PersonelTrainingCalendarMeetingAttendances");
            b.HasKey(x => x.Id);

            b.Property(x => x.Status).IsRequired();
            b.Property(x => x.LateMinutes).IsRequired();

            b.HasOne<PersonelTrainingCalendarMeeting>().WithMany().HasForeignKey(x => x.PersonelTrainingCalendarMeetingId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Personel>().WithMany().HasForeignKey(x => x.PersonelId).OnDelete(DeleteBehavior.Restrict); ;
        }
    }

    public class PersonelTrainingCalendarMeetingScoreConfig : IEntityTypeConfiguration<PersonelTrainingCalendarMeetingScore>
    {
        public void Configure(EntityTypeBuilder<PersonelTrainingCalendarMeetingScore> b)
        {
            b.ToTable("PersonelTrainingCalendarMeetingScores");
            b.HasKey(x => x.Id);

            b.Property(x => x.Score).IsRequired();
            b.Property(x => x.Description).HasMaxLength(1000);

            b.HasOne<PersonelTrainingCalendar>().WithMany().HasForeignKey(x => x.PersonelTrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    #endregion

    #region ===== Exam =====

    public class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> b)
        {
            b.ToTable("Questions");
            b.HasKey(x => x.Id);
            b.Property(x => x.Title).IsRequired().HasMaxLength(300);
            b.Property(x => x.IsActive).IsRequired();
            b.Property(x => x.Type).IsRequired();
        }
    }

    public class QuestionOptionConfig : IEntityTypeConfiguration<QuestionOption>
    {
        public void Configure(EntityTypeBuilder<QuestionOption> b)
        {
            b.ToTable("QuestionOptions");
            b.HasKey(x => x.Id);

            b.Property(x => x.Text).IsRequired().HasMaxLength(500);
            b.Property(x => x.IsActive).IsRequired();
            b.Property(x => x.IsCorrect).IsRequired();

            b.HasOne<Question>().WithMany().HasForeignKey(x => x.QuestionId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarQuestionConfig : IEntityTypeConfiguration<TrainingCalendarQuestion>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarQuestion> b)
        {
            b.ToTable("TrainingCalendarQuestions");
            b.HasKey(x => x.Id);

            b.Property(x => x.Rate).IsRequired();

            b.HasOne<Question>().WithMany().HasForeignKey(x => x.QuestionId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<TrainingCalendar>().WithMany().HasForeignKey(x => x.TrainingCalendarId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class TrainingCalendarQuestionAnswerConfig : IEntityTypeConfiguration<TrainingCalendarQuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<TrainingCalendarQuestionAnswer> b)
        {
            b.ToTable("TrainingCalendarQuestionAnswers");
            b.HasKey(x => x.Id);

            b.Property(x => x.Answer).HasMaxLength(1000);
            b.Property(x => x.AnswerRate).IsRequired(false);
            b.Property(x => x.OptionId).IsRequired(false);
            b.Property(x => x.AnsweredAt).IsRequired();

            b.HasOne<TrainingCalendarQuestion>().WithMany().HasForeignKey(x => x.TrainingCalendarQuestionId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne<Personel>().WithMany().HasForeignKey(x => x.PersonelId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class EvaluationQuestionConfig : IEntityTypeConfiguration<EvaluationQuestion>
    {
        public void Configure(EntityTypeBuilder<EvaluationQuestion> b)
        {
            b.ToTable("EvaluationQuestions");
            b.HasKey(x => x.Id);

            b.Property(x => x.Title).IsRequired().HasMaxLength(300);
            b.Property(x => x.Rate).IsRequired();
            b.Property(x => x.Type).IsRequired();
            b.Property(x => x.IsActive).IsRequired();
        }
    }

    #endregion

    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> b)
        {
            b.ToTable("Teachers");
            b.HasKey(x => x.Id);

            b.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            b.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            b.Property(x => x.Type).IsRequired();
        }
    }
}