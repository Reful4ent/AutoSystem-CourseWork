using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel;
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
using System.Text.RegularExpressions;

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для ChangeUserRepositoryWindow.xaml
    /// </summary>
    public partial class ChangeUserRepositoryWindow : Window
    {
        IDataManager dataManager;
        public ChangeUserRepositoryWindow(IDataManager dataManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new ChangeUserRepositoryVM(this.dataManager = dataManager);
            if(DataContext is  ChangeUserRepositoryVM changeUserRepositoryVM)
            {
                changeUserRepositoryVM.DeleteSucces += RefreshWindow;
                changeUserRepositoryVM.DeleteFailed += OpenErrorWindow;
                changeUserRepositoryVM.ChangeRoleSucces += RefreshWindow;
                changeUserRepositoryVM.ChangeRoleFailed += OpenErrorWindow;
            }
        }

        public void RefreshWindow()
        {
            if (DataContext is ChangeUserRepositoryVM changeUserRepositoryVM)
            {
                changeUserRepositoryVM.RefreshCourses();
            }
        }
        public void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();

        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();
    }
}
