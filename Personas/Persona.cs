using System.Collections.ObjectModel;

namespace Personas
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Sexo { get; set; }

        public Persona(int id, string nombre, string foto, string sexo)
        {
            Id = id;
            Nombre = nombre;
            Foto = foto;
            Sexo = sexo;
        }

        public static ObservableCollection<Persona> GetPersonas()
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>
            {
                new Persona(1, "Pepe", "img/1.jpg", "Hombre"),
                new Persona(2, "Antonio", "img/2.jpg", "Hombre"),
                new Persona(3, "Sara", "img/3.jpg", "Mujer")
            };

            return lista;
        }
    }
}
