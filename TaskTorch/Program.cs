using Microsoft.OpenApi.Models;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tasks studies API - v1", Version = "v1" });
    c.SwaggerDoc("v2", new OpenApiInfo { Title = "Tasks studies API - v2", Version = "v2" });
});
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tasks studies API - v1");
    c.SwaggerEndpoint("/swagger/v2/swagger.json", "Tasks studies API - v2");
});

app.UseHttpsRedirection();


app.MapGet("/ConcurrentExclusiveSchedulerPair", () =>
{
    // Create a ConcurrentExclusiveSchedulerPair
    var taskSchedulerPair = new ConcurrentExclusiveSchedulerPair();

    Debug.WriteLine($"\n\n\n=================================================\n" +
        $"Creating X read tasks that will run concurrently" +
        $"\n======================================================\n\n");
    // Creating X read tasks that will run concurrently
    for (int i = 0; i < 5; i++)
    {
        int taskNumber = i; // Capture the loop variable in a separate context
        var readTask = new Task(() =>
        {
            Debug.WriteLine($"Starting read task {taskNumber}...");
            Thread.Sleep(3000); // Simulates a read time
            Debug.WriteLine($"Read task {taskNumber} completed!");
        });

        // We schedule the read task on the concurrent execution queue
        readTask.Start(taskSchedulerPair.ConcurrentScheduler);
    }

    // Creating a write task that should run exclusively
    var writeTask = new Task(() =>
    {
        Debug.WriteLine($"Starting write task...");
        Thread.Sleep(1000); // Simulates a write time
        Debug.WriteLine($"Write task completed!");
    });

    // We schedule the write task on the exclusive execution queue
    writeTask.Start(taskSchedulerPair.ExclusiveScheduler);

    // Waits for the read and write tasks to complete before exiting
    Task.WaitAll(writeTask);

    Debug.WriteLine($"All tasks completed!");

    return $"In this example, we create three read tasks and one write task. " +
    $" The read tasks are scheduled on the ConcurrentExclusiveSchedulerPair's " +
    $" concurrent execution queue, meaning they can run at the same time. " +
    $" The write task is scheduled on the exclusive execution queue, meaning it " +
    $" will run by itself.\r\n\r\nWhen running this program, you will see that " +
    $" the read tasks start and finish together, while the write task only begins " +
    $" execution after all the read tasks have completed. This ensures that no " +
    $" read/write data conflicts occur.\r\n\r\nPlease remember this is a simplified " +
    $" example for demonstration purposes. In practice, you would likely have read " +
    $" and write tasks that interact with some sort of shared resource, such as " +
    $" a database or file.";
})
.WithName("ConcurrentExclusiveSchedulerPair")
.WithOpenApi()
.WithDisplayName("Fist use of ConcurrentExclusiveSchedulerPair")
.WithDescription("{{Here - The description}}")
.WithGroupName("v1")
.WithSummary("{{Here - The WithSummary approach}}")
.WithTags("Topic 1 - Introductionary endpoints");


app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
