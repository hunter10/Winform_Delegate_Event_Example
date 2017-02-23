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
    public partial class MainForm : Form, IUser, IUser2
    {
        // 1. 단순 통신 테스트 
        public delegate void ChangeNameHandler(string name);
        public event ChangeNameHandler ChangeName = delegate { };

        // 2. 인터페이스를 통한 통신 테스트
        public event ChangeAttrHandler<IUser> ChangeAttr;

        // 3. 인터페이스 + 유저정의 인자 통신 테스트
        public event ChangeColorHandler<IUser2> ChangeColor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeName("aaa");

            ChangeAttr("body=1000");

            ChangeColor(this, new CustomColor("피카츄", Color.FromArgb(255, 255, 0, 0)));
        }
    }
}
