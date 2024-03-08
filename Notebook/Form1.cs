using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(noteTextBox.Text))
            {
                notesListBox.Items.Add(noteTextBox.Text);
                noteTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Enter the note text.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (notesListBox.SelectedIndex != -1)
            {
                notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select the note to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (notesListBox.SelectedIndex != -1)
            {
                string selectedNote = notesListBox.SelectedItem.ToString();
                MessageBox.Show(selectedNote, "View notesи");
            }
            else
            {
                MessageBox.Show("Select a note to view.");
            }
        }
    }
}
