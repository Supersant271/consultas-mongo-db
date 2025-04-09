using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class NeController : Controller{

    [HttpGet("costo")]
    public IActionResult costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.costo,"0");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
         [HttpGet("pisos")]
    public IActionResult pisos(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.pisoso,"3");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
         [HttpGet("metrosterreno")]
    public IActionResult metrosterreno(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.metrosterreno,"479");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
}        