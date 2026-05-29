namespace Graphs;

using System;
using System.Collections.Generic;

public class City
{
    public string Name { get; }
    public Dictionary<City, int> Routes { get; } = new();

    public City(string name)
    {
        Name = name;
    }

    public void AddRoute(City destination, int price)
    {
        Routes[destination] = price;
    }
}

public static class Dijkstra
{
    public static List<string> ShortestPath(City start, City destination)
    {
        // Stores the cheapest known cost from the start city to each city.
        var distances = new Dictionary<City, int>();

        // Stores the previous city on the cheapest path.
        var previous = new Dictionary<City, City>();

        // Keeps track of cities that have been fully processed.
        var visited = new HashSet<City>();

        // Priority queue of cities ordered by their current cheapest cost.
        var unvisited = new PriorityQueue<City, int>();

        // The cost of reaching the start city is 0.
        distances[start] = 0;
        unvisited.Enqueue(start, 0);

        // Continue while there are still cities to process.
        while (unvisited.Count > 0)
        {
            City current = unvisited.Dequeue();

            // Skip cities that have already been visited.
            if (!visited.Add(current))
                continue;

            // If we've reached the destination, we're done.
            if (current == destination)
                break;

            // Examine each neighbouring city.
            foreach (var route in current.Routes)
            {
                City neighbour = route.Key;
                int cost = route.Value;

                // Calculate the cost of reaching the neighbour
                // through the current city.
                int newDistance = distances[current] + cost;

                // If this is the cheapest route found so far,
                // update our tables.
                if (!distances.ContainsKey(neighbour) ||
                    newDistance < distances[neighbour])
                {
                    distances[neighbour] = newDistance;
                    previous[neighbour] = current;

                    // Add the neighbour to the priority queue
                    // with its updated cost.
                    unvisited.Enqueue(neighbour, newDistance);
                }
            }
        }

        // Build the shortest path by working backwards
        // from the destination to the start.
        var path = new List<string>();
        City? currentCity = destination;

        while (currentCity != null)
        {
            path.Add(currentCity.Name);

            if (currentCity == start)
                break;

            previous.TryGetValue(currentCity, out currentCity);
        }

        // Reverse the path so it goes from start to destination.
        path.Reverse();

        return path;
    }
}