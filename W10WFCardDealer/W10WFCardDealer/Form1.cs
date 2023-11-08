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

            //Image? b = Properties.Resources.ResourceManager.GetObject("jack_of_clubs2") as Image;

            Random r = new Random();
            //int n = r.Next(52);
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                nums[i] = r.Next(52);
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            //Image? b = Properties.Resources.ResourceManager.GetObject(GetCardName(n)) as Image;
            Image?[] b = new Image?[5];
            for (int i = 0; i < 5; i++)
            {
                b[i] = Properties.Resources.ResourceManager.GetObject(GetCardName(nums[i])) as Image;
            }
            card1.Image = b[0];
            card2.Image = b[1];
            card3.Image = b[2];
            card4.Image = b[3];
            card5.Image = b[4];
        }
        protected string GetCardName(int n)
        {
            //TODO: �ϵ� �ڵ� ������ ��
            string suit = string.Empty; //""�� �ǹ�
            switch (n / 13)
            {
                case 0: suit = "spades"; break;
                case 1: suit = "diamonds"; break;
                case 2: suit = "hearts"; break;
                case 3: suit = "clubs"; break;
                default: suit = "error"; break;
            }
            string rank = string.Empty;
            switch (n % 13)
            {
                case 0: rank = "ace"; break;
                case int c when (c > 0 && c < 10):
                    rank = (n % 13 + 1).ToString();
                    break;
                case 10: rank = "jack"; break;
                case 11: rank = "queen"; break;
                case 12: rank = "king"; break;
                default: rank = "error"; break;
            }
            if (n % 13 >= 10 && n % 13 <= 12)
            {
                suit += "2"; //jack, queen, king�̸� 2�� �ٿ��� ��
            }

            //return rank + "_of_" + suit;
            //return string.Format("{0}_of_{1}", rank, suit);
            return $"{rank}_of_{suit}";
        }
    }
}