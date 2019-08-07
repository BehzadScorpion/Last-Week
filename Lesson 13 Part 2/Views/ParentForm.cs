using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_13_Part_2
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ChildForm document = new ChildForm();
            document.MdiParent = this;
            document.Text = "Document " + this.MdiChildren.Length;
            document.Show();
        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStrip.Visible = (ToolStrip.Visible) ? false : true;

        }

        private void stripMenuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            MenuStrip.Visible = (MenuStrip.Visible) ? false : true;
        }
    }
}
