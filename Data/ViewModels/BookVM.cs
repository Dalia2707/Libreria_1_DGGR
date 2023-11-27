using System;
using System.Collections.Generic;

namespace Libreria_DGGR.Data.ViewModels
{
    public class BookVM
    {
        public string Titulo { get; set; }
        public string Descripccion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }
        public int PublisherID { get; set; }
        public List<int> AutorIDs { get; set; }
    }
    public class BookWhitAuthorVM
    {
        public string Titulo { get; set; }
        public string Descripccion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }
        public int PublisherName { get; set; }
        public List<int> AutorNames { get; set; }
    }
}
