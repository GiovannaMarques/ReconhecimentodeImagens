using System;
using System.IO;
using System.Drawing;
using System.Data;



namespace ReconhecimentoCsharp
{
    public class Program
    {
        // 1. Ler imagem da pasta
        // 2. Se a imagem estiver em jpg, jpeg ou png 

        static void Main(string[] args)
        {
            string[] arquivosjpeg = Directory.GetFiles("C:\\Users\\giovanna.marques\\2. Csharp\\ImagensTeste", "*.jpeg", SearchOption.AllDirectories);

            Console.WriteLine("\n Arquivos nas extensões jpeg: \n");

            foreach (string arqjpeg in arquivosjpeg)
            {
                Console.WriteLine(arqjpeg);
            }

            string[] arquivosjpg = Directory.GetFiles("C:\\Users\\giovanna.marques\\2. Csharp\\ImagensTeste", "*.jpg", SearchOption.AllDirectories);

            Console.WriteLine("\n Arquivos nas extensões jpg: \n");

            foreach (string arqjpg in arquivosjpg)
            {
                Console.WriteLine(arqjpg);
            }

            string[] arquivospng = Directory.GetFiles("C:\\Users\\giovanna.marques\\2. Csharp\\ImagensTeste", "*.png", SearchOption.AllDirectories);

            Console.WriteLine("\n Arquivos nas extensões png: \n ");

            foreach (string arqpng in arquivospng)
            {
                Console.WriteLine(arqpng);
            }
              
            Console.WriteLine("\n Arquivos nas extensões não validadas: \n ");
            string arquivosnaovalidados = "*.pdf,*.gif,*.bmp,*.wmf,*.emf,*.xbm,*.ico,*.eps,*.tif,*.tiff,*.g01,*.g02,*.g03,*.g04,*.g05,*.g06,*.g07,*.g08";

            foreach (string arqnaoval in Directory.GetFiles("C:\\Users\\giovanna.marques\\2. Csharp\\ImagensTeste", "*.*", SearchOption.AllDirectories).Where(s => arquivosnaovalidados.Contains(Path.GetExtension(s).ToLower())))

            {
                Console.WriteLine(arqnaoval);

            }
        }
    }
}






