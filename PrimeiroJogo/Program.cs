Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 100);
////
do{
    Console.WriteLine("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns, você acertou o número!");
        break;
    }else if(chute < numeroSecreto)
    {
        Console.WriteLine("O número é menor");
    }
    else
    {
        Console.WriteLine("O número é maior");
    }
}while(true);


