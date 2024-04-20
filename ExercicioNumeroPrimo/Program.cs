int numero;
bool primoOuNao = true;

Console.Write("Digite um número maior que 1 para saber se ele é primo ou não: ");
numero = int.Parse(Console.ReadLine());


while (numero <= 1)
{
    Console.Write("Precisa ser maior que 1!!!: ");
    numero = int.Parse(Console.ReadLine());
}

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0 && numero != 2)
    {
        primoOuNao = false;
        break;
    }
}

if (primoOuNao == true)
{
    Console.WriteLine($"O número {numero} é primo");
}
else
{
    Console.WriteLine($"O número {numero} não é primo");
}
