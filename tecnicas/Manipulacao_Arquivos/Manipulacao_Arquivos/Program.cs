var caminho = @"c:\Tecnicas-programacaoII\tecnicas\arquivo1.txt";
if (!File.Exists(caminho))
{
    File.WriteAllText(caminho, "Autor Desconhecido"); 
}

var novoTexto = "\r\nQuem canta seus males espanta" + Environment.NewLine + "Água mole em pedra dura tanto bate até que fura\r\nCasa de ferreira espeto é";
string conteudo = File.ReadAllText(caminho);
Console.WriteLine(conteudo);