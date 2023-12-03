using System.Media;
using AngryBirdsWinFormsApp.Animals;
using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        private Bird bird;
        private Pig pig;
        private int renderInterval = 1;
        private int score = 0;
        private bool isMouseClicked = false;
        private string birdColor = "red";
        private Point birdStartCenterPosition = new Point(70, 374);
        private PointF birdStartPosition = new Point(0, 0);
        private Random random = new Random();
        private SoundPlayer soundPlayerMainTheme = new SoundPlayer(Properties.Resources.mainTheme);

        public MainForm()
        {
            InitializeComponent();

            var renderTimer = new Timer();
            renderTimer.Interval = renderInterval;
            renderTimer.Enabled = true;
            renderTimer.Tick += (s, o) => { renderPictureBox.Refresh(); };

            slingPictureBox.Parent = renderPictureBox;
            slingPictureBox.BackColor = Color.Transparent;
            birdPictureBox.Parent = renderPictureBox;
            birdPictureBox.BackColor = Color.Transparent;
            birdPictureBox.BringToFront();
            pigPictureBox.Parent = renderPictureBox;
            pigPictureBox.BackColor = Color.Transparent;
            cube1PictureBox.Parent = renderPictureBox;
            cube1PictureBox.BackColor = Color.Transparent;
            cube2PictureBox.Parent = renderPictureBox;
            cube2PictureBox.BackColor = Color.Transparent;
            cube3PictureBox.Parent = renderPictureBox;
            cube3PictureBox.BackColor = Color.Transparent;
            cube4PictureBox.Parent = renderPictureBox;
            cube4PictureBox.BackColor = Color.Transparent;
            cube5PictureBox.Parent = renderPictureBox;
            cube5PictureBox.BackColor = Color.Transparent;
            cube6PictureBox.Parent = renderPictureBox;
            cube6PictureBox.BackColor = Color.Transparent;
            scoreLabel.Parent = renderPictureBox;
            scoreLabel.ForeColor = Color.FromArgb(82, 103, 44);
            scoreLabel.BackColor = Color.Transparent;
        }

        //  Включение двойной буферизации для всех элементов управления
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020;
                return createParams;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var borderX = renderPictureBox.Width;
            var birdCenterPoint = GetPictureBoxCenterPoint(birdPictureBox);

            pig = new Pig(borderX, pigPictureBox);
            birdStartPosition = birdCenterPoint;
            soundPlayerMainTheme.PlayLooping();
        }

        private void renderPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (birdStartPosition == GetPictureBoxCenterPoint(birdPictureBox))
            {
                var borderX = renderPictureBox.Width;
                var borderY = renderPictureBox.Height;

                bird = new Bird(borderX, borderY, birdPictureBox, birdStartCenterPosition, e.Location);

                switch (birdColor)
                {
                    case "red": bird.SetGravityAcceleration(0.2f); break;
                    case "yellow": bird.SetGravityAcceleration(0.1f); break;
                    case "white": bird.SetGravityAcceleration(0.4f); break;
                    case "black": bird.SetGravityAcceleration(0.3f); break;
                }

                bird.Start();

                isMouseClicked = true;
            }
        }

        private void renderPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isMouseClicked)
            {
                bird.Draw();

                if (!bird.IsInsideBorders())
                {
                    bird.MoveToStart();

                    isMouseClicked = false;
                }

                if (bird.IsIntersect(pigPictureBox))
                {
                    score++;
                    scoreLabel.Text = $"Score: {score}";

                    bird.MoveToStart();
                    CreatePig();

                    isMouseClicked = false;
                }
            }

            pig.Draw();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (birdStartPosition == GetPictureBoxCenterPoint(birdPictureBox))
            {
                Bitmap birdBitmap = Properties.Resources.redBird;

                switch (e.KeyCode)
                {
                    case Keys.D1:
                        {
                            birdBitmap = Properties.Resources.redBird;
                            birdColor = "red";
                            break;
                        }
                    case Keys.D2:
                        {
                            birdBitmap = Properties.Resources.yellowBird;
                            birdColor = "yellow";
                            break;
                        }
                    case Keys.D3:
                        {
                            birdBitmap = Properties.Resources.whiteBird;
                            birdColor = "white";
                            break;
                        }
                    case Keys.D4:
                        {
                            birdBitmap = Properties.Resources.blackBird;
                            birdColor = "black";
                            break;
                        }
                }

                birdPictureBox.Size = GetBitmapMaxSize(birdBitmap);
                birdPictureBox.Image = birdBitmap;
                birdPictureBox.Location = new Point((int)birdStartPosition.X - birdPictureBox.Size.Width / 2, (int)birdStartPosition.Y - birdPictureBox.Size.Height / 2);
                birdPictureBox.BringToFront();
            }
        }

        private Size GetBitmapMaxSize(Bitmap bitmap)
        {
            var maxDimension = Math.Max(bitmap.Size.Width, bitmap.Size.Height);

            return new Size(maxDimension, maxDimension);
        }

        private PointF GetPictureBoxCenterPoint(PictureBox pictureBox)
        {
            var centerX = pictureBox.Location.X + pictureBox.Width / 2;
            var centerY = pictureBox.Location.Y + pictureBox.Height / 2;

            return new PointF(centerX, centerY);
        }

        private void CreatePig()
        {
            var pigBitmaps = new List<Bitmap>()
            {
                Properties.Resources.pig,
                Properties.Resources.mexicanPig,
                Properties.Resources.coolPig,
                Properties.Resources.rabbitPig
            };

            pigPictureBox.Image = pigBitmaps[random.Next(0, pigBitmaps.Count)];
            pig.Generate();
        }
    }
}