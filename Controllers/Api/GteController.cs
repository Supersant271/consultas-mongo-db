[ApiController]
[Route("api/gte")]
public class EqController : Controller{
    [HttpGet("listar-Costo-pisos-terrenos")]
    public IActionResult ListarAgencia (string agencia, string? agente){
        //Listar todos los registros de la agencia Torres Really

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        // Obtener todas las casas en venta con más de 500 metros de construcción
        var filtroCasas = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Costo");
        var filtroVenta = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "pisos");
        var filtroMetros = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 500);

        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroCasas, filtroVenta, filtroMetros);
        var list = collection.Find(filtroCompuesto).ToList();

        return Ok(list);
    }
}
