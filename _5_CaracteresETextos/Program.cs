// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e textos");

            /*  char primeiraLetra = 'a';

              Console.WriteLine(primeiraLetra);

              primeiraLetra = (char)61;
              Console.WriteLine(primeiraLetra);

              primeiraLetra = (char)(primeiraLetra + 1);
              Console.WriteLine(primeiraLetra);

              string titulo = "Alura Cursos de Tecnologia" + 2022;
              /* string cursosProgramacao = @" - .Net
                   - Java
                   - JavaScript"; */

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;                    // Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);          // Compila!
            Console.WriteLine(valor);

            //Console.WriteLine(titulo);
            //Console.WriteLine(cursosProgramacao);

            string vazia = "";
            Console.WriteLine(vazia);


            valor = (char)(valor + 1);         // Compila!
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

        }
    }
}
