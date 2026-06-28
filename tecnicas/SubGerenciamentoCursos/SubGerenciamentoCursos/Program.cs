

namespace SubGerenciamentoCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um curso 
            Curso curso = new Curso(1, "DSM", 150, 3);

            // Criando Alunos 
            Aluno aluno1 = new Aluno(1, "Lucas", "lucas@gmail.com"); 
            Aluno aluno2 = new Aluno(2, "Ana Bia", "bia@gmail.com"); 
            Aluno aluno3 = new Aluno(3, "Valdir", "valdir@gmail.com"); 
            Aluno aluno4 = new Aluno(4, "Letícia", "leticia@gmail.com");

            try // "Tente executar esse código"
            {
                curso.Matricular(aluno1); // Chama pelo metodo que criamos 
                curso.Matricular(aluno2); 
                curso.Matricular(aluno3);
                // Vai gerar uma exceção pq o limite é 3 
                curso.Matricular(aluno4); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            // LINQ - ORDENAÇÃO DE ALUNOS 
            List<Aluno> alunosOrdenados = curso.ObterAlunoOrdenados();
            Console.WriteLine("\nAlunos em ordem alfabética: ");

            foreach(Aluno aluno in alunosOrdenados)
            {
                Console.WriteLine(($"{aluno.Nome} - {aluno.Email}"));
            }


            // LINQ - ALUNOS QUE COMEÇAM COM A 
            List<Aluno> nomesA = curso.ObterAlunosComNomeA();
            Console.WriteLine("\nAlunos que começam com a letra A: ");

            foreach(Aluno aluno in nomesA)
            {
                Console.WriteLine(aluno.Nome); 
            }

            // LINQ - QNTDADE DE ALUNOS MATRICULADOS 
            Console.WriteLine("\nQuantidade de alunos matriculados: ");
            int quantidade = curso.QuantidadeAlunos();
            Console.WriteLine(quantidade);




            // EXEMPLOS DE OUTROS MÉTODOS QUE NÃO FORAM PEDIDOS

            // FirstOrDefault()
            Aluno alunoEncontrado = curso.BuscarAlunoPorNome("Lucas");

            if (alunoEncontrado != null)
            {
                Console.WriteLine("\nAluno encontrado:");
                Console.WriteLine($"{alunoEncontrado.Nome} - {alunoEncontrado.Email}");
            }
            else
            {
                Console.WriteLine("\nAluno não encontrado.");
            }

            // ANY
            bool existe = curso.ExisteAluno("Ana Bia");

            Console.WriteLine($"\nExiste Ana Bia? {existe}");


            // SELECT 
            List<string> emails = curso.ObterEmails();

            Console.WriteLine("\nLista de e-mails:");

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }



            Console.WriteLine("\nAlunos matriculados: "); 

            foreach(Aluno aluno in curso.Alunos) // Percorre toda a lista de alunos
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.Email}");
            }

            Console.ReadKey(); // serve para pausar a execução quando o usuário apertar alguma tecla 
        }
    }
}

// MÉTODOS!!!! 
// Where() -> Filtrar 
// OrderBy() -> Ordem crescente 
// OrderByDescending() -> Ordem decrescente 
// FirstOrDefault() -> Procurar o primeiro que atende a condição 
// Count() -> Contar 
// Any() -> Existe? 
// Select() -> Selecionar apenas um campo 