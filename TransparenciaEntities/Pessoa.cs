using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransparenciaEntities
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Curso { get; set; }

        public string Cargo { get; set; }

        [Display(Name = "Horas/Mês")]
        public decimal? Horas { get; set; }

        [Display(Name = "Unidade")]
        [ForeignKey("Unidade")]
        public int UnidadeId { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
