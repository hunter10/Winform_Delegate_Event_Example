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
    public partial class ActionView : UserControl, IView, IModelObserver
    {
        IController controller;

        public ActionView()
        {
            InitializeComponent();
        }

        public void SetController(IController cont)
        {
            controller = cont;
        }

        // 모델에서 전송받은 데이터 세팅 - IModelObserver용 함수들
        public void attrChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("AvtionView! Changeattr {0}", e.attr);
        }

        public void nameChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("AvtionView! Changename {0}", e.name);
            label1.Text = e.name;
        }

        public void nameColorChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("AvtionView! Changecol {0}", e.col);
        }
    }
}
