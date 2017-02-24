using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace WinForm_Delegate_Event_Example
{
    public interface IController
    {
        void ChangeAttr(string attr);
        void ChangeName(string name);
        void ChangeNameColor(Color col);
    }

    public class MainController : IController
    {
        IView mainFormView;
        IView resourceView;
        IView timelineView;
        IView actionView;

        IModel model;

        public MainController(IModel m, IView mV, ResorceView rV, IView tV, IView aV) 
        {
            mainFormView = mV;
            resourceView = rV;
            timelineView = tV;
            actionView = aV;

            model = m;
            model.attach((IModelObserver)mainFormView);
            model.attach((IModelObserver)resourceView);
            model.attach((IModelObserver)timelineView);
            model.attach((IModelObserver)actionView);

            mainFormView.SetController(this);
            resourceView.SetController(this);
            timelineView.SetController(this);
            actionView.SetController(this);
        }

        // 실제 외부에 노출된 명령어세트
        public void ChangeAttr(string attr)
        {
            model.ChangeAttr(attr);
        }

        public void ChangeName(string name)
        {
            model.ChangeName(name);
        }

        public void ChangeNameColor(Color col)
        {
            model.ChangeNameColor(col);
        }
    }
}
