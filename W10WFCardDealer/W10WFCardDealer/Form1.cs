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

            Image? b = Properties.Resources.ResourceManager.GetObject("jack_of_clubs2") as Image;

            card1.Image = b;
        }
    }
}