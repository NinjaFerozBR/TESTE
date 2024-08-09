// faça um prorama que o usuario digite quantos quilos um atleta levantou e pergunte seu nome
// No final mostre quem ficou com ouro,prata e bronze
// O programa perguntara o peso e o nome ate que alguem peça para o programa calcular o resultado

double pesoOuro = 0;
double peso;
string nomeOuro = "";
string nome;
bool validador = false;
string resposta;

Console.WriteLine("Digite o nome do atleta");
nome = Console.ReadLine();
Console.WriteLine("Digite o peso levantado");
peso = Convert.ToDouble(Console.ReadLine());

while (validador == false)
{
    if (pesoOuro < peso)
    {
        pesoOuro = peso;
        nomeOuro = nome;
    }
    Console.WriteLine("Gostaria de inserir dados de outro atleta? Sim ou não");
    resposta = Console.ReadLine().ToLower();
    if (resposta == "não" || resposta == "nao")
    {
        validador = true;
    }
    else
    {
        Console.WriteLine("Digite o nome do atleta");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o peso levantado");
        peso = Convert.ToDouble(Console.ReadLine());
    }
}
Console.WriteLine("Atleta que recebeu ouro: " + nomeOuro);
Console.WriteLine("Peso que ele levantou: " + pesoOuro + "kg");