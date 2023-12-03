namespace AngryBirdsWinFormsApp.Animals
{
    public class Pig
    {
        private int borderX;
        private int centerScreen;
        private int ground = 334;
        private PointF centerPoint = new PointF(0f, 0f);
        private PictureBox pig;
        private Random random = new Random();

        public Pig(int borderX, PictureBox pig)
        {
            this.borderX = borderX;
            this.pig = pig;

            centerScreen = borderX / 2;
            Generate();
        }

        public void Draw()
        {
            pig.Location = new Point((int)centerPoint.X - pig.Size.Width / 2, (int)centerPoint.Y - pig.Size.Height / 2);
        }

        public void Generate()
        {
            centerPoint = new PointF(random.Next(centerScreen, borderX - pig.Size.Width / 2), ground - pig.Size.Height / 2);
        }
    }
}
