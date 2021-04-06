using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ClasesComplementarias
{
    public class MyColorTable : ProfessionalColorTable
    {
        private Color menuItemSelectedColor;
        public MyColorTable(Color color) : base()
        {
            menuItemSelectedColor = color;
        }
        public override Color MenuItemSelected
        {
            get { return menuItemSelectedColor; }
        }
    }
}
