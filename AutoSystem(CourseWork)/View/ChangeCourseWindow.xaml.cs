﻿using System;
using AutoSystem_CourseWork_.ViewModel.DataManager;
using AutoSystem_CourseWork_.ViewModel;
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
using AutoSystem_CourseWork_.ViewModel.Services;

namespace AutoSystem_CourseWork_.View
{
    /// <summary>
    /// Логика взаимодействия для ChangeCourseWindow.xaml
    /// </summary>
    public partial class ChangeCourseWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public ChangeCourseWindow(IDataManager dataManager,IServiceManager serviceManager)
        {
            InitializeComponent();
            MouseLeftButtonDown += Navbar_MouseLeftButtonDown;
            DataContext = new ChangeCoursesVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            if(DataContext is ChangeCoursesVM changeCoursesVM)
            {
                changeCoursesVM.DeleteCourseSucces += RefreshWindow;
                changeCoursesVM.DeleteCourseFailed += OpenErrorWindow;
                changeCoursesVM.DeleteTestSucces += RefreshWindow;
                changeCoursesVM.DeleteTestFailed += OpenErrorWindow;
                changeCoursesVM.DeleteQuestionSucces += RefreshWindow;
                changeCoursesVM.DeleteQuestionFailed += OpenErrorWindow;
                changeCoursesVM.AddCourseSucces += RefreshWindow;
                changeCoursesVM.AddCourseFailed += OpenErrorWindow;
                changeCoursesVM.AddTestSucces += RefreshWindow;
                changeCoursesVM.AddTestFailed += OpenErrorWindow;
                changeCoursesVM.AddAnswerQuestionSucces += RefreshWindow;
                changeCoursesVM.AddAnswerQuestionFailed += OpenErrorWindow;
               
            }
        }

        public void RefreshWindow()
        {
            if (DataContext is ChangeCoursesVM changeCoursesVM)
            {
                changeCoursesVM.RefreshCourses();
            }
        }

        public void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }


        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(dataManager,serviceManager);
            mainWindow.Show();
            this.Close();
        }
        private void Minimize_MouseDown(object sender, MouseButtonEventArgs e) => this.WindowState = WindowState.Minimized;

        private void Navbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => this.DragMove();
    }
}
