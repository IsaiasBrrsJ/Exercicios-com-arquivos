using System.Reflection.Metadata.Ecma335;

namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que receba do usuário um arquivo texto e mostre na tela quantas letras são vogais e quantas são consoantes.
            */
            string caminho = @"D:\C#\TREINO ARQUIVOS\PrimeiroExercicio\Alfabeto.txt";
            StreamReader reader = new StreamReader(caminho);

            int contVogais = 0;
            int contConsoantes = 0;
            List<string> vogais = new List<string>();
            List<string> consonates = new List<string>();

            string linha = reader.ReadLine();
            
            while (linha != null) // primeira linha do arquivo
            {
                int count = 0;
                while (true) 
                {
                    string palavra;
                    try
                    {
                        palavra = linha.Split(" ")[count];
                        string letraPorLetra = palavra.Replace(".","").Replace(",",""); // tira caracteres
                        int contador = 0;
                        while (true)
                        {   
                            if(contador == palavra.Length) { break; }

                            if (letraPorLetra[contador].ToString().ToLower() == "a" ||
                                letraPorLetra[contador].ToString().ToLower() == "e" ||
                                letraPorLetra[contador].ToString().ToLower() == "i" ||
                                letraPorLetra[contador].ToString().ToLower() == "o" ||
                                letraPorLetra[contador].ToString().ToLower() == "u" 
                                )
                            {
                                vogais.Add(letraPorLetra[contador].ToString());
                            }
                            else
                            {
                                if (letraPorLetra[contador].ToString().ToLower() != "H")
                                {
                                    consonates.Add(letraPorLetra[contador].ToString());
                                }
                            }

                            contador++;
                        }
                    }
                    catch
                    {
                        break;
                    }
                   count++;
                    
                }
               
                linha = reader.ReadLine();
            }

            reader.Close();
            reader.Dispose();

            Console.WriteLine("Vogais: "+ vogais.Count);
            Console.WriteLine("Consoantes: "+consonates.Count);

            Console.WriteLine("\n\nVOGAIS\n");
            foreach (var vogal in vogais)
            {
                Console.Write(vogal + " |");
            }

            Console.WriteLine("\n\nConsoantes\n");
            foreach (var consonate in consonates)
            {
                Console.Write(consonate + " |");
            }
            Console.ReadKey();
        }
    }
}