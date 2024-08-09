double numero;
int numero2;
bool validador = true;
while (validador == true)
{
    Console.Write("Digite um numero inteiro : ");
    numero = Convert.ToDouble(Console.ReadLine());
    numero2 = (int)numero;
    if (numero2 != numero)
    {
        Console.WriteLine("Erro ! Não é um numero inteiro");
    }
    else
    {
        validador = false;
    }
}
Console.Write("O numero é inteiro ");