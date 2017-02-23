using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Delegate_Event_Example
{
    public partial class ResorceView : UserControl
    {
        public ResorceView()
        {
            InitializeComponent();
        }

        public void ChangeName(string name)
        {
            Console.WriteLine("ResourceView! Changename {0}", name);
        }

        public void ChangeAttr(string attr)
        {
            Console.WriteLine("ResourceView! Changeattr {0}", attr);
        }

        public void ChangeColor(IUser2 sender, CustomColor e)
        {
            string msg = string.Format("ResourceView! Changecolor {0},{1}", e.objName, e.color);
            Console.WriteLine(msg);
            MessageBox.Show(msg);
        }
    }
}
