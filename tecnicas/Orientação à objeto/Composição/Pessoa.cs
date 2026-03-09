
namespace Composição
{

    class Pessoa
    {
        public Pessoa(string nome, int ddd, string numero)
        {
            Nome = nome;
            Celulares.Add(new Celular(ddd, numero));
        }

        // construtor apenas com nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public void SetCelular(int ddd, string numero)
        {
            Celulares.Add(new Celular(ddd, numero));
        }

        public string? Nome { get; set; }

        public List<Celular> Celulares = new List<Celular>();
    }

    class Celular
    {
        public Celular(int ddd, string numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public Celular(int ddd, string numero, Pessoa pessoa)
        {
            DDD = ddd;
            Numero = numero;
            ProprietarioCelular = pessoa;
        }

        public int DDD { get; set; }
        public string Numero { get; set; }

        public Pessoa ProprietarioCelular { get; set; }
    }
}