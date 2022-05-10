using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace GraphVisualization
{
    public partial class Form1 : Form
    {
        private Graph graph;

        
        public Form1()
        {
            InitializeComponent();
            
        }


        private void btnGenerateGraph_Click(object sender, EventArgs e)
        {
            int vertices = Convert.ToInt32(this.tbxVertices.Text);
            int probability = Convert.ToInt32(this.tbxProbability.Text);
            graph = new Graph(vertices, probability);
            WriteDot(graph, false);
        }


        private void WriteDot(Graph graph, bool NotRelevantVert)
        {
            string s = "";

            s += "graph my_graph {\n";
            s += "   node [ fontname = Arial,style=\"filled,setlinewidth(4)\",shape=circle ]\n";
            s += graph.ToString(NotRelevantVert);
            s += "}\n";

            StreamWriter file = new StreamWriter("abc.dot");
            file.Write(s);
            file.Close();
            GeneratePicture();

        }

        private void GeneratePicture()
        {
            string executableLocation = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location);
            string xslLocation = Path.Combine(executableLocation, "dot.exe");

            Process dot = new Process();
            dot.StartInfo.FileName = xslLocation;
            dot.StartInfo.Arguments = "-Tpng -oabc.png abc.dot";
            dot.Start();
            dot.WaitForExit();
            pbxGraph.ImageLocation = "abc.png";
        }

        private void btnConnectGraph_Click(object sender, EventArgs e)
        {
            graph.ConnectAllVertices();
            WriteDot(graph, false);

        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            UsedVertices usedV = new UsedVertices();
            graph.validVertex = true;
            progressBarGraph.Value = 0;
            bool algResult = usedV.Validate(graph, new bool[graph.getVertices()], graph.getVertices(), 0, Convert.ToInt32(txtBSizeK.Text));
            if (algResult)
            {
                lblResult.Text = "Valid vertex cover";
                lblResult.ForeColor = Color.Green;
                CalculateProgressBarValue(graph.GetListOfConnecteVertices(), graph.getVertices());
            }
            else
            {
                lblResult.Text = "False vertex cover";
                lblResult.ForeColor = Color.Red;
                progressBarGraph.Value = 0;
            }
        }

        private void btnPendant_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(this.txtBSizeK.Text);
            graph.PendantIncrement();
            graph.RecursiveKernalization(k);
            graph.updateDotFile();
            GeneratePicture();

        }

        private void btnPendantDec_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(this.txtBSizeK.Text);
            graph.PendantDecrement();
            graph.RecursiveKernalization(k);
            graph.updateDotFile();
            GeneratePicture();
        }

        private void btnTopsInc_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(this.txtBSizeK.Text);
            graph.TopIncrement(k);
            graph.RecursiveKernalization(k);
            graph.updateDotFile();
            GeneratePicture();
        }

        private void btnTopsDec_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(this.txtBSizeK.Text);
            graph.TopDecrement(k);
            graph.RecursiveKernalization(k);
            graph.updateDotFile();
            GeneratePicture();
        }

        private void btnExcludeNonRelBranches_Click(object sender, EventArgs e)
        {
            UsedVertices usedV = new UsedVertices();
            int k = Convert.ToInt32(txtBSizeK.Text);
            List<List<int>> participants = new List<List<int>>();
            int vertices = Convert.ToInt32(this.tbxVertices.Text);
            progressBarGraph.Value = 0;
            
            participants = graph.RemovingNonRelevantVertices();
            vertices = participants.Count();
            k = graph.GetNewNonRelVerticesK(participants, k);
            
            usedV.Validate(graph, new bool[vertices], vertices, vertices, k);
            CalculateProgressBarValue(participants, vertices);
            WriteDot(graph, true);
        }

        private void CalculateProgressBarValue(List<List<int>> ListOfvertices, int vertices)
        {
            int progress = 0;
            for (int i = vertices - 1; i >= 0; i--)
            {
                if (ListOfvertices[i].Count!= 0)
                {
                    progress++;
                }
            }
            progressBarGraph.Value = (progress*100)/vertices;
        }

        private void btnExportDot_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"abc.dot")
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void btnExportPicture_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"abc.png")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
