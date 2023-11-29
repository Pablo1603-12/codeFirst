using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Genero
    {
        [Column("id_genero")]
        public long Id { get; set; }
        public string nombre_genero {  get; set; }
        public string descripcion_genero { get; set; }
    }
}
