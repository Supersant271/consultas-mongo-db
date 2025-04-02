using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller{
    [HttpGet("listar-agencia")]
    public IActionResult ListarAgencia (){
        //Listar todos los registros de la agencia Torres Really

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();

        return Ok(lista);

    }
    
}