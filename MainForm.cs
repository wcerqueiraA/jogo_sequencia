using System.Media;

namespace JogoSequenciaApp
{
    public partial class MainForm : Form
    {
        private string caminhoSom = @"G:\Wellington\Videos\Portfolio\JogoSequenciaApp\JogoSequenciaApp\Som\";
        private List<int> sequenciaJogo = new List<int>();
        private List<int> sequenciaUsuario = new List<int>();
        private bool iniciou = false;
        private int nivel = 0;
        private SoundPlayer som;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!iniciou)
            {
                btnIniciar.Hide();
                btnIniciar.Enabled = false;
                lblNivel.Text = $"Nível {nivel}";
                GerarSequencia();
                iniciou = true;

            }
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            PiscarBotao(0);
            sequenciaUsuario.Add(0);
            ChecarResposta(sequenciaUsuario.Count - 1);
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            PiscarBotao(1);
            sequenciaUsuario.Add(1);
            ChecarResposta(sequenciaUsuario.Count - 1);
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            PiscarBotao(2);
            sequenciaUsuario.Add(2);
            ChecarResposta(sequenciaUsuario.Count - 1);
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            PiscarBotao(3);
            sequenciaUsuario.Add(3);
            ChecarResposta(sequenciaUsuario.Count - 1);
        }

        public void GerarSequencia()
        {
            sequenciaJogo = new List<int>();
            sequenciaUsuario = new List<int>();
            Random random = new Random();

            nivel++;
            lblNivel.Text = $"Nível {nivel}";

            for (int i = 0; i <= 3; i++)
            {
                sequenciaJogo.Add(random.Next(0, 4));
            }

            MostrarSequencia();
        }

        public void MostrarSequencia()
        {
            foreach(int numeroCor in sequenciaJogo)
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
                    som = new SoundPlayer(caminhoSom + "red.wav");
                    som.Play();
                    btnVermelho.BackColor = Color.Red;
                    btnVermelho.Refresh();
                    Thread.Sleep(250);
                    break;
                case 1:
                    btnVerde.BackColor = Color.LightGreen;
                    btnVerde.Refresh();
                    Thread.Sleep(500);
                    som = new SoundPlayer(caminhoSom + "green.wav");
                    som.Play();
                    btnVerde.BackColor = Color.Green;
                    btnVerde.Refresh();
                    Thread.Sleep(250);
                    break;
                case 2:
                    btnAzul.BackColor = Color.LightBlue;
                    btnAzul.Refresh();
                    Thread.Sleep(500);
                    som = new SoundPlayer(caminhoSom + "blue.wav");
                    som.Play();
                    btnAzul.BackColor = Color.Blue;
                    btnAzul.Refresh();
                    Thread.Sleep(250);
                    break;
                case 3:
                    btnAmarelo.BackColor = Color.LightYellow;
                    btnAmarelo.Refresh();
                    Thread.Sleep(500);
                    som = new SoundPlayer(caminhoSom + "yellow.wav");
                    som.Play();
                    btnAmarelo.BackColor = Color.Yellow;
                    btnAmarelo.Refresh();
                    Thread.Sleep(250);
                    break;
            }
        }

        public void ChecarResposta(int posicaoAtual)
        {
            
            if (sequenciaJogo[posicaoAtual] == sequenciaUsuario[posicaoAtual])
            {
                if (sequenciaJogo.Count == sequenciaUsuario.Count)
                {
                    som = new SoundPlayer(caminhoSom + "correct.wav");
                    som.Play();
                    Thread.Sleep(1000);
                    GerarSequencia();
                }
            }
            else
            {
                som = new SoundPlayer(caminhoSom + "wrong.wav");
                som.Play();
                GameOverForm gameOver = new GameOverForm();
                gameOver.ShowDialog();
                btnIniciar.Show();
                btnIniciar.Enabled = true;
            }

        }
    }
}
