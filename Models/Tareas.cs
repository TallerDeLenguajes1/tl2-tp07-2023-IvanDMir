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
    
    public int id {get => ID;set => ID = value;}
     public Estados estado {get => Estado;set => Estado = value;}
    public Tarea(int id, string titulo,string descripcion,Estados estado){
        this.ID=id;
        this.Titulo=titulo;
        this.Descripcion=descripcion;
        this.Estado=estado;
    }
    

    }
}