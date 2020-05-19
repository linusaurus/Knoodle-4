using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weaselware.Knoodle
{
    public partial class ProjectEdit : Form
    {

        BusinessObjects.Project _project;
        
        public ProjectEdit()
        {
            InitializeComponent();
        }

        private void ProjectEdit_Load(object sender, EventArgs e)
        {
             _project= Db.ProjectData();
            this.projectBindingSource.DataSource = _project;
          
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            projectBindingSource.EndEdit();
            _project.Collection.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            projectBindingSource.CancelEdit();
            Close();
        }
    }
}
