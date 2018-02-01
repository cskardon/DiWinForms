namespace BaseFormsEtxc
{
    using System.Windows.Forms;

    public interface IGraphicsForm
    {
        void Show();
        DialogResult ShowDialog();
        void SetParameters(Parameters p);
    }

    public class Parameters
    {
        public int TankCount { get; set; }
        public int PumpCount { get; set; }
    }
}