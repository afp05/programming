using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
   class RGB 
    {
        public byte R;
        public byte G;
        public byte B;
    }
    struct RGBA
    {
        public byte R;
        public byte G;
        public byte B;
        public byte A;

    }
    struct BW
    {
        public byte Gray;
    }
    class Picture <T>
    {
        public T[] data = new T[10];
        
    }
}
