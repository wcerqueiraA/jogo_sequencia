namespace JogoSequenciaApp
{
    public partial class MainForm : Form
    {
        private List<int> padraoJogo = new List<int>();
        private List<int> padraoClicadoUsuario = new List<int>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            GerarSequencia();
            MostrarSequencia();
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            PiscarBotao(0);
            padraoClicadoUsuario.Add(0);
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            PiscarBotao(1);
            padraoClicadoUsuario.Add(1);
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            PiscarBotao(2);
            padraoClicadoUsuario.Add(2);
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            PiscarBotao(3);
            padraoClicadoUsuario.Add(3);
        }

        public void GerarSequencia()
        {
            Random random = new Random();
            for (int i = 0; i <= 3; i++)
            {
                padraoJogo.Add(random.Next(0, 3));
            }
        }

        public void MostrarSequencia()
        {
            foreach(int numeroCor in padraoJogo)
            {
                PiscarBotao(numeroCor);
            }
        }

        public void PiscarBotao(int botao)
        {
            switch(botao)
            {
                case 0:
                    btnVermelho.BackColor = Color.LightCoral;
                    btnVermelho.Refresh();
                    Thread.Sleep(500);
                    btnVermelho.BackColor = Color.Red;
                    btnVermelho.Refresh();
                    Thread.Sleep(250);
                    break;
                case 1:
                    btnVerde.BackColor = Color.LightGreen;
                    btnVerde.Refresh();
                    Thread.Sleep(500);
                    btnVerde.BackColor = Color.Green;
                    btnVerde.Refresh();
                    Thread.Sleep(250);
                    break;
                case 2:
                    btnAzul.BackColor = Color.LightBlue;
                    btnAzul.Refresh();
                    Thread.Sleep(500);
                    btnAzul.BackColor = Color.Blue;
                    btnAzul.Refresh();
                    Thread.Sleep(250);
                    break;
                case 3:
                    btnAmarelo.BackColor = Color.LightYellow;
                    btnAmarelo.Refresh();
                    Thread.Sleep(500);
                    btnAmarelo.BackColor = Color.Yellow;
                    btnAmarelo.Refresh();
                    Thread.Sleep(250);
                    break;
            }
        }
    }
}
