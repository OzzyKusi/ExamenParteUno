using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Jobs
    {
        //atributos de la clase
        private string job_decs;
        private int job_id;
        private int min_lvl;
        private int max_lvl;

        //propiedades
        public string Job_decs { get => job_decs; set => job_decs = value; }
        public int Job_id { get => job_id; set => job_id = value; }
        public int Min_lvl { get => min_lvl; set => min_lvl = value; }
        public int Max_lvl { get => max_lvl; set => max_lvl = value; }
    }
}
