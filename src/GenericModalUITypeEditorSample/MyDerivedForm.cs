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
    public partial class MyDerivedForm : MyBaseForm<MySampleModel>
    {
        public MyDerivedForm()
        {
            InitializeComponent();
        }
    }
}
