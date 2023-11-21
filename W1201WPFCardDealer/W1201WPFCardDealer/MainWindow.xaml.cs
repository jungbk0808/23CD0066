using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W1201WPFCardDealer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnDeal(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int[] n = new int[5] { -1, -1, -1, -1, -1 };
            for (int i = 0; i < n.Length; i++)
            {
                int num = 0;
                do
                {
                    num = random.Next(52);
                } while (n.Contains(num));
                n[i] = num;
            }

            Array.Sort(n);

            string[] resource = new string[n.Length];
            BitmapImage[] image = new BitmapImage[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                resource[i] = $"Images/{GetCardName(n[i])}";
                image[i] = new BitmapImage(
                    new Uri(resource[i], UriKind.RelativeOrAbsolute)
                );
            }

            Card1.Source = image[0];
            Card2.Source = image[1];
            Card3.Source = image[2];
            Card4.Source = image[3];
            Card5.Source = image[4];
        }
        private string GetCardName(int c)
        {
            string suit = "";
            switch (c / 13)
            {
                case 0: suit = "spades"; break;
                case 1: suit = "diamonds"; break;
                case 2: suit = "hearts"; break;
                case 3: suit = "clubs"; break;
            }

            string rank = "";
            switch (c % 13)
            {
                case 0: rank = "ace"; break;
                case int n when (n > 0 && n < 10):
                    rank = (c % 13 + 1).ToString(); break;
                case 10: rank = "jack"; break;
                case 11: rank = "queen"; break;
                case 12: rank = "king"; break;
            }

            //--------------------------------------------
            // Jack, Queen, King일 때 suit 뒤에 2 붙이기
            //--------------------------------------------
            // 방법 0. Windows Forms 때처럼 rank switch 문에서 suit에 "2" 추가

            // 방법 1. Contains 사용
            //if (new int[] { 10, 11, 12 }.Contains(c % 13)) 

            // 방법 2. IndexOf(), FindIndex() 함수 사용해도 됨

            // 방법 3. Lambda Expression을 사용하여 c % 13 값이 10, 11, 12와 일치하는지 검사
            // { x | x는 정수, 0 < x < 3 } -> 람다 함수가 요런 애들이랑 비슷한 역할을 함
            if (Array.Exists(new int[] { 10, 11, 12 }, x => x == c % 13))
                return string.Format("{0}_of_{1}2.png", rank, suit);
            else
                return string.Format("{0}_of_{1}.png", rank, suit);
        }
    }
}
