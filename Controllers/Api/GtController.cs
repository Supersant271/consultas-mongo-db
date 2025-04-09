using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class NeController : Controller{

    [HttpGet("costo")]
    public IActionResult costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.costo,"10000");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
         [HttpGet("Metrosterreno")]
    public IActionResult metrosterreno(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.MetrosTerreno,"500");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
         [HttpGet("pisos")]
    public IActionResult pisos(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.pisos,"0");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
}        