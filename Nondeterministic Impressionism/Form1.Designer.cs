namespace Nondeterministic_Impressionism
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadInProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausePlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stippleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomFromRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleFromReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceBox = new System.Windows.Forms.PictureBox();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.openReference = new System.Windows.Forms.OpenFileDialog();
            this.uploadInProgress = new System.Windows.Forms.OpenFileDialog();
            this.saveDrawing = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.strokeCount = new System.Windows.Forms.Label();
            this.simSettings = new System.Windows.Forms.Label();
            this.similarityLabel = new System.Windows.Forms.Label();
            this.calculateSimilarityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.uploadInProgressToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // uploadInProgressToolStripMenuItem
            // 
            this.uploadInProgressToolStripMenuItem.Name = "uploadInProgressToolStripMenuItem";
            this.uploadInProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uploadInProgressToolStripMenuItem.Text = "Upload In-Progress";
            this.uploadInProgressToolStripMenuItem.Click += new System.EventHandler(this.uploadInProgressToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausePlayToolStripMenuItem,
            this.drawingModeToolStripMenuItem,
            this.matchingModeToolStripMenuItem,
            this.colourModeToolStripMenuItem,
            this.calculateSimilarityToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // pausePlayToolStripMenuItem
            // 
            this.pausePlayToolStripMenuItem.Name = "pausePlayToolStripMenuItem";
            this.pausePlayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pausePlayToolStripMenuItem.Text = "Pause/Play";
            this.pausePlayToolStripMenuItem.Click += new System.EventHandler(this.pausePlayToolStripMenuItem_Click);
            // 
            // drawingModeToolStripMenuItem
            // 
            this.drawingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strokeToolStripMenuItem,
            this.stippleToolStripMenuItem});
            this.drawingModeToolStripMenuItem.Name = "drawingModeToolStripMenuItem";
            this.drawingModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawingModeToolStripMenuItem.Text = "Drawing Mode";
            // 
            // strokeToolStripMenuItem
            // 
            this.strokeToolStripMenuItem.Name = "strokeToolStripMenuItem";
            this.strokeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.strokeToolStripMenuItem.Text = "Stroke";
            this.strokeToolStripMenuItem.Click += new System.EventHandler(this.strokeToolStripMenuItem_Click);
            // 
            // stippleToolStripMenuItem
            // 
            this.stippleToolStripMenuItem.Name = "stippleToolStripMenuItem";
            this.stippleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stippleToolStripMenuItem.Text = "Stipple";
            this.stippleToolStripMenuItem.Click += new System.EventHandler(this.stippleToolStripMenuItem_Click);
            // 
            // matchingModeToolStripMenuItem
            // 
            this.matchingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourToolStripMenuItem,
            this.shadeToolStripMenuItem});
            this.matchingModeToolStripMenuItem.Name = "matchingModeToolStripMenuItem";
            this.matchingModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matchingModeToolStripMenuItem.Text = "Matching Mode";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // shadeToolStripMenuItem
            // 
            this.shadeToolStripMenuItem.Name = "shadeToolStripMenuItem";
            this.shadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shadeToolStripMenuItem.Text = "Shade";
            this.shadeToolStripMenuItem.Click += new System.EventHandler(this.shadeToolStripMenuItem_Click);
            // 
            // colourModeToolStripMenuItem
            // 
            this.colourModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomFromRGBToolStripMenuItem,
            this.sampleFromReferenceToolStripMenuItem});
            this.colourModeToolStripMenuItem.Name = "colourModeToolStripMenuItem";
            this.colourModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colourModeToolStripMenuItem.Text = "Colour Mode";
            // 
            // randomFromRGBToolStripMenuItem
            // 
            this.randomFromRGBToolStripMenuItem.Name = "randomFromRGBToolStripMenuItem";
            this.randomFromRGBToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.randomFromRGBToolStripMenuItem.Text = "Random from RGB";
            this.randomFromRGBToolStripMenuItem.Click += new System.EventHandler(this.randomFromRGBToolStripMenuItem_Click);
            // 
            // sampleFromReferenceToolStripMenuItem
            // 
            this.sampleFromReferenceToolStripMenuItem.Name = "sampleFromReferenceToolStripMenuItem";
            this.sampleFromReferenceToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sampleFromReferenceToolStripMenuItem.Text = "Sample from Reference";
            this.sampleFromReferenceToolStripMenuItem.Click += new System.EventHandler(this.sampleFromReferenceToolStripMenuItem_Click);
            // 
            // referenceBox
            // 
            this.referenceBox.Location = new System.Drawing.Point(12, 85);
            this.referenceBox.Name = "referenceBox";
            this.referenceBox.Size = new System.Drawing.Size(100, 50);
            this.referenceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.referenceBox.TabIndex = 1;
            this.referenceBox.TabStop = false;
            // 
            // drawingBox
            // 
            this.drawingBox.Location = new System.Drawing.Point(118, 85);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(100, 50);
            this.drawingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drawingBox.TabIndex = 2;
            this.drawingBox.TabStop = false;
            // 
            // openReference
            // 
            this.openReference.FileName = "openFileDialog1";
            this.openReference.FileOk += new System.ComponentModel.CancelEventHandler(this.openReference_FileOk);
            // 
            // uploadInProgress
            // 
            this.uploadInProgress.FileName = "openFileDialog2";
            this.uploadInProgress.FileOk += new System.ComponentModel.CancelEventHandler(this.uploadInProgress_FileOk);
            // 
            // saveDrawing
            // 
            this.saveDrawing.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDrawing_FileOk);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // strokeCount
            // 
            this.strokeCount.AutoSize = true;
            this.strokeCount.Location = new System.Drawing.Point(13, 28);
            this.strokeCount.Name = "strokeCount";
            this.strokeCount.Size = new System.Drawing.Size(81, 13);
            this.strokeCount.TabIndex = 3;
            this.strokeCount.Text = "Stroke Count: 0";
            // 
            // simSettings
            // 
            this.simSettings.AutoSize = true;
            this.simSettings.Location = new System.Drawing.Point(13, 69);
            this.simSettings.Name = "simSettings";
            this.simSettings.Size = new System.Drawing.Size(396, 13);
            this.simSettings.TabIndex = 4;
            this.simSettings.Text = "Sim settings: STROKES; RANDOM COLOUR SELECTION; COLOUR MATCHING";
            // 
            // similarityLabel
            // 
            this.similarityLabel.AutoSize = true;
            this.similarityLabel.Location = new System.Drawing.Point(12, 49);
            this.similarityLabel.Name = "similarityLabel";
            this.similarityLabel.Size = new System.Drawing.Size(50, 13);
            this.similarityLabel.TabIndex = 5;
            this.similarityLabel.Text = "Similarity:";
            // 
            // calculateSimilarityToolStripMenuItem
            // 
            this.calculateSimilarityToolStripMenuItem.Name = "calculateSimilarityToolStripMenuItem";
            this.calculateSimilarityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateSimilarityToolStripMenuItem.Text = "Calculate Similarity";
            this.calculateSimilarityToolStripMenuItem.Click += new System.EventHandler(this.calculateSimilarityToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.similarityLabel);
            this.Controls.Add(this.simSettings);
            this.Controls.Add(this.strokeCount);
            this.Controls.Add(this.drawingBox);
            this.Controls.Add(this.referenceBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Nondeterministic Impressionism";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referenceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadInProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausePlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strokeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stippleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox referenceBox;
        private System.Windows.Forms.PictureBox drawingBox;
        private System.Windows.Forms.OpenFileDialog openReference;
        private System.Windows.Forms.OpenFileDialog uploadInProgress;
        private System.Windows.Forms.SaveFileDialog saveDrawing;
        private System.Windows.Forms.ToolStripMenuItem colourModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomFromRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleFromReferenceToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label strokeCount;
        private System.Windows.Forms.Label simSettings;
        private System.Windows.Forms.Label similarityLabel;
        private System.Windows.Forms.ToolStripMenuItem calculateSimilarityToolStripMenuItem;
    }
}

