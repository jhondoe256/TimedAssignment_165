using Microsoft.EntityFrameworkCore;
using TimedAssignment.Data.Data;
using TimedAssignment.Services.CommentServices;
using TimedAssignment.Services.LikeServices;
using TimedAssignment.Services.PostServices;
using TimedAssignment.Services.ReplyServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//we want the ability to new suff up and controll its lifespan!!! and the is based on dependency injection!!!!
// we can make a new object over and over again when an endpoint is hit
//builder.Services.AddTransient<ILikeService,LikeService>();

// we want to  make a new object but it will just hang around until its no loger needed  (waits for endpoint to be hit)
builder.Services.AddScoped<IReplyService,ReplyService>();
builder.Services.AddScoped<ICommentService,CommentService>();
builder.Services.AddScoped<ILikeService,LikeService>();
builder.Services.AddScoped<IPostService,PostService>();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer( builder.Configuration.GetConnectionString("DefaultConnection")));

// the last way to new stuff up via I.O.C container... add singleton 
// once this guy is created it will last for the entire applications lifespan
//builder.Services.AddSingleton<ICommentService,CommentService>();

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
