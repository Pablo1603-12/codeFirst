using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Editorial
    {
        [Column("id_editorial")]
        public long Id {  get; set; }
        public string nombre_editorial {  get; set; }
    }
}
