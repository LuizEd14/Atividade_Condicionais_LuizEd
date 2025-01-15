Console.WriteLine("Insira qualquer número abaixo:");
int num = int.Parse(Console.ReadLine());

Console.Clear();

if (num > 0) {
    Console.WriteLine("O número escolhido é positivo");
} else if (num == 0) {
    Console.WriteLine("O número escolhido é neutro");
} else {
    Console.WriteLine("O número escolhido é negativo");
}

//Correto