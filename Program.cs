Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");

int Opcao = 0;

while (Opcao != 5)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1-Adição");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multiplicação");
    Console.WriteLine("4-Divisão");
    Console.WriteLine("5-Sair");

    Console.Write("Digite a opção: ");
    Opcao = int.Parse(Console.ReadLine());

    if (Opcao >= 1 && Opcao <= 4)
    {
        Console.Write("Digite o primeiro número: ");
        double PrimeiroNumero = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double SegundoNumero = double.Parse(Console.ReadLine());

        switch (Opcao)
        {
            case 1:
                Console.WriteLine("Resultado: " + (PrimeiroNumero + SegundoNumero));
                break;

            case 2:
                Console.WriteLine("Resultado: " + (PrimeiroNumero - SegundoNumero));
                break;

            case 3:
                Console.WriteLine("Resultado: " + (PrimeiroNumero * SegundoNumero));
                break;

            case 4:
                if (SegundoNumero == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                else
                {
                    Console.WriteLine("Resultado: " + (PrimeiroNumero / SegundoNumero));
                }
                break;
        }
    }
    else if (Opcao == 5)
    {
        Console.WriteLine("Encerrando...");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}