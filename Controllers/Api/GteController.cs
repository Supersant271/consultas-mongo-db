using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller{

    [HttpGet("costo")]
    public IActionResult costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 0);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
       [HttpGet("pisos")]
    public IActionResult pisos(){


        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


            var filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, 3);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
        [HttpGet("metros_terreno")]
    public IActionResult MetrosTerreno(){


        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


            var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 479);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }

}        