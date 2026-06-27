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
    }
}
