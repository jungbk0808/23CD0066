namespace W08WFLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnGenerate(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] num = new int[6] { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < num.Length; i++)
            {
                int n = 0;
                do {
                    n = r.Next(1, 46); //1부터 45까지의 수
                } while(num.Contains(n));
                num[i] = n;
            }
            Array.Sort(num);
            Num1.Text = num[0].ToString();
            Num2.Text = num[1].ToString();
            Num3.Text = num[2].ToString();
            Num4.Text = num[3].ToString();
            Num5.Text = num[4].ToString();
            Num6.Text = num[5].ToString();
        }
    }
}