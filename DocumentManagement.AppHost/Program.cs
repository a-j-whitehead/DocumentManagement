var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DocumentManagement_Api>("DocumentManagement");

builder.Build().Run();
