using System;

namespace Caso_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A=Casa\nB=Trabajo\nC=Casa de tíos\nD=Casa abuelos\nE=Casa amigo 1\nF=Casa amigo 2\nG=Universidad\n");
            string[] puntos = new string[7]
            {    
                "A","B","C","D","E","F","G"
            };

            int[,] graph_1 =  {
                          { 0,  5, 16, 17,  0,  0,  6 },
                          { 7,  0,  6, 15,  8,  0,  9 },
                          { 0,  0,  0, 10,  0,  7,  0 },
                          { 6,  5,  0,  0,  1,  0, 25 },
                          { 0, 10,  0,  0,  0,  4,  7 },
                          { 0,  0, 14,  0,  0,  0, 12 },
                          { 0,  0,  0,  0,  0,  0,  0 }
            };

            Console.WriteLine("\nAlgoritmo Dijkstra: Distancias mínimas de casa a los demás puntos\n");
            Dijkstra.DijkstraAlgo(graph_1, 0, 7, puntos);

            const int INF = 99999;

            int[,] graph_2 = {
                       {   0,   5,  16,  17, INF, INF,   6 },
                       {   7,   0,   6,  15,   8, INF,   9 },
                       { INF, INF,   0,  10, INF,   7, INF },
                       {   6,   5, INF,   0,   1, INF,  25 },
                       { INF,  10, INF, INF,   0,   4,   7 },
                       { INF, INF,  14, INF, INF,   0,  12 },
                       { INF, INF, INF, INF, INF, INF,   0 }
            };

            Console.WriteLine("\nAlgoritmo Floyd-Warshall: Distancias mínimas entre cada par de puntos\n");
            FloydWarshall.FloydWarshallAlgo(graph_2, 7, puntos);

            int[,] graph_3 = {
                          {  0,  5, 16,  6,  0,  0,  6 },
                          {  5,  0,  6,  5,  8,  0,  9 },
                          { 16,  6,  0, 10,  0,  7,  0 },
                          {  6,  5, 10,  0,  1,  0, 25 },
                          {  0,  8,  0,  1,  0,  4,  7 },
                          {  0,  0,  7,  0,  4,  0, 12 },
                          {  6,  9,  0, 25,  7, 12,  0 }
            };

            Console.WriteLine("\nAlgoritmo PRIM: Recorrido de mínima distancia que pase por todos los puntos\n");
            Prim.PrimAlgo(graph_3, 7, puntos);

            Console.ReadKey();
        }
    }
}
