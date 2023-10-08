using AccesoADatos;
using EspacioTarea;
using Microsoft.AspNetCore.Mvc;

namespace tl2_tp07_2023_IvanDMir.Controllers;

[ApiController]
[Route("[controller]")]
public class TareaController : ControllerBase
{
    private ManejoDeDatos manejoDeDatos;
    private readonly ILogger<TareaController> _logger;

    public TareaController(ILogger<TareaController> logger)
    {
        _logger = logger;
        AccesoTareas acceso = new AccesoTareas();
        manejoDeDatos = new ManejoDeDatos(acceso);
    }
    [HttpPost("AgregarTarea")]
    public ActionResult AgregarTareas(Tarea TareaNueva){
        manejoDeDatos.CrearTarea(TareaNueva);
        return Ok("TareaAgregadaExitosamente"); 
}
[HttpGet("GetTareaXID")]
public ActionResult<Tarea> GetTarea(int id){
    if(manejoDeDatos.ObtenerTareaxID(id) == null){
        return BadRequest("No se encontró la tarea");
        
    }else{
        return Ok(manejoDeDatos.ObtenerTareaxID(id));
    }
}
[HttpPut("ModificarTarea")]
public ActionResult ModificarTarea(int id){
    manejoDeDatos.ModificarTarea(id);
    
}

}


