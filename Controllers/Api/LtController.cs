[ApiController]
[Route("api/lit")]
public class EqController : Controller{
    [HttpGet("listar-Agencia")]
    public IActionResult ListarAgencia (string agencia, string? agente){
        //Listar todos los registros de la agencia Torres Really

        