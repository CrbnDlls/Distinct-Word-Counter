using Distinct_Word_Counter.Forms;
using Distinct_Word_Counter.Interfaces;

namespace Distinct_Word_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void textSplitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTextSplitter formTextSplitter = new FormTextSplitter(new WordCounter());
            formTextSplitter.MdiParent = this;
            formTextSplitter.WindowState = FormWindowState.Maximized;
            formTextSplitter.Show();
        }
    }
}