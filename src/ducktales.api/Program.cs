using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ducktales.api {
    [ExcludeFromCodeCoverage]
    public static class Program {
        public static void Main(string[] args) {
            BuildWebHost(args).Run();
        }

        private static IWebHost BuildWebHost(string[] args) {
            // To open only one thread, set the environment variables bellow:
            // -----------------------------------------------------------------
            // ComPlus_ThreadPool_ForceMinWorkerThreads=1
            // ComPlus_ThreadPool_ForceMaxWorkerThreads=1
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:5000") // Take that, Docker port forwarding!!!
                .Build();
        }
    }
}