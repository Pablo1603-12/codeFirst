using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Prestamo
    {
        [Column("id_prestamo")]
        public long Id { get; set; }
        public DateTime fch_inicio_prestamo { get; set; }
        public DateTime fch_entrega_prestamo { get; set; }
        public DateTime fch_fin_prestamo { get; set; }
        //FK estados_prestamos
        public Estados_Prestamos estados_prestamos { get; set; } = null!;
        public long id_estados_prestamos { get; set; }
        //FK usuario
        public Usuario usuario { get; set; } = null!;
        public long id_usuario { get; set; }
        //Libros
        public List<Libro> listaLibros { get; set; }
    }
}
