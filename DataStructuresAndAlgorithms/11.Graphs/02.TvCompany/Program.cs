namespace TvCompany
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class MinimumSpanningTree
    {
        /*
        02. You are given a cable TV company. The company needs to lay cable to a new neighborhood (for every house). 
            If it is constrained to bury the cable only along certain paths, then there would be a graph representing 
            which points are connected by those paths. But the cost of some of the paths is more expensive because 
            they are longer. If every house is a node and every path from house to house is an edge, find a way to 
            minimize the cost for cables.
        */
        public static void Main()
        {
            ICollection<Path> neighbourhood = GetNeighbourhood();
            ICollection<Path> minSpanningTree = GetMinimumSpanningTree(neighbourhood);

            long minCost = 0;

            Console.WriteLine("All paths are:");

            foreach (Path path in minSpanningTree)
            {
                Console.WriteLine(path);
                minCost += path.Distance;
            }

            Console.WriteLine("The minimal cost is: {0}", minCost);
        }

        public static ICollection<Path> GetMinimumSpanningTree(ICollection<Path> neighbourhood)
        {
            OrderedBag<Path> minimumSpanningTree = new OrderedBag<Path>();
            List<HashSet<House>> vertexSets = GetSetsWithOneVertex(neighbourhood);
            foreach (Path path in neighbourhood)
            {
                HashSet<House> startHouseGroup = GetVertexSet(path.StartHouse, vertexSets);
                HashSet<House> endHouseGroup = GetVertexSet(path.EndHouse, vertexSets);
                if (startHouseGroup == null)
                {
                    minimumSpanningTree.Add(path);
                    if (endHouseGroup == null)
                    {
                        HashSet<House> newVertexSet = new HashSet<House>();
                        newVertexSet.Add(path.StartHouse);
                        newVertexSet.Add(path.EndHouse);
                        vertexSets.Add(newVertexSet);
                    }
                    else
                    {
                        endHouseGroup.Add(path.StartHouse);
                    }
                }
                else
                {
                    if (endHouseGroup == null)
                    {
                        startHouseGroup.Add(path.EndHouse);
                        minimumSpanningTree.Add(path);
                    }
                    else if (startHouseGroup != endHouseGroup)
                    {
                        startHouseGroup.UnionWith(endHouseGroup);
                        vertexSets.Remove(endHouseGroup);
                        minimumSpanningTree.Add(path);
                    }
                }
            }

            return minimumSpanningTree;
        }

        public static List<HashSet<House>> GetSetsWithOneVertex(ICollection<Path> neighbourhood)
        {
            List<HashSet<House>> allSetsWithOneVertex = new List<HashSet<House>>();
            foreach (var path in neighbourhood)
            {
                bool startHouseToBeAdded = true;
                bool endHouseToBeAdded = true;
                foreach (var set in allSetsWithOneVertex)
                {
                    if (startHouseToBeAdded && set.Contains(path.StartHouse))
                    {
                        startHouseToBeAdded = false;
                    }

                    if (endHouseToBeAdded && set.Contains(path.EndHouse))
                    {
                        endHouseToBeAdded = false;
                    }

                    if (!startHouseToBeAdded && !endHouseToBeAdded)
                    {
                        break;
                    }
                }

                if (startHouseToBeAdded)
                {
                    HashSet<House> newSet = new HashSet<House>();
                    newSet.Add(path.StartHouse);
                    allSetsWithOneVertex.Add(newSet);
                }

                if (endHouseToBeAdded)
                {
                    HashSet<House> newSet = new HashSet<House>();
                    newSet.Add(path.EndHouse);
                    allSetsWithOneVertex.Add(newSet);
                }
            }

            return allSetsWithOneVertex;
        }

        public static ICollection<Path> GetNeighbourhood()
        {
            OrderedBag<Path> district = new OrderedBag<Path>();
            district.Add(new Path(new House("1"), new House("2"), 2));
            district.Add(new Path(new House("1"), new House("3"), 22));
            district.Add(new Path(new House("1"), new House("10"), 7));
            district.Add(new Path(new House("2"), new House("10"), 12));
            district.Add(new Path(new House("2"), new House("9"), 4));
            district.Add(new Path(new House("3"), new House("5"), 7));
            district.Add(new Path(new House("4"), new House("3"), 9));
            district.Add(new Path(new House("10"), new House("8"), 1));
            district.Add(new Path(new House("8"), new House("6"), 17));
            district.Add(new Path(new House("8"), new House("7"), 8));
            district.Add(new Path(new House("5"), new House("8"), 9));

            return district;
        }

        public static HashSet<House> GetVertexSet(House vertex, List<HashSet<House>> vertexSets)
        {
            foreach (var vertexSet in vertexSets)
            {
                if (vertexSet.Contains(vertex))
                {
                    return vertexSet;
                }
            }

            return null;
        }
    }
}