namespace tl2_tp07_2023_IvanDMir.Controllers;
using EspacioTarea;
using  AccesoADatos;

public class ManejoDeDatos{
    private AccesoTareas acceso;
    private List<Tarea> ListaTarea;
    private List<Tarea> listatarea{get =>acceso.ObtenerLista();}

     public ManejoDeDatos(AccesoTareas accesoTarea){
        this.acceso = accesoTarea;
        ListaTarea = accesoTarea.ObtenerLista();
    }

    public void CrearTarea(Tarea TareaNueva){
        if(TareaNueva != null){
            TareaNueva.id = ListaTarea.Count() +1;
            acceso.GuardarTareas(ListaTarea);
        }
    }
    public Tarea ObtenerTareaxID(int id){
        var tareaABuscar = ListaTarea.FirstOrDefault(tarea => tarea.id == id);
        return tareaABuscar;
    }
     public List<Tarea> ObtenerTareasCompletadas(){
        List<Tarea> tareasCompletadas = ListaTarea.FindAll(tarea => tarea.estado == Estados.completada);
        return tareasCompletadas;
    }
   public void ModificarTarea(int id){
        Tarea tareaAModificar= ObtenerTareaxID(id);
        
        if(ListaTarea.Count != 0){
            var tareaAReemplazar = ListaTarea.FirstOrDefault(tarea => tarea.id == tareaAModificar.id);
            if(tareaAReemplazar != null){
                ListaTarea.Remove(tareaAReemplazar);
                ListaTarea.Insert(tareaAModificar.id - 1, tareaAModificar);
                acceso.GuardarTareas(ListaTarea);
            }
        }

    }

    public void EliminarTarea(int id){
        Tarea Eliminada = ObtenerTareaxID(id);
        ListaTarea.Remove(Eliminada);
        acceso.GuardarTareas(ListaTarea);
    }
}
