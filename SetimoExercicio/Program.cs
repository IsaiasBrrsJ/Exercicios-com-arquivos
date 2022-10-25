using System.Net;

namespace SetimoExercicio
{
    internal class Program
    {   
        struct Aluno
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double media;
        }
        static void Main(string[] args)
        {
            Aluno[] aluno = new Aluno[4];
            /*
             Faça um programa que leia (do teclado) um cadastro de 10 alunos, indicando o nome, nota1, nota2.
             Calcule a média aritmética simples dos 10 alunos e depois escreva em um arquivo texto os dados de cada aluno: nome, nota1, nota2 e média.
             Lembre-se de que as notas e média deverão ser apresentadas como valores que possuem até 2 casas após a vírgula.
            */
            string path = @"D:\C#\TREINO ARQUIVOS\SetimoExercicio\Alunos.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1} aluno: ");
                aluno[i].nome = Console.ReadLine();

                Console.WriteLine("Digite a primeira nota: ");
                aluno[i].nota1 = double.Parse(Console.ReadLine().Replace(".",","));

                Console.WriteLine("Digite a segunda nota: ");
                aluno[i].nota2 = double.Parse(Console.ReadLine().Replace(".", ","));

                aluno[i].media = (aluno[i].nota1 + aluno[i].nota2) / 2;

                writer.WriteLine($"Aluno: {aluno[i].nome} Nota1: {aluno[i].nota1.ToString("F1")} Nota2: {aluno[i].nota2.ToString("F1")} Média: {aluno[i].media.ToString("F1")}");
                writer.Flush();
            }

            writer.Close();



        }
    }
}