namespace Composição
{

    class Pessoa
    {
        public Pessoa(string nome, int ddd, string numero)
        {
            Nome = nome;

            // Cria celular junto da pessoa
            Celulares.Add(new Celular(ddd, numero));
        }

        // construtor apenas com nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public void SetCelular(int ddd, string numero)
        {
            // Adiciona novo celular na lista
            Celulares.Add(new Celular(ddd, numero));
        }

        public string? Nome { get; set; }

        // Lista de celulares da pessoa
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

            // Define dono do celular
            ProprietarioCelular = pessoa;
        }

        public int DDD { get; set; }

        public string Numero { get; set; }

        // Pessoa dona do celular
        public Pessoa ProprietarioCelular { get; set; }
    }
}