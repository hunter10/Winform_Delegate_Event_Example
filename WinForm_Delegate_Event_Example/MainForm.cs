using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Delegate_Event_Example
{
    public partial class MainForm : Form, IUser, IUser2, IView, IModelObserver
    {
        IController controller;

        // 1. 단순 통신 테스트 
        public delegate void ChangeNameHandler(string name);
        public event ChangeNameHandler Simpel_ChangeName = delegate { };

        // 2. 인터페이스를 통한 통신 테스트
        public event ChangeAttrHandler<IUser> IUser_ChangeAttr;

        // 3. 인터페이스 + 유저정의 인자 통신 테스트
        public event ChangeColorHandler<IUser2> IUser2_ChangeColor;

        public MainForm()
        {
            InitializeComponent();
            SetArchitect();
        }

        public void SetArchitect()
        {
            // 1. 단순 통신 테스트
            Simpel_ChangeName += new MainForm.ChangeNameHandler(resorceView1.Simple_ChangeName);
            Simpel_ChangeName += new MainForm.ChangeNameHandler(timeLineView1.Simple_ChangeName);

            // 2. 인터페이스를 통한 통신 테스트
            IUser_ChangeAttr += new ChangeAttrHandler<IUser>(resorceView1.IUser_ChangeAttr);
            IUser_ChangeAttr += new ChangeAttrHandler<IUser>(timeLineView1.IUser_ChangeAttr);

            // 3. 인터페이스 + 유저정의 인자 통신 테스트
            IUser2_ChangeColor += new ChangeColorHandler<IUser2>(resorceView1.IUser2_ChangeColor);
            IUser2_ChangeColor += new ChangeColorHandler<IUser2>(timeLineView1.IUser2_ChangeColor);



            // MVC 테스트...
            // 모델
            IModel mdl = new TestModel();

            // 모델과 뷰들 연결
            MainController cnt = new MainController(mdl, this, resorceView1, timeLineView1, actionView1);
        }

        public void SetController(IController cont)
        {
            controller = cont;
        }

        // MVC패턴 테스트용
        private void button1_Click(object sender, EventArgs e)
        {
            controller.ChangeName("aaa");
        }

        // 단순 Delegate 테스트용
        private void button2_Click(object sender, EventArgs e)
        {
            IUser_ChangeAttr("attr change");
        }

        // IModelObserver 용 함수들
        public void attrChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("MainForm! Changeattr {0}", e.attr);
        }

        public void nameChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("MainForm! Changename {0}", e.name);
            label1.Text = e.name;
        }

        public void nameColorChanged(IModel model, ModelEventArgs e)
        {
            Console.WriteLine("MainForm! Changecol {0}", e.col);
        }

        
    }
}
