Console.WriteLine("Insira a nota média do aluno abaixo:");
int num = int.Parse(Console.ReadLine());

Console.Clear();

if (num >= 6) {
    Console.WriteLine("Aluno aprovado.");
} else {
    Console.WriteLine("Aluno reprovado.");
}

//Correto