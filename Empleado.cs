
public class Empleado
    {
        public int id {get; set;}
        public string name {get; set;}
        public string release_date { get; set; }
        public int rating { get; set; }
        public string category { get; set; }
        

        public override string ToString()
        {
            return "Nombre: "+name+".\n";
        }

    }
