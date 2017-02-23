using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Delegate_Event_Example
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mF = new MainForm();
            ResorceView rV = new ResorceView();
            TimeLineView tV = new TimeLineView();

            // 1. 단순 통신 테스트
            mF.ChangeName += new MainForm.ChangeNameHandler(rV.ChangeName);
            mF.ChangeName += new MainForm.ChangeNameHandler(tV.ChangeName);

            // 2. 인터페이스를 통한 통신 테스트
            mF.ChangeAttr += new ChangeAttrHandler<IUser>(rV.ChangeAttr);
            mF.ChangeAttr += new ChangeAttrHandler<IUser>(tV.ChangeAttr);

            // 3. 인터페이스 + 유저정의 인자 통신 테스트
            mF.ChangeColor += new ChangeColorHandler<IUser2>(rV.ChangeColor);
            mF.ChangeColor += new ChangeColorHandler<IUser2>(tV.ChangeColor);

            Application.Run(mF);
        }
    }
}
