using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Service;
using DataAccess.Models;
using System.Windows.Forms;
using DataAccess;

namespace Weaselware.Knoodle.Controls
{
    public partial class PartManagerControl : UserControl
    {
        private readonly BadgerContext ctx;
        public PartManagerControl(BadgerContext context)
        {
            InitializeComponent();
            ctx = context;
        }

        private void PartManagerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
