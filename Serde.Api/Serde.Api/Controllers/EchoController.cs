namespace Serde.Api.Controllers {
  using Microsoft.AspNetCore.Mvc;

  using Serde.Models;

  [Route("[controller]/[action]")]
  public class EchoController : Controller {
    [HttpPost]
    public IActionResult Cwmp([FromBody] ClassWithMutableProperties arg) {
      return arg == null ? (IActionResult)this.BadRequest() : this.Ok(arg);
    }
  }
}
