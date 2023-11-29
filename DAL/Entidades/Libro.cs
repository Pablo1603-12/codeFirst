using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Libro
    {
        [Column("id_libro")]
        public long Id {  get; set; }
        public string isbn_libro {  get; set; }
        public string titulo_libro { get; set; }
        public string edicion_libro { get; set; }
        public int cantidad_libro { get; set; }
        //Prestamos
        public List<Prestamo> listaPrestamos { get; set; }
        //Autores
        public List<Autor> listaAutores { get; set; }

    }
}
