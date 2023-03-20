using System.Threading.Channels;

namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira uma letra Maiúscula para determinar o diamante (Exemplo = A): ");
            string entradaUsuario = Console.ReadLine();
            char letraInformada = char.Parse(entradaUsuario);

            char letraA = 'A';
            
            int quantidadeDeLinhas = letraInformada - letraA;

            int espacosDaMargem = letraInformada - letraA;

            int espacosEntreAsLetras = -1;

            char letra = 'A';
            //Inicio diamante
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                
                for (int i = 0; i < espacosDaMargem; i++)
                {
                    Console.Write(' ');

                }

                Console.Write(letra);
                
                for (int i = 0; i < espacosEntreAsLetras; i++)
                {
                    Console.Write(' ');
                }
                
                if (letra != 'A')
                    Console.Write(letra);

                letra++;
                espacosDaMargem--;
                espacosEntreAsLetras += 2;

                Console.WriteLine();
            }

            Console.Write(letraInformada);
            
            //Meio diamante

            for (int i = 0; i < espacosEntreAsLetras; i++)
            {
                Console.Write(' ');
            }
            Console.Write(letraInformada);
            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;
            Console.WriteLine();
            //Parte de baixo diamante

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {

                for (int i = 0; i < espacosDaMargem; i++)
                {
                    Console.Write(' ');

                }

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                {
                    Console.Write(' ');
                }

                if (letra != 'A')
                    Console.Write(letra);

                letra--;
                espacosDaMargem++;
                espacosEntreAsLetras -= 2;

                Console.WriteLine();
            }

        }

    }
}


