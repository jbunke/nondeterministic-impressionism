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
        List<Bitmap> drawing;
        bool sampling = false;
        bool shadeMatching = false;
        bool stippling = false;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
