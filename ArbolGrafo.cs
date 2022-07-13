using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1
{
    internal class ArbolGrafo
    {
        public NodoGrafo Raiz { get; set; }
        public ArbolGrafo()
        {
            Raiz = null;
        }
        public void Agregar(NodoGrafo n)
        {
            NodoGrafo nodo = new NodoGrafo(n.Info);
            Raiz = AgregarW(nodo, Raiz);
        }

        public NodoGrafo AgregarW(NodoGrafo ng, NodoGrafo raiz)
        {
            if (raiz == null)
            {
                raiz = ng;
            }
            else if(ng.Info < raiz.Info)
            {
                raiz.NodoIzq = AgregarW(ng, raiz.NodoIzq);
            }
            else
            {
                raiz.NodoDer = AgregarW(ng, raiz.NodoDer);

            }
            return raiz;
        }

        
        public int Imprimir(NodoGrafo ng)
        {
            if (ng == null)
            {
                return 0;
            }

            //  [Izq | Info | Der ]
            string  cad = string.Format("[{0}|{1}|{2}]", 
                    ng.NodoIzq == null ?"null": ng.NodoIzq.Info.ToString(),
                    ng.Info,
                    ng.NodoDer == null ?"null": ng.NodoDer.Info.ToString());
           
            Console.WriteLine(cad);
            Imprimir(ng.NodoIzq);
            Imprimir(ng.NodoDer);
            return 0;

        }

        // Implementar un algoritmo de busqueda en arboles binarios
        public NodoGrafo Buscar(int buscar)
        {
            NodoGrafo ng = null;
            return ng;
        }
        public void buscar(int x, NodoGrafo t)
        {
            if (t != null)
            {
                if (x < t.Info)
                {
                    buscar(x, t.NodoIzq);
                }
                else
                {
                    if (x > t.Info)
                    {
                        buscar(x, t.NodoDer);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nodo no encontrado en el arbol", "Error de busqueda");
            }
            
        }
        
    }

}
