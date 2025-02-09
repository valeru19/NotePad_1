using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TtxEdr
{
    public partial class mode1 : Form
    {
        public mode1()
        {
            InitializeComponent();
            if (comboBox1.Text == "HTML")
            {
                saveFileDialog1.Filter = "Web страница (*.html)|*.html";
            }
            else if (comboBox1.Text == "JavaScript")
            {
                saveFileDialog1.Filter = "JavaScript file(*.js)|*.js";
            }
            else if (comboBox1.Text == "CSS")
            {
                saveFileDialog1.Filter = "CSS file (*.css)|*.css";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("File saved!");
            File.WriteAllText("Site.t$", filename);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            { return; }
            string filename2 = openFileDialog1.FileName;
            string text = File.ReadAllText(filename2);
            richTextBox1.Text = text;
            File.WriteAllText("path.t$", filename2);
        }

        private void shriftSettigsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void launchWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web web1 = new web();
            web1.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText("path.t$");
            File.WriteAllText(path, richTextBox1.Text);
        }
    }
}
