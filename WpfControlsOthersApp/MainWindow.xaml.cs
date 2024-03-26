using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlsOthersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> mobileApps = new List<string>()
        {
            "Sber Online", "Yandex Taxi", "Telegram", "Vk Video", "Discord"
        };
        public MainWindow()
        {
            InitializeComponent();

            TreeViewItem mobileAppsNode = new() { Header = "Mobile Apps" };
            foreach(var a in mobileApps)
                mobileAppsNode.Items.Add(a);
            treeApps.Items.Add(mobileAppsNode);

            calendar.BlackoutDates
                    .Add(new CalendarDateRange(new DateTime(2024, 3, 2),
                                               new DateTime(2024, 3, 4)));
            calendar.BlackoutDates
                    .Add(new CalendarDateRange(new DateTime(2024, 3, 8),
                                               new DateTime(2024, 3, 8)));
        }
    }
}