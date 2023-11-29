using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDAL.Entidades
{
    public class Autor
    {
        [Column("id_autor")]
        public long Id { get; set; }
        public string nombre_autor {  get; set; }
        public string apellidos_autor { get; set; }
        //Autores
        public List<Libro> listaLibros {  get; set; } 
    }
}
