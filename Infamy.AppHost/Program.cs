var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Infamy_ApiService>("apiservice");

builder.AddProject<Projects.Infamy_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
