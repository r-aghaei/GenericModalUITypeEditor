using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericModalUITypeEditorSample
{
    public partial class MyBaseForm<T> : Form
    {
        public MyBaseForm()
        {
            InitializeComponent();
        }

        [Editor(typeof(MyUITypeEditor), typeof(UITypeEditor))]
        public string SomeProperty { get; set; }

        [Browsable(false)]
        public Type MyGenericType { get { return typeof(T); } }
    }
}
