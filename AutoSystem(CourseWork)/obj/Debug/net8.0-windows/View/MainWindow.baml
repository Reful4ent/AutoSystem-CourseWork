   M S B A M L   `   `   `  ����Q  MAutoSystem(CourseWork), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AutoSystem_CourseWork_.ViewAutoSystem_CourseWork_.View  5   	   ,    &AutoSystem_CourseWork_.View.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AutoSystem_CourseWork_.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $	��700��6   $
��1200��6)   $	��700��66   $
��1200��6F    � WindowStyle$
 None=�6V    � 
ResizeMode$ NoResize=�6i    � 	Resources 5
       �� Source�� 5   
   $G A/AutoSystem(CourseWork);component/View/ViewStyles/MainStyles.xaml?�6   %    6j   .��5      �    Background_Window#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��80 �6   6*   �� 5      $��1* �6   6*   �� 5      $��50 �6   6*   .+�5   
   � -   5         �Name$ Navbar��5      $��0��6P    
 Navbar#��[ 6]   .+�5      �� -   5         ��Name$ Navbar_Panel��5   2   	 �� Orientation$	 
Horizontal=�6   .+�5      �� -   5        
 ��Name$
 Minimize��5      $A��;/AutoSystem(CourseWork);component/View/Images/MinWindow.png��6I     Minimize_Button#��[ 6�   6�   F� 5      -   5         F�Name$
 Exit��5        Exit_Button#��[ 6@   ����� �� ���A`��"�q@ ��� �� ��� �� �� �, ��W |f1A`��"�q@� �� ��� \�# ��� |f1 �,� �, |f1� �� ��� �� \�#� ` |f1�hfffffh@ �,� �� ��� � ��� �� `W ��hfffffh@� �� ��	6i  5      5      � 5   
   -   5        $ Profile��5      $��1��6    .+�5      �� $	 
Horizontal=�6   .+�5      A� -   5         A�Name$ Profile_Image��5        Profile_Img#���  61   �� 5      -   5         ��Name$ Profile_Name��5        Profile_Text#��[ 6H   ��62   �� *Name+6|   �� 5       -   5        $ Profile_Role��5       #��[ 6H   $��	100 0 0 0q�6z   ��62   �� *Role+6�   �� 5!      -	   5         ��Name$ AddPanel��5!      $��Редактор��6+     Test_Button#��[ 6V   �� 5"      -
   5        $ 
AdminPanel��5"      $(��"Администрирование��6-     Admin_Button#��[ 6b   5#      5$      � 5&   
   -   5        $ Courses��5&      $��2��6    .+�5'      �� .��5(      �� -   5         ��Name$ 
My_Courses��5(      ��6.   �� *	Courses+ �� SelectedIndex 6N   �� *Index+��5)      �� 5*      .R�5+      �   MyCourse_Style#��[ 6#    5,   "   �� 5-   &   66   �� 5.   &   66   �� 5/   &   66   .+�51   "   �� $ Course_Name��6�   $��0��6B    	 Course_Text#��[	 6O   ��6,   �� *Name+6�   �� 52   "   $ Course_Type��6�   $��1��6H   #��[	 6U   ��6,   �� *
AuthorName+6�   �� 53   "   $ Course_Percent��6�   $��2��6H   #��[	 6U   ��6,   �� *
CourseType+6�   54      55      57      58      59      � 5;   
   -   5        $ Footer��5;      $��3��6   .+�5<      �� $	 
Horizontal=�6   .+�5=      �� -   5        $ 
Add_Course��5=      $��Добавить курс��6-    
 
Add_Course#��[
 6^   6�   �� 5>      -   5        $ Choose_Course��5>      $��Выбрать курс��60     Choose_Course#��[ 6l   ��6G   �� *SetCourseCommand+6�   �� 5?      -   5        $ Delete_Course��5?      $��Удалить курс��60     Delete_Course#��[ 6o   ��6G   �� *DeleteCourseCommand+6�   5@      5A      5B      5C      