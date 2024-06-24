namespace JogoSequenciaApp
{
    public partial class MainForm : Form
    {
        private List<int> padraoJogo = new List<int>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {

        }

        private void btnVerde_Click(object sender, EventArgs e)
        {

        }

        private void btnAzul_Click(object sender, EventArgs e)
        {

        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {

        }

        public void GerarSequencia()
        {
            Random random = new Random();
            for (int i = 0; i <= 3; i++)
            {
                padraoJogo.Add(random.Next(0, 3));
            }
        }
    }
}
