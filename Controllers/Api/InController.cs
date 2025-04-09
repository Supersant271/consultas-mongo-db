using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class NeController : Controller{
    [HttpGet("listar-metros-terreno")]
    public IActionResult ListarMetrosTerreno() {

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

     List<int> terreno = new List<int>();
     terreno.Add(518);
     terreno.Add(479);

     var filtroTerreno = Builders<Inmueble>.Filter.In(x => x.MetrosTerreno, terreno);

     var list = collection.Find(filtroTerreno).ToList();

            return Ok(list);
        }   

}

