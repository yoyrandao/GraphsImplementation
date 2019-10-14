﻿using LeskoGraphs.Components;
using System;

namespace LeskoGraphs {
    internal class Program {
        private static void Main(string[] args) {
            Graph<int> graph = new Graph<int>(new BreadthFirstTravel());

            graph.AddNode(new Node<int>(0));
            graph.AddNode(new Node<int>(1));
            graph.AddNode(new Node<int>(2));
            graph.AddNode(new Node<int>(3));
            graph.AddNode(new Node<int>(4));
            graph.AddNode(new Node<int>(5));
            graph.AddNode(new Node<int>(6));

            graph.AddNeighbour(0, 1, 4);
            graph.AddNeighbour(1, 0, 2, 3);
            graph.AddNeighbour(2, 1);
            graph.AddNeighbour(3, 1, 4, 5);
            graph.AddNeighbour(4, 0, 3, 5);
            graph.AddNeighbour(5, 3, 4);

            Console.WriteLine(string.Join("->", graph));
            graph.travelsar = new DepthFirstTravel();
            Console.WriteLine(string.Join("->", graph));

        }
    }
}
