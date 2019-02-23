using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAT_Validation
{
    public class TextBox1:TextBox
    {
        public TextBox1() {

        }
      
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (!this.Enabled)
            {
                
                this.BackColor = Color.FromArgb(200,200,200);
            }
            else
            {
                this.BackColor = Color.FromArgb(191, 205, 219);
            }
            base.OnEnabledChanged(e);
        }
    }
}
