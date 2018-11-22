using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nondeterministic_Impressionism
{
    public partial class Form1 : Form
    {
        Bitmap reference;
        List<Bitmap> drawing = new List<Bitmap>();
        bool sampling = false;
        bool shadeMatching = false;
        bool stippling = false;
        int ticks = 0;
        int changes = 0;
        int distanceLimit;

        public Form1()
        {
            InitializeComponent();
        }

        private void draw()
        {
            Bitmap drawingCopy = new Bitmap(drawing.ElementAt(drawing.Count - 1));

            Random rnd = new Random();

            Point pt1 = new Point(rnd.Next(0, reference.Width),
                rnd.Next(0, reference.Height));
            Point pt2 = new Point(rnd.Next(pt1.X - distanceLimit, pt1.X + distanceLimit),
                rnd.Next(pt1.Y - distanceLimit, pt1.Y + distanceLimit));

            Color color = Color.FromArgb(rnd.Next(0, 255),
                rnd.Next(0, 255), rnd.Next(0, 255));

            if (sampling)
            {
                color = reference.GetPixel(rnd.Next(0, reference.Width),
                    rnd.Next(0, reference.Height));
            }

            using (Graphics g = Graphics.FromImage(drawingCopy))
            {
                if (stippling)
                {
                    int size = rnd.Next(2, 10);
                    g.FillEllipse(new SolidBrush(color), pt1.X - (size / 2), pt1.Y - (size / 2), size, size);
                } else
                {
                    g.DrawLine(new Pen(new SolidBrush(color), 2), pt1, pt2);
                }
            }
            
            double simLast;
            double simCur;

            if (stippling)
            {
                simLast = compareSections(reference, drawing.ElementAt(drawing.Count - 1),
                    new Point(Math.Max(0, pt1.X - 10), Math.Max(0, pt1.Y - 10)),
                    new Point(Math.Min(reference.Width - 1, pt1.X + 10), Math.Min(reference.Height - 1, pt1.Y + 10)));
                simCur = compareSections(reference, drawingCopy,
                    new Point(Math.Max(0, pt1.X - 10), Math.Max(0, pt1.Y - 10)),
                    new Point(Math.Min(reference.Width - 1, pt1.X + 10), Math.Min(reference.Height - 1, pt1.Y + 10)));
            } else
            {
                simLast = compareSections(reference, drawing.ElementAt(drawing.Count - 1), pt1, pt2);
                simCur = compareSections(reference, drawingCopy, pt1, pt2);
            }

            if (simCur >= simLast)
            {
                drawing.RemoveAt(drawing.Count - 1);
                drawing.Add(drawingCopy);
                changes++;
            }
        }

        private double compareSections(Bitmap bmp1, Bitmap bmp2, Point pt1, Point pt2)
        {
            if (bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
            {
                return 0.0;
            }

            int leftBound = Math.Max(0, Math.Min(pt1.X, pt2.X) - 2);
            int rightBound = Math.Min(bmp1.Width - 1, Math.Max(pt1.X, pt2.X) + 2);
            int topBound = Math.Max(0, Math.Min(pt1.Y, pt2.Y) - 2);
            int bottomBound = Math.Min(bmp1.Height - 1, Math.Max(pt1.Y, pt2.Y) + 2);

            double similarity = 0;
            int pixelCount = ((rightBound + 1) - leftBound) * ((bottomBound + 1) - topBound);

            for (int x = leftBound; x <= rightBound; x++)
            {
                for (int y = topBound; y <= bottomBound; y++)
                {
                    Color col1 = bmp1.GetPixel(x, y);
                    Color col2 = bmp2.GetPixel(x, y);

                    if (shadeMatching)
                    {
                        similarity += shadeSim(col1, col2);
                    } else
                    {
                        similarity += colSim(col1, col2);
                    }
                }
            }

            return similarity / (double)pixelCount;
        }

        private double colSim(Color col1, Color col2)
        {
            double simR = 1.0 - Math.Abs((col1.R - col2.R) / 255.0);
            double simG = 1.0 - Math.Abs((col1.G - col2.G) / 255.0);
            double simB = 1.0 - Math.Abs((col1.B - col2.B) / 255.0);

            return (simR + simG + simB) / 3.0;
        }

        private double shadeSim(Color col1, Color col2)
        {
            return 1.0 - (Math.Abs(((col1.R + col1.G + col1.B) / 3.0) -
                ((col2.R + col2.G + col2.B) / 3.0)) / 255.0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (reference != null)
            {
                draw();
                drawingBox.Image = drawing.ElementAt(drawing.Count - 1);

                strokeCount.Text = "Stroke Count: " + changes;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReference.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDrawing.ShowDialog();
        }

        private void uploadInProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadInProgress.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pausePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
            {
                Text = "Nondeterministic Impressionism";
            } else
            {
                Text = "[PAUSED] Nondeterministic Impressionism";
            }
        }

        private void openReference_FileOk(object sender, CancelEventArgs e)
        {
            reference = (Bitmap) Image.FromFile(openReference.FileName);
            Bitmap blankDrawing = new Bitmap(reference.Width, reference.Height);

            using (Graphics g = Graphics.FromImage(blankDrawing))
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), 0, 0,
                    blankDrawing.Width, blankDrawing.Height);
            }

            drawing.Add(blankDrawing);

            referenceBox.Image = reference;
            drawingBox.Image = drawing.ElementAt(drawing.Count - 1);

            referenceBox.Width = Math.Min(300, reference.Width);
            referenceBox.Height = (int)(referenceBox.Width *
                (reference.Height / (float)reference.Width));

            drawingBox.Left = referenceBox.Left + referenceBox.Width + 6;
            drawingBox.Size = referenceBox.Size;

            changes = 0;
            distanceLimit = Math.Max((int)Math.Sqrt(
                Math.Pow(reference.Width, 2) +
                Math.Pow(reference.Height, 2)) / 10, 10);
        }

        private void strokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stippling = false;
            updateSimSettings();
        }

        private void stippleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stippling = true;
            updateSimSettings();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shadeMatching = false;
            updateSimSettings();
        }

        private void shadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shadeMatching = true;
            updateSimSettings();
        }

        private void randomFromRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sampling = false;
            updateSimSettings();
        }

        private void sampleFromReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sampling = true;
            updateSimSettings();
        }

        private void updateSimSettings()
        {
            simSettings.Text = "Sim settings: ";

            if (stippling)
            {
                simSettings.Text += "STIPPLING; ";
            } else
            {
                simSettings.Text += "STROKES; ";
            }

            if (sampling)
            {
                simSettings.Text += "COLOUR SAMPLING; ";
            }
            else
            {
                simSettings.Text += "RANDOM COLOUR SELECTION; ";
            }

            if (shadeMatching)
            {
                simSettings.Text += "SHADE MATCHING";
            }
            else
            {
                simSettings.Text += "COLOUR MATCHING";
            }
        }

        private void saveDrawing_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap toSave = drawing.ElementAt(drawing.Count - 1);

            toSave.Save(saveDrawing.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void uploadInProgress_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap inProgress = (Bitmap)Image.FromFile(uploadInProgress.FileName);

            if (inProgress.Size == reference.Size)
            {
                drawing = new List<Bitmap>();
                drawing.Add(inProgress);
            }
        }

        private void calculateSimilarityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double similarity = compareSections(reference,
                drawing.ElementAt(drawing.Count - 1),
                new Point(0, 0), new Point(reference.Width, reference.Height));

            similarityLabel.Text = "Similarity: " + (100 * similarity) + "%";
        }
    }
}
