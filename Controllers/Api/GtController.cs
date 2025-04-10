using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller{

    [HttpGet("costo")]
    public IActionResult costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo,10000);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
        
}     