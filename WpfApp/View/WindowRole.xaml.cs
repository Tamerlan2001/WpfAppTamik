using System.Windows;
using WpfApp.ViewModel;
namespace WpfApp.View
{
 /// <summary>
 /// Логика взаимодействия для WindowEmployee.xaml
 /// </summary>
 public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            RoleViewModel vmRole = new RoleViewModel();
            lvRole.ItemsSource = vmRole.ListRole;
        }
    }
}