using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace WinForm_Delegate_Event_Example
{
    // 모델이 뷰한테 전달할 델리게이트 세팅
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    // 데이터 받은 뷰에서 실행한 함수들...
    public interface IModelObserver
    {
        void attrChanged(IModel model, ModelEventArgs e);
        void nameChanged(IModel model, ModelEventArgs e);
        void nameColorChanged(IModel model, ModelEventArgs e);
    }



    public class ModelEventArgs : EventArgs
    {
        public string attr;
        public string name;
        public Color col;

        public ModelEventArgs(string name, string attr, Color col)
        {
            this.attr = attr;
            this.name = name;
            this.col = col;
        }
    }

    public interface IModel
    {
        void ChangeAttr(string attr);
        void ChangeName(string name);
        void ChangeNameColor(Color col);

        void attach(IModelObserver imo);
    }

    public class TestModel : IModel
    {
        public event ModelHandler<TestModel> changeAttr;
        public event ModelHandler<TestModel> changeName;
        public event ModelHandler<TestModel> changeNameColor;

        private string mAttr = "";
        private string mName = "";
        private Color mNameColor = Color.Black;

        public void ChangeAttr(string attr)
        {
            mAttr = attr;
            changeAttr.Invoke(this, new ModelEventArgs(mName, mAttr, mNameColor));
        }

        public void ChangeName(string name)
        {
            mName = name;
            changeName.Invoke(this, new ModelEventArgs(mName, mAttr, mNameColor));
        }

        public void ChangeNameColor(Color col)
        {
            mNameColor = col;
            changeNameColor.Invoke(this, new ModelEventArgs(mName, mAttr, mNameColor));
        }

        public void attach(IModelObserver imo)
        {
            changeAttr += new ModelHandler<TestModel>(imo.attrChanged);
            changeName += new ModelHandler<TestModel>(imo.nameChanged);
            changeNameColor += new ModelHandler<TestModel>(imo.nameColorChanged);
        }
    }
}
