using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaceHierarchy
{
    interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrowUpSideDown();
    }
}
