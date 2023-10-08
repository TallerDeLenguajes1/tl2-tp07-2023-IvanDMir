using System.Text.Json;
using EspacioTarea;
namespace AccesoADatos{ 
public class AccesoTareas{

    
    public List<Tarea> ObtenerLista(){
        List<Tarea> lista = new List<Tarea>();
        string rutaArchivo = "../Datos/tareas.json";
        FileInfo Archivo = new FileInfo(rutaArchivo);
        if(Archivo.Exists && Archivo.Length > 0){
            string info = File.ReadAllText(rutaArchivo);
            lista = JsonSerializer.Deserialize<List<Tarea>>(info);
        }

        return lista;
    }
     public bool GuardarTareas(List<Tarea> listaTareas){
        string rutaArchivo = "tareas.json";
        FileInfo f = new FileInfo(rutaArchivo);
        if(listaTareas.Count == 0){
            return false;
        } else{
            string info = JsonSerializer.Serialize(listaTareas);
            File.WriteAllText(rutaArchivo, info);
            return true;
        }
     }
}




}





