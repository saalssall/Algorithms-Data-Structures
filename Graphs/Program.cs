
namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new Dictionary<string, List<string>>
            {
                { "Alice",   new List<string> { "Bob", "Diana", "Fred" } },
                { "Bob",     new List<string> { "Alice", "Cynthia", "Diana" } },
                { "Cynthia", new List<string> { "Bob" } },
                { "Diana",   new List<string> { "Alice", "Bob", "Fred" } },
                { "Elise",   new List<string> { "Fred" } },
                { "Fred",    new List<string> { "Alice", "Diana", "Elise" } }
            };
            
            foreach (string friend in friends["Alice"])
            {
                Console.WriteLine(friend);
            }
            
            Console.WriteLine("----------");
            Depth_First_Search dfs = new Depth_First_Search();
            dfs.Traverse("Alice", friends);
            
            Console.WriteLine("----------");
            Depth_First_SearchV df2 = new Depth_First_SearchV();
            //Searching for a specific vertex
            string? result = df2.Dfs("Cynthia", "Elise", friends);
            Console.WriteLine(result ?? "Not found");
            
            //Breadth-First Search
            Console.WriteLine("----------");
            Breadth_First_Search bfs = new Breadth_First_Search();
            bfs.BfsTraverse("Bob", friends);
            
            Console.WriteLine("----------");
            // Create vertices
            WeightedGraphVertex dallas  = new WeightedGraphVertex("Dallas");
            WeightedGraphVertex toronto = new WeightedGraphVertex("Toronto");

            dallas.AddAdjacentVertex(toronto, 138);
            Console.WriteLine($"Dallas -> Toronto: {dallas.AdjacentVertices[toronto]}");
            toronto.AddAdjacentVertex(dallas, 216);   // Toronto -> Dallas costs 216
           
            Console.WriteLine("----------");
            var atlanta = new City("Atlanta");
            var boston = new City("Boston");
            var chicago = new City("Chicago");
            var denver = new City("Denver");
            var elPaso = new City("El Paso");
            
            atlanta.AddRoute(boston, 100);
            atlanta.AddRoute(denver, 160);
            boston.AddRoute(chicago, 120);
            boston.AddRoute(denver, 180);
            chicago.AddRoute(elPaso, 80);
            denver.AddRoute(chicago, 40);
            denver.AddRoute(elPaso, 140);

            //Getting the shortest path from Atlanta to El Paso
            var path = Dijkstra.ShortestPath(atlanta, elPaso);
            Console.WriteLine(string.Join(" -> ", path));
        }
    }
}