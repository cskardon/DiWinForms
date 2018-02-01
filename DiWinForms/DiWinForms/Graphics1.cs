namespace DiWinForms
{
    using System.Windows.Forms;
    using BaseFormsEtxc;

    public partial class Graphics1 : Form, IGraphicsForm
    {
        private Parameters _parameters;

        public Graphics1()
        {
            InitializeComponent();
        }

        #region Implementation of IGraphicsForm

        public void SetParameters(Parameters p)
        {
            _parameters = p;
            _lblTanks.Text = $"Tanks : {p.TankCount}";
            _lblPumps.Text = $"Pumps : {p.PumpCount}";
        }

        #endregion
    }
}