using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericModalUITypeEditorSample
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            var f = new MyDerivedForm();
            f.TopLevel = false;
            this.splitContainer1.Panel1.Controls.Add(f);
            f.Show();
            this.propertyGrid1.SelectedObject = f;
        }
    }
}
