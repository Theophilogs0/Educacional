using System.ComponentModel;

namespace Academico.Models
{
    public class Curso
    {
        public int Cursoid { get; set; }
        public string Nome { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public Departamento? Departamento { get; set; }
        public int DepartamentoId { get; set; }

    }
}
