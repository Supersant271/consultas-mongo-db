using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller{
    [HttpGet("listar-Agencia")]
    public IActionResult ListarAgencia (){
        //Listar todos los registros de la agencia Torres Really

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Tores Realty");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);

    }
    
}