using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace WinForm_Delegate_Event_Example
{
    public delegate void ChangeAttrHandler<IUser>(string attr);
    public interface IUser
    {
        event ChangeAttrHandler<IUser> ChangeAttr;
    }

    public delegate void ChangeColorHandler<IUser2>(IUser2 sender, CustomColor e);
    public interface IUser2
    {
        event ChangeColorHandler<IUser2> ChangeColor;
    }

    public class CustomColor : EventArgs
    {
        public string objName;
        public Color color;

        public CustomColor(string name, Color col)
        {
            objName = name;
            color = col;
        }
    }
}
