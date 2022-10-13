using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForMetodExt
{
    public static class TextBoxExt
    {
        public static string TextExt(this TextBox s)
        {
            return s.Text.ToUpper() + "!!!";
        }

    }
}
