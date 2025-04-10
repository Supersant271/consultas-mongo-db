using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller{
    [HttpGet("listar-Agencia")]
    public IActionResult ListarAgencia (string agencia, string? agente){
        //Listar todos los registros de la agencia Torres Really

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //que la agencia sea Torres Realty
        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, agencia);

        if(!string.IsNullOrWhiteSpace(agente)){
            var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, agente);
            var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroAgencia, filtroAgente);

            var lista = collection.Find(filtroCompuesto).ToList();    

            return Ok(lista);
        }
        else{
            var lista = collection.Find(filtroAgencia).ToList();    
            return Ok(lista);
        }

    }
    

    [HttpGet("operacion")]
    public IActionResult Operacion(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion,"Renta");
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }

         [HttpGet("pisos")]
    public IActionResult pisos(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Eq(x => x.Pisos, 0);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }

         [HttpGet("costo")]
    public IActionResult costo(){

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

            var filtro = Builders<Inmueble>.Filter.Eq(x => x.Costo, 33421);
            var lista = collection.Find(filtro).ToList();
            return Ok (lista);
        }
}    