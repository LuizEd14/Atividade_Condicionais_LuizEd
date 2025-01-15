Console.WriteLine("Insira qualquer número que esteja entre 1 a 100 abaixo:");
int num = int.Parse(Console.ReadLine());

Console.Clear();

if (num >= 1 && num <= 100) {
    Console.WriteLine("Está entre 1 e 100.");
} else {
    Console.WriteLine("Não está entre 1 e 100.");
}

//Corrigido, mas correto