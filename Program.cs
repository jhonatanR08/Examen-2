using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo arbol binario");
            ArbolGrafo arbol = new ArbolGrafo();
            arbol.Agregar(new NodoGrafo(5));
            arbol.Agregar(new NodoGrafo(4));
            arbol.Agregar(new NodoGrafo(3));
            arbol.Agregar(new NodoGrafo(2));
            arbol.Agregar(new NodoGrafo(1));
            arbol.Agregar(new NodoGrafo(16));
            arbol.Agregar(new NodoGrafo(8));
            arbol.Agregar(new NodoGrafo(6));
            arbol.Agregar(new NodoGrafo(9));
            arbol.Agregar(new NodoGrafo(22));
            arbol.Agregar(new NodoGrafo(17));
            arbol.Agregar(new NodoGrafo(25));
            arbol.Agregar(new NodoGrafo(23));

            arbol.Imprimir(arbol.Raiz);

            Console.WriteLine("Ingrese elemento a buscar ");
            int x = int.Parse(Console.ReadLine());
            NodoGrafo nb = arbol.Buscar(x);
            Console.WriteLine("Encontrado ");
            Console.WriteLine(NodoDer + "|" + x +"|"+ NodoIzq);

            Console.WriteLine();
            Console.ReadLine();
        }


        public static object NodoDer { get; set; }

        public static int NodoIzq { get; set; }
    }
}
