var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BabyMetricsBlazor>("babymetricsblazor");

builder.Build().Run();
