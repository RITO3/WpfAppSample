using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// MainViewModel
        /// </summary>
        private MainViewModel ViewModel => (MainViewModel)DataContext;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        /// <summary>
        /// ボタンをクリックしたときに呼び出される処理です.
        /// </summary>
        /// <param name="sender">イベント発行者</param>
        /// <param name="e">イベント情報</param>
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Calculate();
        }
    }
}
