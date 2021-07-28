using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis
{
    class Program
    {
        #region enum
        enum Notas
        {
            Minimo = 10, 
            Media = 20,
            Maxima = 30,w
        }
        #endregion

        static void Main(string[] args)
        {
            #region Inteiros
            /*int valor = 20;
            int num = 40;

            //valor = 35;

            Console.WriteLine(valor);
            Console.WriteLine(num);
            Console.ReadKey();*/
            #endregion

            #region Reais
            /*  double real1, real2, soma;

              real1 = 100.05f;
              real2 = 50.54;

              soma = real1 + real2;

              Console.Write("O resultado da soma é   ", soma);
              Console.WriteLine(soma);
              Console.ReadKey();          */
            #endregion

            #region Tipos de Reais 

            /* float real1 = 100.75f;
             double real2 = 12500.45;
             decimal real3 = 752.45m;

             Console.WriteLine("");
             Console.ReadKey();
                                    */
            #endregion

            #region char

            /*char letra = '\u0061'; // Somente aspas simples
            char escape = '\n';   // Qualquer Caracter especial, mas somente 1 caracter
            char literal = 'C';  // Pode colocar o formato binário colocando "\u(codigo)"


            Console.WriteLine(letra);
            Console.ReadKey();*/
            #endregion

            #region bool


            /*bool verificar = false;
            verificar = true;



            Console.WriteLine(verificar);
            Console.ReadKey();*/
            #endregion

            #region String

            /* string texto = @"Gabriel Artigas \n 1985 @@@???::$$"; //iniciando a string com "@" ele ignora os char de escape
             string mensagem = null;
             mensagem = texto; 

             Console.WriteLine(mensagem);
             Console.ReadKey();*/

            #endregion

            #region Var
            /* // o uso da variavel VAR, pode ser usado em qualquer tipo de tipo e valor
             var valor = 100;
             valor = 20;
             valor = "Gabriel"

             Console.WriteLine();
             Console.ReadKey();*/

            #endregion

            #region Object Tipo implícito VAR

            // aceita qualquer tipo de valor
            /*object obj = 100;
            obj = "String";
            obj = 155.55;


            Console.WriteLine();
            Console.ReadKey();*/
            #endregion

            #region Constantes

            const double pi = 3.1415;
            const string nome = "Gabriel";

            Console.WriteLine(pi);
            Console.ReadKey();

            #endregion

            #region Enum
            //podem ser definidos qualquer valor
            // enum sempre colocado na raiz da classe

            Notas notasalunos = Notas.Media;

            Console.WriteLine();
            Console.ReadKey();

            #endregion



        }


    }
}
