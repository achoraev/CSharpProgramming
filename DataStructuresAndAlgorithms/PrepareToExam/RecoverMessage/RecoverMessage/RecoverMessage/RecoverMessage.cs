namespace RecoverMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RecoverMessage
    {
        static SortedDictionary<char, Node> graph = new SortedDictionary<char, Node>();

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var noIncomingEdges = new SortedSet<char>();

            for (int i = 0; i < N; i++)
            {
                string message = Console.ReadLine();
                Node previousNode = GetNodeByChar(message[0]);
                for (int j = 1; j < message.Length; j++)
                {
                    Node currentNode = GetNodeByChar(message[j]);

                    previousNode.Successor.Add(currentNode);
                    currentNode.Parents.Add(previousNode);

                    previousNode = currentNode;
                }
            }

            foreach (var node in graph.Values)
            {
                if (node.Parents.Count == 0)
                {
                    noIncomingEdges.Add(node.Value);
                }
            }

            var result = new List<char>();

            // topological sort algorithm
            while (noIncomingEdges.Count > 0)
            {
                var currentSymbol = noIncomingEdges.Min;
                noIncomingEdges.Remove(currentSymbol);

                result.Add(currentSymbol);

                var currentNode = graph[currentSymbol];
                var childrens = currentNode.Successor.ToList();

                foreach (var child in childrens)
                {
                    child.Parents.Remove(currentNode);
                    currentNode.Successor.Remove(child);

                    if (child.Parents.Count == 0)
                    {
                        noIncomingEdges.Add(child.Value);
                    }

                }
            }

            Console.WriteLine(string.Join("", result));
        }

        public static Node GetNodeByChar(char symbol)
        {
            if (graph.ContainsKey(symbol))
            {
                return graph[symbol];
            }

            var newNode = new Node
            {
                Value = symbol
            };

            graph.Add(symbol, newNode);

            return newNode;
        }

        public class Node
        {
            public Node()
            {
                this.Successor = new HashSet<Node>();
                this.Parents = new HashSet<Node>();
            }

            public char Value { get; set; }

            public ICollection<Node> Successor { get; set; }

            public ICollection<Node> Parents { get; set; }
        }
    }
}