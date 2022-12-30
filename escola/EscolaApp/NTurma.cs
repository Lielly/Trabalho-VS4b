using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    static class NTurma
    {
        //private Turma[] turmas = new Turma[10];
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t)
        {
            Abrir();
            turmas.Add(t);
            Salvar();
        }
        public static List<Turma> Listar()
        {
            return turmas;
        }
        public static void Atualizar(Turma t)
        {
            Abrir();
            // Percorrer a lista de turma procurando o id informado (t.Id)
            foreach (Turma obj in turmas)
            {
                if (obj.Id == t.Id)
                {
                    obj.Curso = t.Curso;
                    obj.Descricao = t.Descricao;
                    obj.AnoLetivo = t.AnoLetivo;
                }
            }
            Salvar();     
        }
        public static void Excluir(Turma t)
        {
            // Percorrer a lista de turma procurando o id informado (t.Id)
            Turma x = null;
            foreach (Turma obj in turmas)
                if (obj.Id == t.Id) x = obj;
            if (x != null) turmas.Remove(x);
        }
        public static void Abrir()
        {
            StreamReader f = null;

            try
            {
                //objeto que transforma o xml em bloco de texto
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                //obj que grava um texto em arquivo
            }
        }
        public static void Salvar()
        {

        }
    }
}
