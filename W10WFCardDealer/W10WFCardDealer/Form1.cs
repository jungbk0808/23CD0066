namespace W10WFCardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ctor ġ�� ���ϸ� ������ �ڵ� �������
        private void OnDeal(object sender, EventArgs e)
        {
            //���ڷ� �� �ִ� �ڵ����� ����ٸ� �տ� �ٿ���
            //Bitmap b = Properties.Resources._2_of_clubs;

            //���ڿ� �κ��� ���� �����̸� null�� �� �ִ�. ?�� null�� �� �ִ��� �ǹ�.
            //as�� Ÿ��ĳ����() ���� �����ϴٰ� ��
            //? ��� var�� ������ Ÿ������ ���� �ڵ� nullable
            //Bitmap? b = Properties.Resources.ResourceManager.GetObject("10_of_diamonds") as Bitmap;

            Image? b = Properties.Resources.ResourceManager.GetObject("jack_of_clubs2") as Image;

            card1.Image = b;
        }
    }
}