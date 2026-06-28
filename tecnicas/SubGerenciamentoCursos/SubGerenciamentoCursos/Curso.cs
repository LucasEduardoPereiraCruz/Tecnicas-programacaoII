using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubGerenciamentoCursos
{
    public class Curso
    {
        public Curso(int codigo, string nome, int cargahoraria, int nummaxalunos)
        {
            Codigo = codigo;
            Nome = nome;
            CargaHoraria = cargahoraria;
            NumMaxAlunos = nummaxalunos;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int NumMaxAlunos { get; set; }

        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public void Matricular(Aluno aluno) // Criei um método Matricular que recebe o objeto do tipo Aluno
        {
            if(Alunos.Count >= NumMaxAlunos) // Quantos alunos estão matriculados? 
            {
                throw new Exception("Não há vagas disponíveis para este curso"); // throw - Significa "Pare este método e informe que ocorreu um erro"
            }
            Alunos.Add(aluno); // Adiciona um aluno dentro da lista
        }


        // LINQ // 

        // Método para exibir os alunos de forma ordenada 
        public List<Aluno> ObterAlunoOrdenados() // Usamos List<Aluno> pq ele vai retornar uma lista de alunos 
        {
            return Alunos.OrderBy(aluno => aluno.Nome).ToList(); // Aqui pegamos a lista de nomes e ordenamos por eles
        }

        
        // Método para encontrar alunos que começam com a letra A 
        public List<Aluno> ObterAlunosComNomeA()
        {
            return Alunos.Where(aluno => aluno.Nome.StartsWith("A")).ToList(); // StartsWith("A") - Começa com A 
        }


        // Método para ver qntdade total de alunos matriculados 
        public int QuantidadeAlunos()
        {
            return Alunos.Count();
        }


        // EXEMPLOS USANDO OUTROS MÉTODOS (Ñ FORAM PEDIDOS)

        // Método para procurar um aluno pelo nome
        public Aluno BuscarAlunoPorNome(string nome)
        {
            return Alunos.FirstOrDefault(aluno => aluno.Nome == nome);
        }




        // Método para verificar se existe um aluno com determinado nome
        public bool ExisteAluno(string nome)
        {
            return Alunos.Any(aluno => aluno.Nome == nome);
        }




        // Método para retornar apenas os e-mails dos alunos
        public List<string> ObterEmails()
        {
            return Alunos.Select(aluno => aluno.Email).ToList();
        }


    } // fim da classe 
} // fim do namespace 


