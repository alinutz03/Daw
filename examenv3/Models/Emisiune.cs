using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace examenv3.Models
{
    public class Emisiune
    {
        public Emisiune()
        {
            Id = 0;
            Titlu = "";
            Producator = "";
            AnLansare = 0;
            Gen = "";
            CanalId = 0;

        }

        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Producator { get; set; }
        public int AnLansare { get; set; }
        public string Gen { get; set; }

        [ForeignKey("CanalId")]
        public int CanalId { get; set; }

        public Canal_TV Canal_TV { get; set; }

       
    }
}
