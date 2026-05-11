// Caminho completo do arquivo
// @ permite escrever barras sem precisar usar \\
// Exemplo sem @:
// "c:\\Tecnicas-programacaoII\\tecnicas\\arquivo1.txt"
var caminho = @"c:\Tecnicas-programacaoII\tecnicas\arquivo1.txt";



// Verifica se o arquivo NÃO existe
if (!File.Exists(caminho))
{
    // Cria o arquivo e escreve o texto inicial
    File.WriteAllText(caminho, "Autor Desconhecido");
}



// Cria uma string com novas linhas de texto

// \r\n = quebra de linha manual do Windows
// Environment.NewLine = quebra de linha automática do sistema operacional

var novoTexto =
    "\r\nQuem canta seus males espanta"
    + Environment.NewLine
    + "Água mole em pedra dura tanto bate até que fura\r\nCasa de ferreira espeto é";



// Lê todo o conteúdo do arquivo
string conteudo = File.ReadAllText(caminho);



// Exibe o conteúdo do arquivo
Console.WriteLine(conteudo);