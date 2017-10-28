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
    public partial class MyEditorForm<T> : Form
    {
        public MyEditorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            var list = ListBindingHelper.GetListItemProperties(typeof(T))
                .Cast<PropertyDescriptor>()
                .Select(x => new { Text = x.Name, Value = x }).ToList();
            this.comboBox1.DataSource = list;
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.ValueMember = "Value";
        }
        public string SelectedProperty
        {
            get
            {
                return comboBox1.GetItemText(comboBox1.SelectedItem);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
