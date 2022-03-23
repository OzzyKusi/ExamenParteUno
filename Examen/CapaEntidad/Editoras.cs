using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Editoras
    {
        // atributos de la clase
        private string pub_id;
        private string pub_name;
        private string city;
        private string stado;
        private string country;

        public string Pub_id { get => pub_id; set => pub_id = value; }
        public string Pub_name { get => pub_name; set => pub_name = value; }
        public string City { get => city; set => city = value; }
        public string Stado { get => stado; set => stado = value; }
        public string Country { get => country; set => country = value; }
        // propiedades

    }
}
