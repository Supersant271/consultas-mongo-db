using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/Lte")]
public class IteController : Controller{
    [HttpGet("costo")]
    public IActionResult Costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 50000);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
     [HttpGet("pisos")]
    public IActionResult Pisos(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 3);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("metrosterreno")]
    public IActionResult Metros_Terreno(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 518);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}

       