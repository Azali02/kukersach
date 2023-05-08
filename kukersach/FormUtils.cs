using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kukersach
{
    internal static class FormUtils
    {
        public static void CenterFormOnScreen(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Width - form.Width) / 2,
                                       (Screen.PrimaryScreen.Bounds.Height - form.Height) / 2);
        }
    }
}
