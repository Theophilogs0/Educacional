using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }

        [DisplayName("e-mail")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O cep deve estar no formato xxxxx-xxx")]

        [DisplayName("CEP")]
        public string Cep { get; set; }
    }
}
//oi