using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Caso_2
{
    internal class FloydWarshall
    {
        public const int INF = 99999;

        private static void Imprimir(int[,] distancia, int TotalVertices, string[] puntos)
        {
            Console.Write("Punto: \t");

            for (int i = 0; i < TotalVertices; ++i)
                Console.Write(puntos[i] + "\t");

            Console.WriteLine("");

            for (int i = 0; i < TotalVertices; ++i)
            {
                Console.Write(puntos[i] + "\t");

                for (int j = 0; j < TotalVertices; ++j)
                {
                    if (distancia[i, j] == INF)
                        Console.Write("-\t");
                    else
                        Console.Write(distancia[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        public static void FloydWarshallAlgo(int[,] grafo, int TotalVertices, string[] lugares)
        {
            int[,] distancia = new int[TotalVertices, TotalVertices];

            for (int i = 0; i < TotalVertices; ++i)
                for (int j = 0; j < TotalVertices; ++j)
                    distancia[i, j] = grafo[i, j];

            for (int k = 0; k < TotalVertices; ++k)
            {
                for (int i = 0; i < TotalVertices; ++i)
                {
                    for (int j = 0; j < TotalVertices; ++j)
                    {
                        if (distancia[i, k] + distancia[k, j] < distancia[i, j])
                            distancia[i, j] = distancia[i, k] + distancia[k, j];
                    }
                }
            }

            Imprimir(distancia, TotalVertices, lugares);
        }
    }
}
