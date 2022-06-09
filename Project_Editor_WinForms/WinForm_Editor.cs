using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Editor_WinForms
{
    public partial class WinForm_Editor : Form
    {
        bool bold = false;
        public WinForm_Editor()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.BackColor = Color.FromArgb(color);
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int color = colorDialog1.Color.ToArgb();
            richTextBox1.ForeColor = Color.FromArgb(color);
        }

        private void CuttoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void LeftAligntoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightAligntoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CentreAligntoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FonttoolStripComboBox1.Items.Add(font.Name.ToString());
            }
        }

        private void BoldtoolStripButton1_Click(object sender, EventArgs e)
        {
            if(bold==false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                bold = true;
            }
            else if (bold==true)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                bold = false;
            }
            
            
           
        }

        private void CuttoolStripButton1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PastetoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void CopytoolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();   
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float zoomFac = richTextBox1.ZoomFactor;
            zoomFac += 2;
            if (zoomFac <=64)
            {
                
                richTextBox1.ZoomFactor = zoomFac;
            }
            
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float zoomFac = richTextBox1.ZoomFactor;
            zoomFac -= 2;
            if (zoomFac < 0.02)
            {
                // do nothing
            }
            else
            {
                
                richTextBox1.ZoomFactor = zoomFac;
            }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void FonttoolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FonttoolStripComboBox1.SelectedItem.ToString(), richTextBox1.Font.Size, richTextBox1.Font.Style);
        }

        private void FontSizetoolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(FontSizetoolStripComboBox2.SelectedItem.ToString()), richTextBox1.Font.Style);
        }
    }
}
