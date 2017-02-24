using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Delegate_Event_Example
{
    public interface IView
    {
        void SetController(IController cont);
    }
}
