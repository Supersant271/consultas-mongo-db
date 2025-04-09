using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller{
    [HttpGet("costo")]
    public IActionResult Costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 50000);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}

        