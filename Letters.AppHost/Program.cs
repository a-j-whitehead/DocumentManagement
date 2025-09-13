var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Letters_Api>("letters");

builder.Build().Run();
