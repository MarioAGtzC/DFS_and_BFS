using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph('S', true);
            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('A', 'D');
            graph.AddEdge('B', 'E');
            graph.AddEdge('B', 'F');
            graph.AddEdge('B', 'G');
            graph.AddEdge('C', 'G');
            graph.AddEdge('D', 'H');
            graph.AddEdge('D', 'I');
            graph.AddEdge('E', 'J');
            graph.AddEdge('E', 'K');
            graph.AddEdge('E', 'L');
            graph.AddEdge('F', 'A');
            graph.AddEdge('F', 'L');
            graph.AddEdge('G', 'H');
            graph.AddEdge('G', 'M');
            graph.AddEdge('G', 'N');
            graph.AddEdge('H', 'A');
            graph.AddEdge('H', 'O');
            graph.AddEdge('H', 'P');
            graph.AddEdge('I', 'P');
            graph.AddEdge('I', 'R');

            Console.Write("DFS and BFS from A:\n");
            Console.Write("DFS: ");
            graph.DFS('A');
            Console.Write("\nBFS: ");
            graph.BFS('A');
            Console.ReadLine();
        }
    }
}
