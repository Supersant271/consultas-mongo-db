using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller{

    [HttpGet("Ventas")]
    public IActionResult Ventas(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion,"Venta");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }

        [HttpGet("metrosterreno")]
    public IActionResult Metros_Terreno(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.MetrosTerreno, 974);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
        
        [HttpGet("pisos")]
    public IActionResult pisos(){


        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


            var filtro = Builders<Inmueble>.Filter.Ne(x => x.Pisos, 2);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }

}  
