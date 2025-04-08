[ApiController]
[Route("api/nin")]
public class EqController : Controller{
    [HttpGet("listar-costo")]
    public IActionResult ListarAgencia (string agencia, string? agente){
        