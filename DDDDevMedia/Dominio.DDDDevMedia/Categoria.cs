using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DDDDevMedia
{
    public class Categoria
    {
        
        // Propriedades
        public int Id_Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public IList<Produto> Produtos { get; set; }
    }

}
