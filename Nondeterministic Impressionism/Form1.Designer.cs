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
            this.referenceBox = new System.Windows.Forms.PictureBox();
            this.drawingBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colourModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomFromRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleFromReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // uploadInProgressToolStripMenuItem
            // 
            this.uploadInProgressToolStripMenuItem.Name = "uploadInProgressToolStripMenuItem";
            this.uploadInProgressToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.uploadInProgressToolStripMenuItem.Text = "Upload In-Progress";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pausePlayToolStripMenuItem,
            this.drawingModeToolStripMenuItem,
            this.matchingModeToolStripMenuItem,
            this.colourModeToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // pausePlayToolStripMenuItem
            // 
            this.pausePlayToolStripMenuItem.Name = "pausePlayToolStripMenuItem";
            this.pausePlayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pausePlayToolStripMenuItem.Text = "Pause/Play";
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
            this.strokeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.strokeToolStripMenuItem.Text = "Stroke";
            // 
            // stippleToolStripMenuItem
            // 
            this.stippleToolStripMenuItem.Name = "stippleToolStripMenuItem";
            this.stippleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stippleToolStripMenuItem.Text = "Stipple";
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
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // shadeToolStripMenuItem
            // 
            this.shadeToolStripMenuItem.Name = "shadeToolStripMenuItem";
            this.shadeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.shadeToolStripMenuItem.Text = "Shade";
            // 
            // referenceBox
            // 
            this.referenceBox.Location = new System.Drawing.Point(12, 85);
            this.referenceBox.Name = "referenceBox";
            this.referenceBox.Size = new System.Drawing.Size(100, 50);
            this.referenceBox.TabIndex = 1;
            this.referenceBox.TabStop = false;
            // 
            // drawingBox
            // 
            this.drawingBox.Location = new System.Drawing.Point(118, 85);
            this.drawingBox.Name = "drawingBox";
            this.drawingBox.Size = new System.Drawing.Size(100, 50);
            this.drawingBox.TabIndex = 2;
            this.drawingBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
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
            // 
            // sampleFromReferenceToolStripMenuItem
            // 
            this.sampleFromReferenceToolStripMenuItem.Name = "sampleFromReferenceToolStripMenuItem";
            this.sampleFromReferenceToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.sampleFromReferenceToolStripMenuItem.Text = "Sample from Reference";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stroke Count: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sim settings: STROKES; RANDOM COLOUR SELECTION; COLOUR MATCHING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Similarity:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem colourModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomFromRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleFromReferenceToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

