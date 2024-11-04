using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPetManagement.Views
{
    public class CustomTabControl : TabControl
    {
        public CustomTabControl()
        {
            this.Appearance = TabAppearance.FlatButtons;
            this.ItemSize = new Size(1, 1);
            this.SizeMode = TabSizeMode.Fixed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
        }
    }
}
