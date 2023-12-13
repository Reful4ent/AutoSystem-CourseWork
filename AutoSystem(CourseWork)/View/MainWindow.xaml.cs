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
using System.Windows.Shapes;

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            My_Courses.ItemsSource = new[] {new {Name = "MathCourse", TypeOf= "Math", Persent = 24 },
                new {Name = "russianLanguage", TypeOf= "russian", Persent = 45 } };
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();

        private void Profile_Role_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
