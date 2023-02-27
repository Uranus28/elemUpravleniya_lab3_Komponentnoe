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
using System.Windows.Threading;

namespace WpfWatch
{
    /// <summary>
    /// Логика взаимодействия для WpfWatch.xaml
    /// </summary>
    public partial class WpfWatch : UserControl
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public WpfWatch()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            //значение Interval задается равным 1 миллисекунде
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now;

            //положения стрелок

            //угол секундной стрелки от кол-ва полных секунд
            Second.Angle = 0.006 * time.Millisecond+time.Second*6;

            //угол минутной стрелки от кол-ва полных минут + угол секунд, приведенный к долям текущей минуты
            Minute.Angle = 6 * time.Minute + Second.Angle / 60;

            //угол полных часов + угол минут, приведенный к долям текущего часа
            Hour.Angle = 30 * (time.Hour % 12) + Minute.Angle / 60;
        }
    }
}
