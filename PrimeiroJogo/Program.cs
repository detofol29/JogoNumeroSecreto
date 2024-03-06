Random numeroAleatorio = new Random();
int numeroSecreto = numeroAleatorio.Next(1, 100);
int rodadas = 1;
do{
    Console.WriteLine("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        
        Console.WriteLine("Parabéns, você acertou o número!");
        Console.WriteLine($"Acertou com {rodadas} tentativas.");
        break;
    }else if(chute < numeroSecreto)
    {
        Console.Clear();
        Console.WriteLine("O número secreto é maior");
        rodadas++;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("O número secreto é menor");
        rodadas++;
    }
}while(true);


