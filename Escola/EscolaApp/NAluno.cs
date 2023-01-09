using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    static class NAluno
    {
        //private Aluno[] alunos = new Aluno[10];
        private static List<Aluno> alunos = new List<Aluno>();
        public static void Inserir(Aluno t)
        {
            Abrir();
            alunos.Add(t);
            Salvar();
        }
        public static List<Aluno> Listar()
        {
            Abrir();
            return alunos;
        }
        public static void Atualizar(Aluno t)
        {
            Abrir();
            // Percorrer a lista de turma procurando o id informado (t.Id)
            foreach (Aluno obj in alunos)
                if (obj.Id == t.Id)
                {
                    obj.Nome = t.Nome;
                    obj.Matricula = t.Matricula;
                    obj.Email = t.Email;
                }
            Salvar();
        }
        public static void Excluir(Aluno t)
        {
            Abrir();
            // Percorrer a lista de turma procurando o id informado (t.Id)
            Aluno x = null;
            foreach (Aluno obj in alunos)
                if (obj.Id == t.Id) x = obj;
            if (x != null) alunos.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // Objeto que serializa (transforma) uma lista de alunos em um texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
                // Objeto que abre um texto em um arquivo
                f = new StreamReader("./alunos.xml");
                // Chama a operação de desserialização informando a origem do texto XML
                alunos = (List<Aluno>)xml.Deserialize(f);
            }
            catch
            {
                alunos = new List<Aluno>();
            }
            // Fecha o arquivo
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // Objeto que serializa (transforma) uma lista de alunos em um texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            // Objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./alunos.xml", false);
            // Chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, alunos);
            // Fecha o arquivo
            f.Close();
        }
    }
}
