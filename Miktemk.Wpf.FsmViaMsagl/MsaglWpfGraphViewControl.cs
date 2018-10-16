﻿using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.WpfGraphControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

using MsaglColor = Microsoft.Msagl.Drawing.Color;

namespace Miktemk.Wpf.FsmViaMsagl
{
    public class MsaglWpfGraphViewControl : Panel
    {
        public MsaglWpfGraphViewControl()
        {
            Loaded += MsaglWpfGraphViewControl_Loaded;
        }

        private void MsaglWpfGraphViewControl_Loaded(object sender, System.Windows.RoutedEventArgs args)
        {
            this.Background = Brushes.Red;

            GraphViewer graphViewer = new GraphViewer();
            graphViewer.BindToPanel(this);

            Graph graph = new Graph();

            //graph.LayoutAlgorithmSettings=new MdsLayoutSettings();

            graph.AddEdge("1", "2");
            graph.AddEdge("1", "3");
            var e = graph.AddEdge("4", "5");
            e.LabelText = "Some edge label";
            e.Attr.Color = MsaglColor.Red;
            e.Attr.LineWidth *= 2;

            graph.AddEdge("4", "6");
            e = graph.AddEdge("7", "8");
            e.Attr.LineWidth *= 2;
            e.Attr.Color = MsaglColor.Red;

            graph.AddEdge("7", "9");
            e = graph.AddEdge("5", "7");
            e.Attr.Color = MsaglColor.Red;
            e.Attr.LineWidth *= 2;

            graph.AddEdge("2", "7");
            graph.AddEdge("10", "11");
            graph.AddEdge("10", "12");
            graph.AddEdge("2", "10");
            graph.AddEdge("8", "10");
            graph.AddEdge("5", "10");
            graph.AddEdge("13", "14");
            graph.AddEdge("13", "15");
            graph.AddEdge("8", "13");
            graph.AddEdge("2", "13");
            graph.AddEdge("5", "13");
            graph.AddEdge("16", "17");
            graph.AddEdge("16", "18");
            graph.AddEdge("16", "18");
            graph.AddEdge("19", "20");
            graph.AddEdge("19", "21");
            graph.AddEdge("17", "19");
            graph.AddEdge("2", "19");
            graph.AddEdge("22", "23");

            e = graph.AddEdge("22", "24");
            e.Attr.Color = MsaglColor.Red;
            e.Attr.LineWidth *= 2;

            e = graph.AddEdge("8", "22");
            e.Attr.Color = MsaglColor.Red;
            e.Attr.LineWidth *= 2;

            graph.AddEdge("20", "22");
            graph.AddEdge("25", "26");
            graph.AddEdge("25", "27");
            graph.AddEdge("20", "25");
            graph.AddEdge("28", "29");
            graph.AddEdge("28", "30");
            graph.AddEdge("31", "32");
            graph.AddEdge("31", "33");
            graph.AddEdge("5", "31");
            graph.AddEdge("8", "31");
            graph.AddEdge("2", "31");
            graph.AddEdge("20", "31");
            graph.AddEdge("17", "31");
            graph.AddEdge("29", "31");
            graph.AddEdge("34", "35");
            graph.AddEdge("34", "36");
            graph.AddEdge("20", "34");
            graph.AddEdge("29", "34");
            graph.AddEdge("5", "34");
            graph.AddEdge("2", "34");
            graph.AddEdge("8", "34");
            graph.AddEdge("17", "34");
            graph.AddEdge("37", "38");
            graph.AddEdge("37", "39");
            graph.AddEdge("29", "37");
            graph.AddEdge("5", "37");
            graph.AddEdge("20", "37");
            graph.AddEdge("8", "37");
            graph.AddEdge("2", "37");
            graph.AddEdge("40", "41");
            graph.AddEdge("40", "42");
            graph.AddEdge("17", "40");
            graph.AddEdge("2", "40");
            graph.AddEdge("8", "40");
            graph.AddEdge("5", "40");
            graph.AddEdge("20", "40");
            graph.AddEdge("29", "40");
            graph.AddEdge("43", "44");
            graph.AddEdge("43", "45");
            graph.AddEdge("8", "43");
            graph.AddEdge("2", "43");
            graph.AddEdge("20", "43");
            graph.AddEdge("17", "43");
            graph.AddEdge("5", "43");
            graph.AddEdge("29", "43");
            graph.AddEdge("46", "47");
            graph.AddEdge("46", "48");
            graph.AddEdge("29", "46");
            graph.AddEdge("5", "46");
            graph.AddEdge("17", "46");
            graph.AddEdge("49", "50");
            graph.AddEdge("49", "51");
            graph.AddEdge("5", "49");
            graph.AddEdge("2", "49");
            graph.AddEdge("52", "53");
            graph.AddEdge("52", "54");
            graph.AddEdge("17", "52");
            graph.AddEdge("20", "52");
            graph.AddEdge("2", "52");
            graph.AddEdge("50", "52");
            graph.AddEdge("55", "56");
            graph.AddEdge("55", "57");
            graph.AddEdge("58", "59");
            graph.AddEdge("58", "60");
            graph.AddEdge("20", "58");
            graph.AddEdge("29", "58");
            graph.AddEdge("5", "58");
            graph.AddEdge("47", "58");

            var subgraph = new Subgraph("subgraph 1");
            graph.RootSubgraph.AddSubgraph(subgraph);
            subgraph.AddNode(graph.FindNode("47"));
            subgraph.AddNode(graph.FindNode("58"));

            graph.AddEdge(subgraph.Id, "55");

            var node = graph.FindNode("5");
            node.LabelText = "Label of node 5";
            node.Label.FontSize = 5;
            node.Label.FontName = "New Courier";
            node.Label.FontColor = Microsoft.Msagl.Drawing.Color.Blue;

            node = graph.FindNode("55");


            graph.Attr.LayerDirection = LayerDirection.TB;

            graphViewer.Graph = graph; // throws exception
        }
    }
}