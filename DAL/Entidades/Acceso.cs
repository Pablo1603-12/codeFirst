using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Acceso
    {
        [Column("id_acceso")]
        public long Id { get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }
        public List<Usuario> listaUsuarios { get; set; }
    }
}
