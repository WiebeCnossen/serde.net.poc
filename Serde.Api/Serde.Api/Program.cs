namespace Serde.Api {
  using Microsoft.AspNetCore;
  using Microsoft.AspNetCore.Hosting;

  internal class Program {
    private static void Main(string[] args) {
      WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().Run();
    }
  }
}
