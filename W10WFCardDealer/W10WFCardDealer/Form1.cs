namespace W10WFCardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ctor 치고 탭하면 생성자 자동 만들어줌
        private void OnDeal(object sender, EventArgs e)
        {
            //숫자로 된 애는 자동으로 언더바를 앞에 붙여줌
            //Bitmap b = Properties.Resources._2_of_clubs;

            //문자열 부분이 없는 파일이면 null일 수 있다. ?는 null일 수 있다의 의미.
            //as가 타입캐스팅() 보다 안전하다고 함
            //? 대신 var를 데이터 타입으로 쓰면 자동 nullable
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
            //TODO: 하드 코딩 변경할 것
            string suit = string.Empty; //""의 의미
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
                suit += "2"; //jack, queen, king이면 2를 붙여야 함
            }

            //return rank + "_of_" + suit;
            //return string.Format("{0}_of_{1}", rank, suit);
            return $"{rank}_of_{suit}";
        }
    }
}