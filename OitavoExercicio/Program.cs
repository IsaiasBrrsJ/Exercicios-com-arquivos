namespace OitavoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#\TREINO ARQUIVOS\SetimoExercicio\Alunos.txt";
            double mediaGeralTurma = 0;
            int contLinhas = 0;

            /*
             Faça um programa que leia os dados gerados pelo programa anterior do exercício 6 e mostre na tela as informações referentes aos alunos,
             calculando também a média geral da turma. LEMBRETE: É bem mais fácil armazenar informações em arquivos do tipo texto,
             colocando um dado em cada linha 
            (“imitando” a entrada de dados do teclado: dado <enter>, dado <enter>, dado <enter> ...).
            */

            try
            {
                StreamReader sr = new StreamReader(path);

                string linha = sr.ReadLine();

                while(linha != null)
                {
                    string[] media = linha.Split(": ");
                    mediaGeralTurma += float.Parse(media[4]);
                   
                    contLinhas++;
                    Console.WriteLine(linha);

                    linha = sr.ReadLine();
                }

                Console.WriteLine("\nMédia geral: " + (mediaGeralTurma / contLinhas).ToString("F1"));


                Console.ReadKey();
            }catch(Exception ex) { }
        }
    }
}