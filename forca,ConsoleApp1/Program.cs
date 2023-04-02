namespace forca_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("**********************************\n");
            Console.WriteLine("  Bem vindo ao Jogo da Forca\n");
            Console.WriteLine("**********************************\n");
            Console.WriteLine("   _____");
            Console.WriteLine("  |     |");
            Console.WriteLine("  |     O");
            Console.WriteLine("  |    /|\\");
            Console.WriteLine("  |    / \\");
            Console.WriteLine("__|__\n"); ;
            //Console.WriteLine("Escolha uma palavra:");

            string[] palavra = { "abacate", "abacaxi", "acerola", "acai",
                "araca", "figo", "bacaba", "bacuri", "banana", "caja",
                "caju", "carambola", "cupuacu", "graviola",
                "goiaba", "jabuticaba", "jenipapo", "maca",
                "mangaba", "manga", "maracuja", "murici",
                "pequi", "pitanga", "pitaya", "sapoti", "tangerina", "umbu", "uva", "uvaia" };


            Random random = new Random();
            string novaPalavra = palavra[random.Next(palavra.Length)];
            string[] resultado = new string[novaPalavra.Length];





            //acertos, erros , verificação 
            int erros = 0, acertos = 0, checar = 0;

            // limpar
            Console.Clear();

            Console.WriteLine("Digite uma letra: ");
            while (erros != 5 && checar != resultado.Length)
            {
                char letra = char.Parse(Console.ReadLine());


                // verificar
                int ocorrencias = novaPalavra.IndexOf(letra);

                //erro 
                if (ocorrencias == -1)
                {
                    erros++;
                }
                //inremetar o acerto
                else
                {
                    acertos++;
                    //percorrer
                    for (int i = 0; i < novaPalavra.Length; i++)
                    {
                        if (novaPalavra[i].ToString() == letra.ToString())
                        {
                            //preencher a posição
                            resultado[i] = letra.ToString();
                            //
                            if (resultado[i] != null && resultado[i] != "_")
                            {
                                checar++;
                            }
                        }
                        //se não
                        else if (resultado[i] is null)
                        {
                            resultado[i] = "_";
                        }
                    }
                }
                //
                foreach (string item in resultado)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                //se erros
                if (erros == 5)
                {
                    Console.WriteLine("Vc foi enforcado");
                }
                //
                else if (checar == resultado.Length)
                {
                    Console.WriteLine("Vc Ganhou!");
                }
                else
                {
                    Console.WriteLine("Erros;{0}, Certos : {1}", erros, acertos);
                }

            }
        }
    }
}