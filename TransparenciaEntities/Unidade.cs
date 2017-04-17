using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransparenciaEntities
{
    [Table("Unidades")]
    public class Unidade
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }
    }
}
