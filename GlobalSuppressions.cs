// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "MVC1005:Using 'UseMvcWithDefaultRoute' to configure MVC is not supported while using Endpoint Routing. To continue using 'UseMvcWithDefaultRoute', please set 'MvcOptions.EnableEndpointRouting = false' inside 'ConfigureServices'.", Justification = "<Ожидание>", Scope = "member", Target = "~M:ShopTest.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder,Microsoft.AspNetCore.Hosting.IWebHostEnvironment)")]
