using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// MainViewModel
    /// MainWindow.xamlとバインドさせるViewModelです.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 入力1
        /// </summary>
        public int Input1 { get; set; }

        /// <summary>
        /// 入力2
        /// </summary>

        public int Input2 { get; set; }

        /// <summary>
        /// 結果
        /// </summary>
        private int _result;
        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (_result == value)
                {
                    return;
                }

                _result = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }

        /// <summary>
        /// 計算ロジック
        /// </summary>
        private readonly CalculateLogic _calculateLogic;

        /// <summary>
        /// コンストラクタ.
        /// </summary>
        public MainViewModel()
        {
            _calculateLogic = new CalculateLogic();
        }

        /// <summary>
        /// 計算を行います.
        /// </summary>
        public void Calculate()
        {
            Result = _calculateLogic.Add(Input1, Input2);
        }
    }
}
