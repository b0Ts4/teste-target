/*Deixarei todo o código no Program.cs para facilitar a leitura e não ser preciso ficar alterando entre diferentes pastas, 
  acredito que pela baixa complexidade do código não trará dificuldades no entendimento do código.
*/
string Questao01(int num)
{
    int n1 = 0, n2 = 1, n3 = 1;

    string positivo = "O número " + num + " está na sequência de fibonacci";
    string negativo = "O número " + num + " não está na sequência de fibonacci";

    if (num == 0) return positivo;
    while (n3 <= num)
    {
        if (num == n3) return positivo;

        int aux = n2;
        n2 = n3;
        n3 = n1 + aux;
        n1 = aux;
    }
    return negativo;
}

string Questao02(string str1)
{
    var str = str1.ToLower();
    int numA = 0;

    for(int i = 0; i < str1.Length; i++)
    {
        if (str[i] == 'a') numA++;
    }
    if (numA == 0) return "A string '" + str1 + "' não possui nenhuma letra A";
    return "A string '" + str1 + "' possui " + numA + " letra(s) A";
}

void Questao03()
{
    int INDICE = 12, SOMA = 0, K = 1;

    while(K < INDICE)
    {
        K++; 
        SOMA += K;
    }
    Console.WriteLine("Ao final do processo o valor de SOMA é " + SOMA);
}


void Questao04()
{
    Console.WriteLine("4) Descubra a lógica e complete o próximo elemento:");
    Console.WriteLine("a) 1, 3, 5, 7, ___ = 9");
    Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____ = 128");
    Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____ = 48");
    Console.WriteLine("d) 4, 16, 36, 64, ____ = 100");
    Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____ = 13");
    Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, ____ = 20");
}

void Questao05()
{
    Console.WriteLine("5)");
    Console.WriteLine("Ligaria somente uma lâmpada e iria olhar e anotar qual era.");
    Console.WriteLine("Depois desligaria ela e ligaria uma outra, iria ver e anotar.");
    Console.WriteLine("A lâmpada que sobrou só poderia ser do interruptor que eu não mexi.");
}

void menu()
{
    while (true)
    {
        Console.WriteLine("Escolha a questão que deseja ver a resposta:");
        Console.WriteLine("1 - Questão 01");
        Console.WriteLine("2 - Questão 02");
        Console.WriteLine("3 - Questão 03");
        Console.WriteLine("4 - Questão 04");
        Console.WriteLine("5 - Questão 05");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Questao01(num));
                break;

            case "2":
                Console.Write("Digite uma string: ");
                string str1 = Console.ReadLine();
                Console.WriteLine(Questao02(str1));
                break;

            case "3":
                Questao03();
                break;

            case "4":
                Questao04();
                break;

            case "5":
                Questao05();
                break;

            case "0":
                Console.WriteLine("Pense nas minhas respostas com carinho ;)");
                Console.WriteLine("Tchau tchau...");
                return;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }

        Console.WriteLine();
    }
}

menu();