using Exam.API.Profiles;
using Exam.Appilication.Abstraction.Repository;
using Exam.Appilication.Abstraction.Services;
using Exam.Persistence.Contex;
using Exam.Persistence.Implimentation.Repository;
using Exam.Persistence.Implimentation.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region User Repositories and Service
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
#endregion

#region  Exam Repositories and Service
builder.Services.AddScoped<IExamRepository, ExamRepository>();
builder.Services.AddScoped<IExamService, ExamService>();
#endregion

#region  Answer Repositories and Service
builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
builder.Services.AddScoped<IAnswerService, AnswerService>();
#endregion

#region  Question Repositories and Service
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
#endregion

#region  StudentExam Repositories and Service
builder.Services.AddScoped<IStudentExamRepository, StudentExamRepository>();
builder.Services.AddScoped<IStudentExamService, StudentExamService>();
#endregion

#region  StudentResult Repositories and Service
builder.Services.AddScoped<IStudentResultRepository, StudentResultRepository>();
builder.Services.AddScoped<IStudentResultService, StudentResultService>();
#endregion

builder.Services.AddAutoMapper(typeof(UserMapper));
builder.Services.AddAutoMapper(typeof(AnswerMapper));
builder.Services.AddAutoMapper(typeof(ExamMapper));
builder.Services.AddAutoMapper(typeof(QuestionMapper));
builder.Services.AddAutoMapper(typeof(StudentExamMapper));
builder.Services.AddAutoMapper(typeof(StudentResultMapper));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
