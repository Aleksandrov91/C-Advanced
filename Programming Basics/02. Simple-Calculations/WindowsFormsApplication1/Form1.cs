using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CatchMeButton_MouseClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - CatchMeButton.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - CatchMeButton.ClientSize.Height;
            this.CatchMeButton.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void CatchMeButton_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
