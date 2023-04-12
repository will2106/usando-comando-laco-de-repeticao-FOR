//escreva um programa que receba e imprima o nome e idade de 5 pessoas.
//personalizar cores: a resposta do nome em azul e a resposta idade em verde.









//declarando variaveis
string [] nome = new string [5];

int[]idade= new int[5];



//entradas de nome e idade
for (int i = 0; i <5; i++)
{
    
  Console.WriteLine($" Qual o seu nome? {i+1}º nome: "); // pergunta feita ao usuario,  a variavel 
  nome [i] = Console.ReadLine();//a resposta sera armazenada na variavel array "nome".
   
   Console.WriteLine($" Qual o sua idade? {i+1}º idade: ");// pergunta  a idade do usuario que comeca com zero
   idade [i] = int.Parse(Console.ReadLine()); //armazena a resposta na variavel do tipo array "idade" e a  funcao .Parse converte a resposta que era uma string agora sera do tipo inteiro

}

for (var posicao = 0; posicao < 5; posicao++) // O loop  FOR sera executado 5 vezes perguntando e armazenando o nome  e a idade dentro das variaveis "nome"  e "idade"
{
  
  //saida

Console.ForegroundColor = ConsoleColor.Blue;// esssa funcao define a cor de fundo do console nesse caso foi definido que nome sera azul
Console.WriteLine($"{posicao +1}) nome: {nome[posicao]}");// mostra na tela o nome escrito pelo usuario a aprtir do 1º nome  e a posicao ou seja se e primeiro segundo e etc.
Console.ResetColor();// essa funcao reseta a cor original
Console.WriteLine($"");// mostra um espacao vazio


Console.ForegroundColor = ConsoleColor.Green;// esssa funcao define a cor de fundo do console nesse caso foi definido que nome sera verde
Console.WriteLine($"{posicao +1}) idade: {idade[posicao]}");// mostra na tela a idade escrita pelo usuario a aprtir do 1º idade e a posicao que inicia ou seja se e primeiro segundo e etc.
Console.ResetColor();
Console.WriteLine($"");


}





