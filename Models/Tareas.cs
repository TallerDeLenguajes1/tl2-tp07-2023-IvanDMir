using AccesoADatos;
namespace EspacioTarea{
    public enum Estados{
        Enprogreso,
        pendiente,
        completada
    }
    public class Tarea{
        private int ID;
        private string Titulo;
        private string Descripcion;
        private Estados Estado;
    
    public Tarea(int id, string titulo,string descripcion,Estados estado){
        this.ID=id;
        this.Titulo=titulo;
        this.Descripcion=descripcion;
        this.Estado=estado;
    }

    }
}