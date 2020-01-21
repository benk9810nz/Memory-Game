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
namespace MemoryGame
{
    public partial class CheatModeHelp : Form
    {
        public CheatModeHelp()
        {
            InitializeComponent();
        }

        private void CheatModeHelp_Load(object sender, EventArgs e)
        {
            using (StreamReader rdr = new StreamReader("instructions.txt"))
            {
               while (! rdr.EndOfStream)
                {
                    richTextBox1.Text = rdr.ReadLine();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
