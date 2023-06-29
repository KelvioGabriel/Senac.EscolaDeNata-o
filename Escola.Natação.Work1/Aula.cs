using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Natação.Work1
{
    internal class Aula
    {
        public DateTime DataHora { get; set; }
        public Aula AulaMarcacao { get; set; }
        public Aluno AlunoMarcacao { get; set; }
    }
}
