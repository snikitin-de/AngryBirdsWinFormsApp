using AngryBirdsWinFormsApp.Models;
using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp.Animals
{
    public class Bird
    {
        private int moveInterval = 5;
        private int borderX;
        private int borderY;
        private int ground = 108;
        private int permissibleFlightDistance = 100;
        private float vx;
        private float vy;
        private float g = 0.2f;
        private float elastic = 0.75f;
        private float speedFactor = 15;
        private bool isBirdFlipped = false;
        private PointF startPosition = new Point(0, 0);
        private PointF centerPoint = new PointF(0f, 0f);
        private Speed speed = new Speed(10, 10);
        private Timer timer;
        private PictureBox bird;

        public Bird(int borderX, int borderY, PictureBox bird, PointF startPosition, Point mouseClick)
        {
            this.borderX = borderX;
            this.borderY = borderY;
            this.bird = bird;
            this.startPosition = startPosition;

            centerPoint = new PointF(bird.Location.X + bird.Size.Width / 2, bird.Location.Y + bird.Size.Height / 2);

            timer = new Timer();
            timer.Interval = moveInterval;
            timer.Tick += Timer_Tick;

            var angle = GetThrowAngle(centerPoint.X, centerPoint.Y, mouseClick.X, mouseClick.Y);
            SetVelocity(angle);

            speed.VX = vx;
            speed.VY = -vy;

            if (speed.VX < 0)
            {
                Flip();
                isBirdFlipped = true;
            }
        }

        private void Flip()
        {
            bird.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private double GetThrowAngle(float x1, float y1, float x2, float y2)
        {
            y2 = borderY - y2;
            y1 = borderY - y1;

            return Math.Atan2(y2 - y1, x2 - x1);
        }

        private void SetVelocity(double angle)
        {
            vx = (float)Math.Cos(angle) * speedFactor;
            vy = (float)Math.Sin(angle) * speedFactor;
        }

        private int LeftSide()
        {
            return -permissibleFlightDistance;
        }

        private int RightSide()
        {
            return borderX + permissibleFlightDistance;
        }

        private int TopSide()
        {
            return -permissibleFlightDistance;
        }

        private int BottomSide()
        {
            return borderY - ground;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Draw()
        {
            bird.Location = new Point((int)centerPoint.X - bird.Size.Width / 2, (int)centerPoint.Y - bird.Size.Height / 2);
        }

        public void Move()
        {
            centerPoint.X += speed.VX;
            centerPoint.Y += speed.VY;

            if (centerPoint.Y + speed.VY > BottomSide())
            {
                speed.VX = speed.VX * elastic;
                speed.VY = -speed.VY * elastic;
            }

            speed.VY += g;
        }

        public void MoveToStart()
        {
            centerPoint = startPosition;

            if (isBirdFlipped)
            {
                Flip();
            }

            Draw();
        }

        public bool IsInsideBorders()
        {
            return centerPoint.X > LeftSide() && centerPoint.X < RightSide() &&
                   centerPoint.Y > TopSide() && centerPoint.Y < BottomSide();
        }

        public void SetGravityAcceleration(float g)
        {
            this.g = g;
        }

        public bool IsIntersect(PictureBox pig)
        {
            return bird.Location.X > pig.Location.X &&
                   bird.Location.X < pig.Location.X + pig.Size.Width &&
                   bird.Location.Y > pig.Location.Y &&
                   bird.Location.Y < pig.Location.Y + pig.Size.Height;
        }
    }
}
