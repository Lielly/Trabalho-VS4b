using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    class NTurma
    {
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t)
        {
            turmas.Add(t);
        }
        public static List<Turma> Listar()
        {
            return turmas;
        }
    }
}
