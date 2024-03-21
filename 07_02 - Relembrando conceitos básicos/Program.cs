var texto = "@bcde";
var valores = new string[] { "Ana", "20" };
// Substituir um caractere desejado
var textoCorrigido = Formatar(texto, valores);

Console.WriteLine(textoCorrigido);
// Função para realizar o teste do .Format
string Formatar(string texto, string[] valores)
{
    for (int i = 0; i < valores.Length; i++)
    {
        texto = texto.Replace("{" + i + "}", valores[i]);
    }
    return texto;
}

var nome = "Fernando";
var idade = 21;
// Armazenar a string através do método format
var texto1 = string.Format("Nome: {0}, Idade: {1}", nome, idade); 

// Interpolação de strings 

var nome1 = "Fernando";
var sobrenome = "Zuchi";
var nomeCompleto = $"Nome: {nome} {sobrenome}";
Console.Write(nomeCompleto);