Console.WriteLine("Insira sua idade abaixo:");
int num = int.Parse(Console.ReadLine());

Console.Clear();

if (num >= 16) {
    Console.WriteLine("Você pode votar.");
} else {
    Console.WriteLine("Você não pode votar.");
}

//Correto