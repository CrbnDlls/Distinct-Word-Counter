using Distinct_Word_Counter.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distinct_Word_Counter.Forms
{
    public partial class FormTextSplitter : Form
    {
        IWordCounter wordCounter;
        public FormTextSplitter(IWordCounter wordCounter)
        {
            InitializeComponent();
            this.wordCounter = wordCounter;
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            var groupsOfWords = wordCounter.GetDistinctWords(textBox1.Text);
            DisplayWords(groupsOfWords);
        }

        private void DisplayWords(IDictionary<int, SortedSet<string>> groupsOfWords)
        {
            foreach (var group in groupsOfWords)
            {
                listBox1.Items.Add($"Words of length: {group.Key}, Count: {group.Value.Count}");

                foreach (var word in group.Value)
                {
                    listBox1.Items.Add(word);
                }
            }
        }
    }
}
