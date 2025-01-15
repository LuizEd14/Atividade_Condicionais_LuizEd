Console.WriteLine("Insira qualquer número entre 1 e 7 abaixo:");
int num = int.Parse(Console.ReadLine());

Console.Clear();

if (num == 7) {
    Console.WriteLine("Sábado");
} else if (num == 6) {
    Console.WriteLine("Sexta-Feira");
} else if (num == 5) {
    Console.WriteLine("Quinta-Feira");
} else if (num == 4) {
    Console.WriteLine("Quarta-Feira");
} else if (num == 3) {
    Console.WriteLine("Terça-Feira");
} else if (num == 2) {
    Console.WriteLine("Segunda-Feira");
} else if (num == 1) {
    Console.WriteLine("Domingo");
} else {
    Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
}

//Correto, mas bruto