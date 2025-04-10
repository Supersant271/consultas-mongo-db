using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller{
    [HttpGet("operacion")]
    public IActionResult Operacion(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, "reanta");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}