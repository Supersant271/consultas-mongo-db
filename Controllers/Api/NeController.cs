[ApiController]
[Route("api/ne")]
public class EqController : Controller{
    [HttpGet("listar-Agencia")]
    public IActionResult ListarAgencia (string agencia, string? agente){
       