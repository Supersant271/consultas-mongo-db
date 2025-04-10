using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller{

    [HttpGet("costo")]
    public IActionResult costo(int costo){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo,costo);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
       [HttpGet("metrosterreno")]
    public IActionResult Metros_Terreno(int Metros_Terreno){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno,Metros_Terreno);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
        [HttpGet("pisos")]
    public IActionResult Pisos(int Pisos){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos,Pisos);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
}     