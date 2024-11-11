using System;
using System.Collections.Generic;
using System.Text;

namespace MIInterfaceHierarchy
{
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();

    }
}
