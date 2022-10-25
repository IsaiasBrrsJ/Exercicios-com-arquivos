namespace QuintoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que crie um arquivo TEXTO em disco, com o nome “temperaturas.txt”, e escreva neste arquivo em disco
             uma contagem de todos os dias de um ano (365) e com uma temperatura aleatória em cada linha
             (o arquivo deverá estar no formato 99/99/9999 99,99).
             Abra este arquivo em um editor de textos, como por exemplo o Notepad ou o Wordpad do Windows. 
            */

            var ano = DateTime.Now.Year;
            bool eAnoBissexto = false;
            string path = @"D:\C#\TREINO ARQUIVOS\QuintoExercicio\temperaturas.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            StreamWriter writer = new StreamWriter(path);

            for (int mes = 1; mes <= 12; mes++)
            {
                for (int dia = 1; dia <= 31; dia++)
                {

                    writer.WriteLine($"{dia}/{mes}/{ano} {GeraTemperatura()}");

                    if ((ano % 4 ==0 && ano % 100 != 0) || ano % 400 == 0) // caso seja ano bisexto acrescenta mais um dia em fevereiro
                    {
                        eAnoBissexto = true;
                       if (dia == 29 && mes == 2)
                        {
                            break;
                        }
                    }

                    if((dia == 28 && eAnoBissexto == false) && mes == 2) { break;  } // caso não seja bissexto, fevereiro terá 28 dias.

                    if((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia == 30) // meses do ano que possuem 30 dias
                    {
                       
                        break;
                    }
                }
            }

            writer.Close();           
        }

        static string GeraTemperatura()
        {
            string temperatura = $"{new Random().Next(-100, 90)},{new Random().Next(0,60)}";


            return temperatura;
        }
    }
}