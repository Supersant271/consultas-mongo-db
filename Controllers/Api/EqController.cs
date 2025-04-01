[ApiController]
Route("api/eq")
public class EqController : Controller{
    [HTTpGet("listar-agencia ")]
    public IActionResult ListarAgencia (){
        return OK();

    }
    
}