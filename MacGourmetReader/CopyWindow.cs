using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacGourmetReader
{
    public partial class CopyWindow : Form
    {
        public CopyWindow()
        {
            InitializeComponent();
        }

        public void SetText(string outputText)
        {
            recipeOutputTB.Text = outputText;
        }
    }
}
