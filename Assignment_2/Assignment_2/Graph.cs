using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Graph
    {
        private char _maxValue;
        private bool _directed;
        LinkedList<char>[] adjacency;

        public Graph(char maxValue, bool directed)
        {
            adjacency = new LinkedList<char>[maxValue];

            for (int i = 0; i < adjacency.Length; i++)
            {
                adjacency[i] = new LinkedList<char>();
            }

            _maxValue = maxValue;
            _directed = directed;
        }

        public void AddEdge(char vertex, char end)
        {
            adjacency[vertex].AddLast(end);

            if (!_directed)
            {
                adjacency[end].AddLast(vertex);
            }
        }

        public void DFS(char vertex)
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[_maxValue];

            for (int i = 0; i < _maxValue; i++)
                visited[i] = false;

            // Call the recursive helper function to print DFS traversal
            DFSUtil(vertex, visited);
        }

        private void DFSUtil(char vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            LinkedList<char> list = adjacency[vertex];

            foreach (var val in list)
            {
                if (!visited[val])
                    DFSUtil(val, visited);
            }
        }

        public void BFS(char s)
        {
            bool[] visited = new bool[_maxValue];
            for (int i = 0; i < _maxValue; i++)
                visited[i] = false;

            LinkedList<char> queue = new LinkedList<char>();

            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                LinkedList<char> list = adjacency[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

    }
}


