   M S B A M L   `   `   `  ����Q  MAutoSystem(CourseWork), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AutoSystem_CourseWork_.ViewAutoSystem_CourseWork_.View  5   	   1    +AutoSystem_CourseWork_.View.SolveTestWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AutoSystem_CourseWork_.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ SolveTestWindow��5	   	   $	��500��6!   $
��1000��6.   $	��500��6;   $
��1000��6K    � WindowStyle$
 None=�6[    � 
ResizeMode$ NoResize=�6n    � 	Resources 5
       �� Source�� 5   
   $R L/AutoSystem(CourseWork);component/View/ViewStyles/SolveTestWindowStyles.xaml?�6   %    6u   .��5      �    Background_Window#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   � -   5         �Name$ Navbar��5      $��0��6P    
 Navbar#��[ 6]   .+�5      �� -   5         ��Name$ Navbar_Border��5        Navbar_Border#��[ 6,   ._�5      �� -   5        	 ��Name$	 Navbar_Panel��5   6   
 �� Orientation$
 
Horizontal=�6   .+�5      �� -   5         ��Name$ Minimize��5      $A��;/AutoSystem(CourseWork);component/View/Images/MinWindow.png��6M     Minimize_Button#��[ 6�   6�   F� 5      -   5         F�Name$
 Exit��5        Exit_Button#��[ 6D   ����� �� ���A`��"�q@ ��� �� ��� �� �� �, ��W |f1A`��"�q@� �� ��� \�# ��� |f1 �,� �, |f1� �� ��� �� \�#� ` |f1�hfffffh@ �,� �� ��� � ��� �� `W ��hfffffh@� �� ��	6m  5      5      5      � 5   
   -   5        $ 	Test_Info��5      $��1��6"   .+�5      �� .��5      �� $
��Wrap=�64     Theory_Style#��[ 6H   ��6   �� *Theory+6|   5       5!      � 5"   
   -   5        $ Ascept_Theory��5"      $��2��6&   .+�5#      �� -   5         ��Name$ I_Read_Button��5#      $��Прочитал��6U     Button_style#��[ 6h   ��6,   �� *CheckQuestionCommand+6�   5$      5%      5&      