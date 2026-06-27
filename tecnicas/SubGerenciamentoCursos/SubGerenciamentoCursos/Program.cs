

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
            Aluno aluno2 = new Aluno(2, "Márcia", "marcia@gmail.com"); 
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

            Console.WriteLine("\nAlunos matriculados: "); 

            foreach(Aluno aluno in curso.Alunos) // Percorre toda a lista de alunos
            {
                Console.WriteLine($"{aluno.Nome} - {aluno.Email}");
            }

            Console.ReadKey();
        }
    }
} 

// FALTA FAZER AS CONSULTAS (LINQ)