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
    public partial class ResorceView : UserControl, IView, IModelObserver
    {
        IController controller;
        
        public ResorceView()
        {
            InitializeComponent();
            resourceNameLabel.Text = "ready..";
        }

        public void SetController(IController cont)
        {
            controller = cont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.ChangeName("Wow.......");
        }

        // 이하 델리게이트 테스트용
        public void Simple_ChangeName(string name)
        {
            Console.WriteLine("Resource View! simple Changename {0}", name);
        }

        public void IUser_ChangeAttr(string attr)
        {
            Console.WriteLine("Resource View! IUser_ChangeAttr {0}", attr);
        }

        public void IUser2_ChangeColor(IUser2 sender, CustomColor e)
        {
            string msg = string.Format("Resource View! IUser2_ChangeColor {0},{1}", e.objName, e.color);
            Console.WriteLine(msg);
            //MessageBox.Show(msg);
        }

        // 모델에서 전송받은 데이터 세팅 - IModelObserver용 함수들
        public void attrChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("Resource View! Changeattr {0}", e.attr);
        }

        public void nameChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("Resource View! Changename {0}", e.name);
            resourceNameLabel.Text = e.name;
        }

        public void nameColorChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("Resource View! Changecol {0}", e.col);
        }
    }
}
