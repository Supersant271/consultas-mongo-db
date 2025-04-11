using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller{
     [HttpGet("operacion")]
    public IActionResult Operacion(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> Operacion = new List<string>();
        Operacion.Add("Renta");
        Operacion.Add("Venta");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Operacion, Operacion);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    
    [HttpGet("nombre_agente")]
    public IActionResult NombreAgente([FromQuery]List<string> valores){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> NombreAgente = new List<string>();
     NombreAgente.Add("Ana Torres");
     NombreAgente.Add("María López");

         var filtro = Builders<Inmueble>.Filter.In(x => x.NombreAgente, NombreAgente);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

    [HttpGet("costo")]
    public IActionResult Costo([FromQuery]List<string> valores){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> Costo = new List<int>();
     Costo.Add(1331777);
     Costo.Add(11514);
     Costo.Add(38459);

         var filtro = Builders<Inmueble>.Filter.In(x => x.Costo, Costo);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

}

