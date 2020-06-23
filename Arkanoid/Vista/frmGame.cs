using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FrmGame : Form
    {
        private CustomPictureBox[,] _cpb;
        private PictureBox _ball;
        private bool[,] _arrayExist;
        private int _live = 3;
        private GetNickname _gn;

        public FrmGame()
        {
            InitializeComponent();

            Height = ClientSize.Height;
            Width = ClientSize.Width;

            WindowState = FormWindowState.Normal;
            KeyDown += frmGame_KeyDown;
            int x = (int) (Width * 0.50);
            int y = (int) (Height * 0.20);
            picSpaceShip.Location = new Point(x, y);
        }

        //Movimiento de la plataforma con teclado
        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!GameData.gamestarted)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Space:
                            GameData.gamestarted = true;
                            tmrSpeed.Start();
                            break;
                        default:
                            throw new WrongKeyPressedException("Presione la Barra espaciadora para iniciar");
                    }
                }
            }
            catch (WrongKeyPressedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            if (!GameData.gamestarted)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (picSpaceShip.Location.X <= Width * 0.75 - picSpaceShip.Width)
                            picSpaceShip.Left += 10;
                        _ball.Left = picSpaceShip.Left + (picSpaceShip.Width / 2) - (_ball.Width / 2);
                        break;
                    case Keys.Left:
                        if (picSpaceShip.Location.X >= Width * 0.40 - picSpaceShip.Width)
                            picSpaceShip.Left -= 10;
                        _ball.Left = picSpaceShip.Left + (picSpaceShip.Width / 2) - (_ball.Width / 2);
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (picSpaceShip.Location.X <= Width * 0.75 - picSpaceShip.Width)
                            picSpaceShip.Left += 10;
                        break;
                    case Keys.Left:
                        if (picSpaceShip.Location.X >= Width * 0.40 - picSpaceShip.Width)

                            picSpaceShip.Left -= 10;
                        break;
                }
            }
        }

        //obteniendo el ID del jugador
        private void GettingScore()
        {
            string query = $"SELECT idPlayer FROM PLAYER WHERE nickname = '{_gn.CurrentPlayer.Nickname}'";

                var dt = ArkanoidDBcn.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var idPlayer = Convert.ToInt32(dr[0].ToString());

                ArkanoidDBcn.ExecuteNonquery("INSERT INTO SCORE(idPlayer,score) VALUES " +
                                             $"({idPlayer},{GameData.score})");

                if (MessageBox.Show($"Su puntuación de {GameData.score}, se ha registrado correctamente",
                    "Arkanoid message", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    FrmMainMenu menu = new FrmMainMenu();
                    menu.Show();
                    Dispose();

            }
        }
        

        private void frmGame_Load(object sender, EventArgs e)
        {
            //Setting 0 to score and ticks for a new game
            GameData.score = 0;
            GameData.AmountTicks = 0;
            
            _gn = new GetNickname();
                _gn.Left = Width / 2 - _gn.Width / 2;
                _gn.Top = Height / 2 - _gn.Height / 2;

                _gn.Get = (nick) =>
                {
                    if (PlayerController.CreatePlayer(nick))
                    {
                        MessageBox.Show($"Bienvenido de nuevo {nick}");
                    }
                    else
                    {
                        MessageBox.Show($"Gracias por registrarte {nick}");
                    }
                };
                Controls.Add(_gn);
                _gn.BringToFront();

                picSpaceShip.BackgroundImage = Image.FromFile("../../Resources/barra2loop.gif");
                picSpaceShip.BackgroundImageLayout = ImageLayout.Stretch;
                picSpaceShip.Top = (Height - picSpaceShip.Height) - 130;
                LoadBall();
                LoadTiles();
                lblScore.Text = GameData.score.ToString();
            }

            //Llenamos la matriz con los bloques 
            private void LoadTiles()
            {
                int xAxis = 6;
                int yAxis = 4;
                //aqui reducimos el tamaño de los bloques para que pueda encajar en el espacio asignado del juego
                int pbHeight = (int) (Height * 0.3) / yAxis;
                int pbWidth = (int) (Width / 2.15) / xAxis;
                string number = "7";
                int block;
                _cpb = new CustomPictureBox[yAxis, xAxis];
                for (int i = 0; i < yAxis; i++)
                {
                    block = RandomNumber(ref number);
                    number += block;
                    for (int j = 0; j < xAxis; j++)
                    {
                        _cpb[i, j] = new CustomPictureBox();

                        if (block == 0)
                        {
                            _cpb[i, j].hits = 3;
                            _cpb[i, j].Tag = "ThreeHit";
                        }
                        else if (block == 6)
                        {
                            _cpb[i, j].hits = 2;
                            _cpb[i, j].Tag = "TwoHit";
                        }
                        else
                        {
                            _cpb[i, j].hits = 1;
                            _cpb[i, j].Tag = "OneHit";
                        }

                        _cpb[i, j].Height = pbHeight;
                        _cpb[i, j].Width = pbWidth;

                        //Aqui lo que hicimos fue que le cambiamos las coordenadas de aparicion de los bloques, para que 
                        //encajara con el espacio asignado del juego
                        _cpb[i, j].Left = (int) (Width * 0.30) + j * pbWidth;
                        _cpb[i, j].Top = (int) (Height * 0.22) + i * pbHeight;
                        _cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/_" + (block) + ".png");
                        _cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                        _cpb[i, j].BackColor = Color.Transparent;
                        Controls.Add(_cpb[i, j]);
                    }
                }
            }

            //Funcion para devolver un numero random y poder llenar las filas de bloques de acuerdo al numero
            //que nos salga
            private int RandomNumber(ref string number)
            {
                Random rnd = new Random();
                int newNumber;
                bool diff = true;
                string ct;
                do
                {
                    if (number.Length == 1)
                    {
                        newNumber = rnd.Next(7);
                        diff = false;
                    }
                    else
                    {
                        newNumber = rnd.Next(7);
                        ct = $"{newNumber}";
                        if (!number.Contains(ct))
                        {
                            diff = false;
                        }
                    }
                } while (diff);

                return newNumber;
            }

            private void LoadBall()
            {
                _ball = new PictureBox();
                _ball.Width = _ball.Height = 20;
                _ball.BackgroundImage = Image.FromFile("../../Resources/pelota.png");
                _ball.BackgroundImageLayout = ImageLayout.Stretch;
                _ball.BackColor = Color.Transparent;
                _ball.Top = picSpaceShip.Top - _ball.Height;
                _ball.Left = picSpaceShip.Left + (picSpaceShip.Width / 2) - (_ball.Width / 2);
                Controls.Add(_ball);
            }

            private void tmrSpeed_Tick(object sender, EventArgs e)
            {
                //ticks realizados para calcular el score
                GameData.AmountTicks += 0.09;

                if (!GameData.gamestarted)
                    return;
                try
                {
                    _ball.Left += GameData.dirX;
                    _ball.Top += GameData.dirY;
                    Bounceball();
                }
                catch (OutOfBordersException exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void Liveaction()
        {
            try
            {

                tmrSpeed.Stop();
                --_live;

                if (_live == 2)
                    heart3.Visible = false;
                if (_live == 1)
                    heart2.Visible = false;

                GameData.gamestarted = false;
                _ball.Hide();

                if (_live == 0)
                {
                    heart1.Visible = false;
                    MessageBox.Show("Has perdido, Score final: " + GameData.score, "Arkanoid Message",
                        MessageBoxButtons.OK);
                    Dispose();
                    FrmMainMenu GameOver = new FrmMainMenu();
                    GameOver.Show();
                    throw new NoRemainingLifeException("");
                }
                else
                {
                    MessageBox.Show("Has perdido una vida, re manco", "Arkanoid message");
                    KeyDown += frmGame_KeyDown;
                    LoadBall();
                    tmrSpeed.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    

        private void Bounceball()
        {
            //Si la bola ha caido realizamos el método de Liveaction para ver si solo se le resta una vida o si 
            //ha perdido ya que no le quedan vidas
            if (_ball.Bottom > (int) (Height * 0.77) + _ball.Height)
            {
                if (_live != 0)
                    Liveaction();
            }

            //Si choca con la region establecida para el juego hacemos que haga el rebote en x
            if (_ball.Left < Width * 0.30 || _ball.Right > Width * 0.75)
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            //Si choca con la region establecida para el juego hacemos que haga el rebote en y
            if (_ball.Top < Height - Height * 0.77)
            {
                GameData.dirY = -GameData.dirY;
                return;
            }

            //Si rebota con la plataforma hacemos que haga el rebote en y
            if (_ball.Bounds.IntersectsWith(picSpaceShip.Bounds))
                GameData.dirY = -GameData.dirY;

            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (_cpb[i, j] != null && _ball.Bounds.IntersectsWith(_cpb[i, j].Bounds))
                    {
                        //Calculando el score para mostrar
                        GameData.score += (int) (_cpb[i, j].hits * GameData.AmountTicks);
                        _cpb[i, j].hits--;

                        //Si el numero de hits del bloque es cero y la bola los golpea lo quitamos
                        if (_cpb[i, j].hits == 0)
                        {
                            Controls.Remove(_cpb[i, j]);
                            _cpb[i, j] = null;
                        }
                        //Si el numero de hits del bloque es 3 y la bola los golpea se le cambia el sprite
                        //del bloque
                        else if (_cpb[i, j].Tag.Equals("ThreeHit") && _cpb[i, j].hits == 2)
                        {
                            _cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/_01.png");
                        }
                        //Si el numero de hits del bloque es 3 y la bola los golpea se le cambia el sprite
                        //del bloque
                        else if (_cpb[i, j].Tag.Equals("ThreeHit") && _cpb[i, j].hits == 1)
                        {
                            _cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/_02.png");
                        }
                        //Si el numero de hits del bloque es 2 y la bola los golpea se le cambia el sprite
                        //del bloque
                        else if (_cpb[i, j].Tag.Equals("TwoHit"))
                        {
                            _cpb[i, j].BackgroundImage = Image.FromFile("../../Resources/_61.png");
                        }

                        GameData.dirY = -GameData.dirY;

                        //mostrando score
                        lblScore.Text = GameData.score.ToString();
                        return;
                    }
                }
            }

            if (GameOver())
            {
                tmrSpeed.Stop();
                GettingScore();
            }
        }

        private bool GameOver()
        {
            //Comprobamos si la matriz de bloques esta vacia para saber si el jugador gano
            for (int i = 0; i < 4; i++)
            for (int j = 0; j < 6; j++)
                if (_cpb[i, j] != null)
                {
                    return false;
                }

            return true;
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Estas seguro que deseas salir al menú ?", "Arkanoid Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmMainMenu menu = new FrmMainMenu();
                menu.Show();
                Dispose();
            }
        }
    }
}

