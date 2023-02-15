double nota1,nota2,nota3,media;

Console.WriteLine("Digite a 1° nota:");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a 2° nota:");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a 3° nota:");
nota3 = double.Parse(Console.ReadLine());

media = (nota1+nota2+nota3)/3;

if(media >= 6){
    Console.WriteLine($"Aluno Aprovado com média: {media}");
}
if(media >= 5 && media < 6){
    Console.WriteLine($"Aluno em Recuperação com média: {media}");
}
if(media < 5){
    Console.WriteLine($"Aluno Reprovado com média: {media}");
}
