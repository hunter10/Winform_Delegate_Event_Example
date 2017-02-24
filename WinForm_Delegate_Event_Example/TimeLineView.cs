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
    public partial class TimeLineView : UserControl, IView, IModelObserver
    {
        IController controller;

        public TimeLineView()
        {
            InitializeComponent();
        }

        public void SetController(IController cont)
        {
            controller = cont;
        }



        // 이하 델리게이트 테스트용
        public void Simple_ChangeName(string name)
        {
            Console.WriteLine("TimeLineView! simple Changename {0}", name);
        }

        public void IUser_ChangeAttr(string attr)
        {
            Console.WriteLine("TimeLineView! IUser_ChangeAttr {0}", attr);
        }

        public void IUser2_ChangeColor(IUser2 sender, CustomColor e)
        {
            string msg = string.Format("TimeLineView! IUser2_ChangeColor {0},{1}", e.objName, e.color);
            Console.WriteLine(msg);
            //MessageBox.Show(msg);
        }


        // 이하 MVC 테스트용
        // 모델에서 전송받은 데이터 세팅 - IModelObserver용 함수들
        public void attrChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("TimeLineView! Changeattr {0}", e.attr);
        }

        public void nameChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("TimeLineView! Changename {0}", e.name);
            label1.Text = e.name;
        }

        public void nameColorChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("TimeLineView! Changecol {0}", e.col);
        }
    }
}
