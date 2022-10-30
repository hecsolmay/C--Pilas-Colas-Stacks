using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Car_Game
{
    public partial class Form1 : Form
    {
        Stopwatch oSW = new Stopwatch();

        string[] colores = new string[]
            {"rojo","azul","verde","amarillo","cafe","blanco","morado","gris"};

        Color[] colorOptions = new Color[]
            {Color.Red,Color.Blue,Color.Green,Color.Yellow,Color.Brown,Color.White,
            Color.Purple,Color.Gray};

        Queue<Color> colaColores = new Queue<Color>();
        Queue<string> colaCarros = new Queue<string>();
        Random rd = new Random();
        private int random_option;
        private int contador = 0, autosPintados = 0;
        private int limite = 20;
        private List<Player> playesList = new List<Player>();
        private Player player = new Player();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Dame tu nombre");
            player.Name = nombre;
            autosPintados = 0;
            limite = 20;
            oSW.Start();
            timer1.Enabled = true;
            timerCars.Enabled = true;
            addElement();
            lblMensaje.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            string hours = ts.Hours.ToString() + ":";
            string minutes = ts.Minutes.ToString() + ":";
            string seconds = ts.Seconds.ToString();
            txtHours.Text = hours.Length < 3 ? "0" + hours : hours;
            txtMinutes.Text = minutes.Length < 3 ? "0" + minutes : minutes;
            txtSeconds.Text = seconds.Length < 2 ? "0" + seconds : seconds;
            contador++;

        }

        private void timerCars_Tick(object sender, EventArgs e)
        {
            colaAutos();

            lblMensaje.Text = $"Autos en cola : {colaCarros.Count}";

            if (contador == limite)
            {
                addElement();
            }
            carsStatus();
        }


        private void carsStatus()
        {
            if (colaCarros.Count == 5)
            {
                oSW.Stop();
                var elapsedMinutes = oSW.Elapsed.Minutes;
                var elapsedSeconds = oSW.Elapsed.Seconds;
                var elapsedHours = oSW.Elapsed.Hours;
                string time = $"{elapsedHours}:{elapsedMinutes}:{elapsedSeconds}";
                timer1.Enabled = false;
                player.Time = time;
                player.CarrosPintados = autosPintados;
                playesList.Add(player);
                oSW.Reset();

                timerCars.Enabled = false;
                colaCarros.Clear();
                colaColores.Clear();
                contador = 0;

                string record = "";

                foreach (var i in playesList)
                {
                    string valor = $"{i.Name}:  {i.Time} Autos Pintados {i.CarrosPintados}\n";
                    record += valor;
                }

                lblRecords.Text = record;
                MessageBox.Show("El juego ha terminado");

            }
        }

        private void colaAutos()
        {
            visibleFalse();
            var coches = colaCarros.ToArray();
            var colores = colaColores.ToArray();
            for (int i = 0; i < colaCarros.Count; i++)
            {
                int opcion = i + 1;
                switch (opcion)
                {
                    case 1:
                        lblAuto1.Visible = true;
                        lblAuto1.Text = coches[i];
                        lblAuto1.BackColor = colores[i];
                        pboxAuto1.Visible = true;
                        continue;
                    case 2:
                        lblAuto2.Visible = true;
                        lblAuto2.Text = coches[i];
                        lblAuto2.BackColor = colores[i];
                        pboxAuto2.Visible = true;
                        continue;
                    case 3:
                        lblAuto3.Visible = true;
                        lblAuto3.Text = coches[i];
                        lblAuto3.BackColor = colores[i];
                        pboxAuto3.Visible = true;
                        continue;
                    case 4:
                        lblAuto4.Visible = true;
                        lblAuto4.Text = coches[i];
                        lblAuto4.BackColor = colores[i];
                        pboxAuto4.Visible = true;
                        continue;
                    case 5:
                        lblAuto5.Visible = true;
                        lblAuto5.Text = coches[i];
                        lblAuto5.BackColor = colores[i];
                        pboxAuto5.Visible = true;
                        continue;
                    default:
                        continue;
                }
            }
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "rojo") eliminarElemento();

        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "amarillo") eliminarElemento();
        }


        private void btnVerde_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "verde") eliminarElemento();
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "cafe") eliminarElemento();
        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "blanco") eliminarElemento();
        }

        private void btnMorado_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "morado") eliminarElemento();
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "azul") eliminarElemento();
        }

        private void btnGris_Click(object sender, EventArgs e)
        {
            if (colaCarros.Peek() == "gris") eliminarElemento();
        }

        private void eliminarElemento()
        {
            lblAtendido.Text = colaCarros.Dequeue();
            lblAtendido.Visible = true;
            pboxAtendido.Visible = true;
            pboxAtendido.BackColor = colaColores.Dequeue();
            contador = 0;
            autosPintados++;
            txtAutosPintados.Text = autosPintados.ToString();
            addElement();
        }


        private void visibleFalse()
        {
            lblAuto1.Visible = false;
            lblAuto2.Visible = false;
            lblAuto3.Visible = false;
            lblAuto4.Visible = false;
            lblAuto5.Visible = false;
            pboxAuto1.Visible = false;
            pboxAuto2.Visible = false;
            pboxAuto3.Visible = false;
            pboxAuto4.Visible = false;
            pboxAuto5.Visible = false;
        }


        public void addElement()
        {
            random_option = rd.Next(0, colores.Length - 1);
            colaCarros.Enqueue(colores[random_option]);
            colaColores.Enqueue(colorOptions[random_option]);
            txtAutosPintados.Text = autosPintados.ToString();
            contador = 0;
            if (autosPintados % 3 == 0 && autosPintados != 0)
            {
                if (limite - 2 > 0) limite = limite - 2;
            }
        }

    }
}