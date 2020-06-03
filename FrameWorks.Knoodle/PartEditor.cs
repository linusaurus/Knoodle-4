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
    public partial class PartEditor : Form
    {
        FrameWorks.SubAssemblyBase _sub;
        BindingSource bs = new BindingSource();
        
        public PartEditor()
        {
            InitializeComponent();
        }

        public PartEditor(FrameWorks.SubAssemblyBase subAssembly)
        {
            InitializeComponent();
            this._sub = subAssembly;
            this.bs.DataSource = subAssembly;
           


        }

        private void PartEditor_Load(object sender, EventArgs e)
        {
            BindData(_sub);
        }

        private void BindData(FrameWorks.SubAssemblyBase sub)
        {
            
            this.tbSubAssemblyName.DataBindings.Clear();
            this.tbSubAssemblyName.DataBindings.Add("Text", _sub, "Name");
            this.tbMakeFileName.DataBindings.Clear();
            this.tbMakeFileName.DataBindings.Add("Text", _sub, "ModelID");
            this.tbWidth.DataBindings.Clear();
            this.tbWidth.DataBindings.Add("Text", _sub, "SubAssemblyWidth");
            this.dataGridView1.DataSource = this.partBindingSource;
           //var result = null; //= from n in sub.Components  where n.part == "Materials" select n ;
           // this.partBindingSource.DataSource = result;

        }

        private void BindData(BindingSource  sub)
        {

            this.tbSubAssemblyName.DataBindings.Clear();
            this.tbSubAssemblyName.DataBindings.Add("Text", _sub, "Name");
            this.tbMakeFileName.DataBindings.Clear();
            this.tbMakeFileName.DataBindings.Add("Text", _sub, "ModelID");
            this.tbWidth.DataBindings.Clear();
            this.tbWidth.DataBindings.Add("Text", _sub, "SubAssemblyWidth");
            this.dataGridView1.DataSource = this.partBindingSource;
            //var result = from n in sub(FrameWorks.SubAssemblyBase)). where n.PartType == "Materials" select n;
            //this.partBindingSource.DataSource = result;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            this._sub.Components.Add(new FrameWorks.Component(751,"Added Part",_sub,1,60.25m));
            
            BindData(_sub);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            partBindingSource.EndEdit();
        }
    }
}
