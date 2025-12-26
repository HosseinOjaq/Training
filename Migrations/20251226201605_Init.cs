using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hossein.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalendarCostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarCostTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingStandards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personels_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TotalCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendars_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendars_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostDuties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    DutyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDuties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostDuties_Duties_DutyId",
                        column: x => x.DutyId,
                        principalTable: "Duties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostDuties_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionOptions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTrainingStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TrainingStandardId = table.Column<int>(type: "int", nullable: false),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTrainingStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTrainingStandards_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostTrainingStandards_TrainingStandards_TrainingStandardId",
                        column: x => x.TrainingStandardId,
                        principalTable: "TrainingStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingStandardAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingStandardId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingStandardAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingStandardAttachments_TrainingStandards_TrainingStandardId",
                        column: x => x.TrainingStandardId,
                        principalTable: "TrainingStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTrainingCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTrainingCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendars_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendars_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarAttachments_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarEvaluationQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: true),
                    EvaluationQuestionId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarEvaluationQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarEvaluationQuestions_EvaluationQuestions_EvaluationQuestionId",
                        column: x => x.EvaluationQuestionId,
                        principalTable: "EvaluationQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarEvaluationQuestions_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarPrerequisites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: true),
                    TrainingStandardId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarPrerequisites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarPrerequisites_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarPrerequisites_TrainingStandards_TrainingStandardId",
                        column: x => x.TrainingStandardId,
                        principalTable: "TrainingStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarQuestions_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    TrainingStandardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarStandards_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarStandards_TrainingStandards_TrainingStandardId",
                        column: x => x.TrainingStandardId,
                        principalTable: "TrainingStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarTeachers_TrainingCalendars_TrainingCalendarId",
                        column: x => x.TrainingCalendarId,
                        principalTable: "TrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTrainingStandardAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTrainingStandardId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTrainingStandardAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTrainingStandardAttachments_PostTrainingStandards_PostTrainingStandardId",
                        column: x => x.PostTrainingStandardId,
                        principalTable: "PostTrainingStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTrainingCalendarCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelTrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    CalendarCostTypeId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTrainingCalendarCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarCosts_CalendarCostTypes_CalendarCostTypeId",
                        column: x => x.CalendarCostTypeId,
                        principalTable: "CalendarCostTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarCosts_PersonelTrainingCalendars_PersonelTrainingCalendarId",
                        column: x => x.PersonelTrainingCalendarId,
                        principalTable: "PersonelTrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTrainingCalendarMeetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelTrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    ScheduledStartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduledEndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualStartAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualEndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTrainingCalendarMeetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarMeetings_PersonelTrainingCalendars_PersonelTrainingCalendarId",
                        column: x => x.PersonelTrainingCalendarId,
                        principalTable: "PersonelTrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarMeetings_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTrainingCalendarMeetingScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelTrainingCalendarId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTrainingCalendarMeetingScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarMeetingScores_PersonelTrainingCalendars_PersonelTrainingCalendarId",
                        column: x => x.PersonelTrainingCalendarId,
                        principalTable: "PersonelTrainingCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarEvaluationQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarEvaluationQuestionId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AnswerType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarEvaluationQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarEvaluationQuestionAnswers_TrainingCalendarEvaluationQuestions_TrainingCalendarEvaluationQuestionId",
                        column: x => x.TrainingCalendarEvaluationQuestionId,
                        principalTable: "TrainingCalendarEvaluationQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCalendarQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainingCalendarQuestionId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AnswerRate = table.Column<float>(type: "real", nullable: true),
                    OptionId = table.Column<int>(type: "int", nullable: true),
                    AnsweredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCalendarQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarQuestionAnswers_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingCalendarQuestionAnswers_TrainingCalendarQuestions_TrainingCalendarQuestionId",
                        column: x => x.TrainingCalendarQuestionId,
                        principalTable: "TrainingCalendarQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTrainingCalendarMeetingAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelTrainingCalendarMeetingId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTrainingCalendarMeetingAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarMeetingAttachments_PersonelTrainingCalendarMeetings_PersonelTrainingCalendarMeetingId",
                        column: x => x.PersonelTrainingCalendarMeetingId,
                        principalTable: "PersonelTrainingCalendarMeetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelTrainingCalendarMeetingAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelTrainingCalendarMeetingId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    LateMinutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTrainingCalendarMeetingAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarMeetingAttendances_PersonelTrainingCalendarMeetings_PersonelTrainingCalendarMeetingId",
                        column: x => x.PersonelTrainingCalendarMeetingId,
                        principalTable: "PersonelTrainingCalendarMeetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonelTrainingCalendarMeetingAttendances_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmentId",
                table: "Personels",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarCosts_CalendarCostTypeId",
                table: "PersonelTrainingCalendarCosts",
                column: "CalendarCostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarCosts_PersonelTrainingCalendarId",
                table: "PersonelTrainingCalendarCosts",
                column: "PersonelTrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarMeetingAttachments_PersonelTrainingCalendarMeetingId",
                table: "PersonelTrainingCalendarMeetingAttachments",
                column: "PersonelTrainingCalendarMeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarMeetingAttendances_PersonelId",
                table: "PersonelTrainingCalendarMeetingAttendances",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarMeetingAttendances_PersonelTrainingCalendarMeetingId",
                table: "PersonelTrainingCalendarMeetingAttendances",
                column: "PersonelTrainingCalendarMeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarMeetings_PersonelTrainingCalendarId",
                table: "PersonelTrainingCalendarMeetings",
                column: "PersonelTrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarMeetings_TeacherId",
                table: "PersonelTrainingCalendarMeetings",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendarMeetingScores_PersonelTrainingCalendarId",
                table: "PersonelTrainingCalendarMeetingScores",
                column: "PersonelTrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendars_PersonelId_TrainingCalendarId",
                table: "PersonelTrainingCalendars",
                columns: new[] { "PersonelId", "TrainingCalendarId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTrainingCalendars_TrainingCalendarId",
                table: "PersonelTrainingCalendars",
                column: "TrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_PostDuties_DutyId",
                table: "PostDuties",
                column: "DutyId");

            migrationBuilder.CreateIndex(
                name: "IX_PostDuties_PostId_DutyId",
                table: "PostDuties",
                columns: new[] { "PostId", "DutyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostTrainingStandardAttachments_PostTrainingStandardId",
                table: "PostTrainingStandardAttachments",
                column: "PostTrainingStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTrainingStandards_PostId_TrainingStandardId",
                table: "PostTrainingStandards",
                columns: new[] { "PostId", "TrainingStandardId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostTrainingStandards_TrainingStandardId",
                table: "PostTrainingStandards",
                column: "TrainingStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarAttachments_TrainingCalendarId",
                table: "TrainingCalendarAttachments",
                column: "TrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarEvaluationQuestionAnswers_TrainingCalendarEvaluationQuestionId",
                table: "TrainingCalendarEvaluationQuestionAnswers",
                column: "TrainingCalendarEvaluationQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarEvaluationQuestions_EvaluationQuestionId",
                table: "TrainingCalendarEvaluationQuestions",
                column: "EvaluationQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarEvaluationQuestions_TrainingCalendarId",
                table: "TrainingCalendarEvaluationQuestions",
                column: "TrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarPrerequisites_TrainingCalendarId",
                table: "TrainingCalendarPrerequisites",
                column: "TrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarPrerequisites_TrainingStandardId",
                table: "TrainingCalendarPrerequisites",
                column: "TrainingStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarQuestionAnswers_PersonelId",
                table: "TrainingCalendarQuestionAnswers",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarQuestionAnswers_TrainingCalendarQuestionId",
                table: "TrainingCalendarQuestionAnswers",
                column: "TrainingCalendarQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarQuestions_QuestionId",
                table: "TrainingCalendarQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarQuestions_TrainingCalendarId",
                table: "TrainingCalendarQuestions",
                column: "TrainingCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendars_CourseId",
                table: "TrainingCalendars",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendars_DepartmentId",
                table: "TrainingCalendars",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarStandards_TrainingCalendarId_TrainingStandardId",
                table: "TrainingCalendarStandards",
                columns: new[] { "TrainingCalendarId", "TrainingStandardId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarStandards_TrainingStandardId",
                table: "TrainingCalendarStandards",
                column: "TrainingStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarTeachers_TeacherId",
                table: "TrainingCalendarTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCalendarTeachers_TrainingCalendarId_TeacherId",
                table: "TrainingCalendarTeachers",
                columns: new[] { "TrainingCalendarId", "TeacherId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingStandardAttachments_TrainingStandardId",
                table: "TrainingStandardAttachments",
                column: "TrainingStandardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonelTrainingCalendarCosts");

            migrationBuilder.DropTable(
                name: "PersonelTrainingCalendarMeetingAttachments");

            migrationBuilder.DropTable(
                name: "PersonelTrainingCalendarMeetingAttendances");

            migrationBuilder.DropTable(
                name: "PersonelTrainingCalendarMeetingScores");

            migrationBuilder.DropTable(
                name: "PostDuties");

            migrationBuilder.DropTable(
                name: "PostTrainingStandardAttachments");

            migrationBuilder.DropTable(
                name: "QuestionOptions");

            migrationBuilder.DropTable(
                name: "TrainingCalendarAttachments");

            migrationBuilder.DropTable(
                name: "TrainingCalendarEvaluationQuestionAnswers");

            migrationBuilder.DropTable(
                name: "TrainingCalendarPrerequisites");

            migrationBuilder.DropTable(
                name: "TrainingCalendarQuestionAnswers");

            migrationBuilder.DropTable(
                name: "TrainingCalendarStandards");

            migrationBuilder.DropTable(
                name: "TrainingCalendarTeachers");

            migrationBuilder.DropTable(
                name: "TrainingStandardAttachments");

            migrationBuilder.DropTable(
                name: "CalendarCostTypes");

            migrationBuilder.DropTable(
                name: "PersonelTrainingCalendarMeetings");

            migrationBuilder.DropTable(
                name: "Duties");

            migrationBuilder.DropTable(
                name: "PostTrainingStandards");

            migrationBuilder.DropTable(
                name: "TrainingCalendarEvaluationQuestions");

            migrationBuilder.DropTable(
                name: "TrainingCalendarQuestions");

            migrationBuilder.DropTable(
                name: "PersonelTrainingCalendars");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "TrainingStandards");

            migrationBuilder.DropTable(
                name: "EvaluationQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "TrainingCalendars");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
