using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using FrameWorks;
using FrameWorks.Makes;


namespace Weaselware.Knoodle
{
    public partial class ClassNameFinder : Form
    {
        string selectedNamespace;
        string selectedClass;
        
        public ClassNameFinder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
        public string SelectedClass
        {
            get { return selectedClass; }
        }
        

        private void ClassNameFinder_Load(object sender, EventArgs e)
        {
            this.listBox2.DataSource = FrameWorks.Utilities.GetAllNameSpaces();
            this.listBox1.DisplayMember = "Namespace";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           selectedNamespace = "FrameWorks.Makes." + listBox2.SelectedItem.ToString();
           this.listBox1.DataSource = FrameWorks.Utilities.GetAllClasses(selectedNamespace);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClass = "FrameWorks.Makes." + listBox1.SelectedItem.ToString();
        }
    }
}
