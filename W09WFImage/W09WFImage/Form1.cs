namespace W09WFImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap[] images = { Properties.Resources.moon, Properties.Resources.moon2 };
        int n = 0;
        private void btnImageChange_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = images[n];
            n = (n + 1) % 2;
        }
    }
}