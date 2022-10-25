namespace SextoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um algoritmo para ler um arquivo contendo as temperaturas médias de todos os dias do ano (criado no item anterior)
             e armazene as mesmas em um vetor. Na sequência, a partir desse vetor, calcular e escrever: 
             Menor temperatura do ano 
             Maior temperatura do ano 
             Temperatura média anual 
             O número de dias no ano em que a temperatura foi inferior a média anual
             */

            string path = @"D:\C#\TREINO ARQUIVOS\QuintoExercicio\temperaturas.txt";
            float maiorTemperaturaAno = 0;
            float menorTemperatura = 0;
            float mediaTemperaturaAnual = 0;
            int diasQueATemperaturaFoiInferiorAMediaAnual =0;
            float teste = 0;
            int contDias = 1;

            try
            {
                StreamReader reader = new StreamReader(path);
                string linha = reader.ReadLine();

                while(linha != null)
                {
                    string[] split = linha.Split(' '); // split para pegar apenas a temperatura.
                    float temp = float.Parse(split[1]);

                    if(temp > maiorTemperaturaAno)
                    {
                        maiorTemperaturaAno = temp;
                    }

                    if(menorTemperatura == 0)
                    {
                        menorTemperatura = temp;
                    }
                    else
                    {
                        if(menorTemperatura > temp)
                        {
                            menorTemperatura = temp;
                        }
                    }

                    mediaTemperaturaAnual += temp;
                    contDias++;

                    linha = reader.ReadLine();
                }
                reader.Close();

            }
            catch (Exception ex) { }

            try
            {
                StreamReader read = new StreamReader(path);
                string linhaR = read.ReadLine();
                mediaTemperaturaAnual /= contDias;
                while(linhaR != null)
                {
                    string[] split = linhaR.Split(' ');
                    float temp = float.Parse(split[1]);

                    if(temp < mediaTemperaturaAnual)
                    {
                        diasQueATemperaturaFoiInferiorAMediaAnual++;
                    }

                    linhaR = read.ReadLine();

                }

                read.Close();
            }catch (Exception ex) { }


            Console.WriteLine("Maior temperatura do ano: "+ maiorTemperaturaAno.ToString("0.0"));
            Console.WriteLine("Menor temperatura do ano: "+menorTemperatura.ToString("0.0"));
            Console.WriteLine("Média de temperatura anual: "+mediaTemperaturaAnual.ToString("0.0"));
            Console.WriteLine("Quantidade de dias que a temperatura foi menor que a média anual: "+ diasQueATemperaturaFoiInferiorAMediaAnual);
            
            Console.ReadKey();

        }
    }
}