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

        List<string> valores = new List<string>();
        valores.Add("Renta");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, valores);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    
    [HttpGet("nombre_agente")]
    public IActionResult NombreAgente([FromQuery]List<string> valores){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

         var filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, valores);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

    [HttpGet("costo")]
    public IActionResult Costo([FromQuery]List<string> valores){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> Costo = new List<int>();
     Costo.Add(33421);
     Costo.Add(1331);
     Costo.Add(777);
     
         var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, valores);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}