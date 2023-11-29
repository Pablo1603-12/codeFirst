using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Estados_Prestamos
    {
        [Column("id_estado_prestamo")]
        public long Id { get; set; }
        public string codigo_estado_prestamo {  get; set; }
        public string descripcion_estado_prestamo { get; set; }
        public List<Prestamo> listaPrestamos { get; set; }


    }
}
