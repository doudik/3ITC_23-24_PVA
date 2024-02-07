namespace Uvod_Reflexe
{
    public partial class Form1 : Form
    {
        Graphics g;
        Panel p;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            VytvorPanel();
            g = p.CreateGraphics();
            VytvorTlacitkoProVytvoreniNovehoTvaru();

        }

        private void VytvorTlacitkoProVytvoreniNovehoTvaru()
        {
            Button tlacitkoProVytvoreniNovehoTvaru = new Button();
            tlacitkoProVytvoreniNovehoTvaru.Text = "Vytvor novy tvar";
            tlacitkoProVytvoreniNovehoTvaru.Location = new Point(600, 100);
            tlacitkoProVytvoreniNovehoTvaru.Size = new Size(100, 50);
            tlacitkoProVytvoreniNovehoTvaru.Click += TlacitkoProVytvoreniNovehoTvaru_Click;
            this.Controls.Add(tlacitkoProVytvoreniNovehoTvaru);
        }

        private void TlacitkoProVytvoreniNovehoTvaru_Click(object? sender, EventArgs e)
        {
            p.Refresh();
        }

        public void VytvorPanel()
        {
            p = new Panel();
            p.Size = new Size(500, 500);
            p.BackColor = Color.White;
            this.Controls.Add(p);
            p.Paint += new PaintEventHandler(p_Paint);
        }

        private void p_Paint(object? sender, PaintEventArgs e)
        {
            VytvorTvar();
        }

        public void VytvorTvar() {
            Type type = typeof(Tvar);
            Activator.CreateInstance(type, new object[] { 50, 50, rnd.Next(0, 500), rnd.Next(0, 500), Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)) });

        }
    }
}