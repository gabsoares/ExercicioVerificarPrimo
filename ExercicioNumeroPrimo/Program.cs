int numero = 0;
bool primoOuNao = true;

while (numero <= 1)
{
    Console.Write("Digite um número maior que 1 para saber se é primo ou não: ");
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
