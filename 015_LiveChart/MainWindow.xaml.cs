using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows;

namespace _015_LiveChart
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        // 필드: 멤버 변수 - 소문자로 시작하는 것이 관례
        private int xCount = 0;

        // 속성(property) - 대문자로 시작하는 것이 관례
        public SeriesCollection SeriesCollection { get; set; }

        public String[] XMarks { get; set; }

        public Func<double, string> Values { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // LiveChart에 Binding 해서 표시할 데이터는 MainWindow 클래스의 속성으로 정의한다.
            SeriesCollection = new SeriesCollection
            {
                new LineSeries        // LineSeries는 선그래프, ColumnSeries는 막대 그래프
                {
                    Title = "2020",
                    Values = new ChartValues<double> {3, 5, 7, 6, 8, 3, 8}
                },
                new LineSeries
                {
                    Title = "2021",
                    Values = new ChartValues<double> {4, 5, 8, 5, 4, 6, 8}
                },
                new LineSeries
                {
                    Title = "2022",
                    Values = new ChartValues<double> {6, 9, 11, 15, 8, 10, 8}
                }
            };

            LineSeries ls = new LineSeries();
            ls.Title = "2023";
            ls.Values = new ChartValues<double> { 1, 2, 4, 5, 6, 5, 10 };
            SeriesCollection.Add(ls);

            XMarks = new string[] { "Kang", "Cho", "Kim", "Song", "Park", "Choi" };
            Values = value => value.ToString("N"); // *람다식
            DataContext = this; // 데이터 바인딩 할때 데이타 컨텍스트를 가져오거나 설정함
        }
    }
}
