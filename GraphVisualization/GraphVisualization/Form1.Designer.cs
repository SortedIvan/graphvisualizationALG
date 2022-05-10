
namespace GraphVisualization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateGraph = new System.Windows.Forms.Button();
            this.tbxVertices = new System.Windows.Forms.TextBox();
            this.tbxProbability = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxGraph = new System.Windows.Forms.PictureBox();
            this.btnConnectGraph = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSizeK = new System.Windows.Forms.Label();
            this.txtBSizeK = new System.Windows.Forms.TextBox();
            this.progressBarGraph = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPendant = new System.Windows.Forms.Button();
            this.btnPendantDec = new System.Windows.Forms.Button();
            this.btnTopsInc = new System.Windows.Forms.Button();
            this.btnTopsDec = new System.Windows.Forms.Button();
            this.btnExcludeNonRelBranches = new System.Windows.Forms.Button();
            this.btnExportDot = new System.Windows.Forms.Button();
            this.btnExportPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateGraph
            // 
            this.btnGenerateGraph.Location = new System.Drawing.Point(43, 129);
            this.btnGenerateGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerateGraph.Name = "btnGenerateGraph";
            this.btnGenerateGraph.Size = new System.Drawing.Size(298, 38);
            this.btnGenerateGraph.TabIndex = 0;
            this.btnGenerateGraph.Text = "Generate Graph";
            this.btnGenerateGraph.UseVisualStyleBackColor = true;
            this.btnGenerateGraph.Click += new System.EventHandler(this.btnGenerateGraph_Click);
            // 
            // tbxVertices
            // 
            this.tbxVertices.Location = new System.Drawing.Point(219, 19);
            this.tbxVertices.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxVertices.Name = "tbxVertices";
            this.tbxVertices.Size = new System.Drawing.Size(98, 29);
            this.tbxVertices.TabIndex = 2;
            // 
            // tbxProbability
            // 
            this.tbxProbability.Location = new System.Drawing.Point(219, 73);
            this.tbxProbability.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbxProbability.Name = "tbxProbability";
            this.tbxProbability.Size = new System.Drawing.Size(98, 29);
            this.tbxProbability.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Probability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nr of vertices:";
            // 
            // pbxGraph
            // 
            this.pbxGraph.Location = new System.Drawing.Point(374, 24);
            this.pbxGraph.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pbxGraph.Name = "pbxGraph";
            this.pbxGraph.Size = new System.Drawing.Size(771, 519);
            this.pbxGraph.TabIndex = 7;
            this.pbxGraph.TabStop = false;
            // 
            // btnConnectGraph
            // 
            this.btnConnectGraph.Location = new System.Drawing.Point(43, 176);
            this.btnConnectGraph.Name = "btnConnectGraph";
            this.btnConnectGraph.Size = new System.Drawing.Size(297, 38);
            this.btnConnectGraph.TabIndex = 9;
            this.btnConnectGraph.Text = "Connect Graph";
            this.btnConnectGraph.UseVisualStyleBackColor = true;
            this.btnConnectGraph.Click += new System.EventHandler(this.btnConnectGraph_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(44, 255);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(297, 44);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSizeK
            // 
            this.lblSizeK.AutoSize = true;
            this.lblSizeK.Location = new System.Drawing.Point(43, 226);
            this.lblSizeK.Name = "lblSizeK";
            this.lblSizeK.Size = new System.Drawing.Size(22, 21);
            this.lblSizeK.TabIndex = 11;
            this.lblSizeK.Text = "K:";
            // 
            // txtBSizeK
            // 
            this.txtBSizeK.Location = new System.Drawing.Point(219, 220);
            this.txtBSizeK.Name = "txtBSizeK";
            this.txtBSizeK.Size = new System.Drawing.Size(98, 29);
            this.txtBSizeK.TabIndex = 12;
            // 
            // progressBarGraph
            // 
            this.progressBarGraph.Location = new System.Drawing.Point(374, 569);
            this.progressBarGraph.Name = "progressBarGraph";
            this.progressBarGraph.Size = new System.Drawing.Size(771, 29);
            this.progressBarGraph.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(269, 305);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 21);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Vertex Cover";
            // 
            // btnPendant
            // 
            this.btnPendant.Location = new System.Drawing.Point(41, 305);
            this.btnPendant.Name = "btnPendant";
            this.btnPendant.Size = new System.Drawing.Size(97, 43);
            this.btnPendant.TabIndex = 15;
            this.btnPendant.Text = "P ++";
            this.btnPendant.UseVisualStyleBackColor = true;
            this.btnPendant.Click += new System.EventHandler(this.btnPendant_Click);
            // 
            // btnPendantDec
            // 
            this.btnPendantDec.Location = new System.Drawing.Point(169, 305);
            this.btnPendantDec.Name = "btnPendantDec";
            this.btnPendantDec.Size = new System.Drawing.Size(94, 41);
            this.btnPendantDec.TabIndex = 16;
            this.btnPendantDec.Text = "P --";
            this.btnPendantDec.UseVisualStyleBackColor = true;
            this.btnPendantDec.Click += new System.EventHandler(this.btnPendantDec_Click);
            // 
            // btnTopsInc
            // 
            this.btnTopsInc.Location = new System.Drawing.Point(41, 354);
            this.btnTopsInc.Name = "btnTopsInc";
            this.btnTopsInc.Size = new System.Drawing.Size(97, 43);
            this.btnTopsInc.TabIndex = 17;
            this.btnTopsInc.Text = "T ++";
            this.btnTopsInc.UseVisualStyleBackColor = true;
            this.btnTopsInc.Click += new System.EventHandler(this.btnTopsInc_Click);
            // 
            // btnTopsDec
            // 
            this.btnTopsDec.Location = new System.Drawing.Point(169, 354);
            this.btnTopsDec.Name = "btnTopsDec";
            this.btnTopsDec.Size = new System.Drawing.Size(95, 43);
            this.btnTopsDec.TabIndex = 18;
            this.btnTopsDec.Text = "T --";
            this.btnTopsDec.UseVisualStyleBackColor = true;
            this.btnTopsDec.Click += new System.EventHandler(this.btnTopsDec_Click);
            // 
            // btnExcludeNonRelBranches
            // 
            this.btnExcludeNonRelBranches.Location = new System.Drawing.Point(42, 419);
            this.btnExcludeNonRelBranches.Name = "btnExcludeNonRelBranches";
            this.btnExcludeNonRelBranches.Size = new System.Drawing.Size(297, 46);
            this.btnExcludeNonRelBranches.TabIndex = 19;
            this.btnExcludeNonRelBranches.Text = "Remove Non-Relevant Branches";
            this.btnExcludeNonRelBranches.UseVisualStyleBackColor = true;
            this.btnExcludeNonRelBranches.Click += new System.EventHandler(this.btnExcludeNonRelBranches_Click);
            // 
            // btnExportDot
            // 
            this.btnExportDot.Location = new System.Drawing.Point(41, 486);
            this.btnExportDot.Name = "btnExportDot";
            this.btnExportDot.Size = new System.Drawing.Size(297, 46);
            this.btnExportDot.TabIndex = 20;
            this.btnExportDot.Text = "Export dot file";
            this.btnExportDot.UseVisualStyleBackColor = true;
            this.btnExportDot.Click += new System.EventHandler(this.btnExportDot_Click);
            // 
            // btnExportPicture
            // 
            this.btnExportPicture.Location = new System.Drawing.Point(41, 552);
            this.btnExportPicture.Name = "btnExportPicture";
            this.btnExportPicture.Size = new System.Drawing.Size(297, 46);
            this.btnExportPicture.TabIndex = 21;
            this.btnExportPicture.Text = "Export graph picture";
            this.btnExportPicture.UseVisualStyleBackColor = true;
            this.btnExportPicture.Click += new System.EventHandler(this.btnExportPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1160, 621);
            this.Controls.Add(this.btnExportPicture);
            this.Controls.Add(this.btnExportDot);
            this.Controls.Add(this.btnExcludeNonRelBranches);
            this.Controls.Add(this.btnTopsDec);
            this.Controls.Add(this.btnTopsInc);
            this.Controls.Add(this.btnPendantDec);
            this.Controls.Add(this.btnPendant);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.progressBarGraph);
            this.Controls.Add(this.txtBSizeK);
            this.Controls.Add(this.lblSizeK);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnConnectGraph);
            this.Controls.Add(this.pbxGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxProbability);
            this.Controls.Add(this.tbxVertices);
            this.Controls.Add(this.btnGenerateGraph);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateGraph;
        private System.Windows.Forms.TextBox tbxVertices;
        private System.Windows.Forms.TextBox tbxProbability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxGraph;
        private System.Windows.Forms.Button btnConnectGraph;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSizeK;
        private System.Windows.Forms.TextBox txtBSizeK;
        private System.Windows.Forms.ProgressBar progressBarGraph;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPendant;
        private System.Windows.Forms.Button btnPendantDec;
        private System.Windows.Forms.Button btnTopsInc;
        private System.Windows.Forms.Button btnTopsDec;
        private System.Windows.Forms.Button btnExcludeNonRelBranches;
        private System.Windows.Forms.Button btnExportDotFile;
        private System.Windows.Forms.Button btnExportDot;
        private System.Windows.Forms.Button btnExportPicture;
    }
}

