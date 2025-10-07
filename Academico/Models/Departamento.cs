using System.ComponentModel;

namespace Academico.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public Instituicao? Instituicao { get; set; }
        public long InstituicaoId { get; set; }
    }
}

