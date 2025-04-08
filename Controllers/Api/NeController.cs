using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller{

    [HttpGet("uriel-es-negro")]
    public IActionResult UrielEsNegro(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion,"Venta");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
}        
       