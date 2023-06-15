using System.Windows;

namespace _014_SnakeBite
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Game g = new Game();
            g.Show();   // modaless 창 두개 같이 사용 가능
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
