using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiWinForms
{
    using BaseFormsEtxc;

    public partial class BaseForm : Form
    {
        private readonly IGraphicsForm _form;
        public BaseForm(IGraphicsForm form)
        {
            InitializeComponent();
            _form = form;
        }

        private void BtnGraphicsOnClick(object sender, EventArgs eventArgs)
        {
            _form.SetParameters(new Parameters{PumpCount = 10, TankCount = 20});  
            _form.ShowDialog();
        }
    }
}
