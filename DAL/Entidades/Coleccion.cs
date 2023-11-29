using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Coleccion
    {
        [Column("id_coleccion")]
        public long Id { get; set; }
        public string nombre_coleccion {  get; set; }
    }
}
