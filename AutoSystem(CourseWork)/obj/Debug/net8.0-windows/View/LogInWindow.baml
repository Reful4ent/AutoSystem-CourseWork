   M S B A M L   `   `   `  ����Q  MAutoSystem(CourseWork), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AutoSystem_CourseWork_.ViewAutoSystem_CourseWork_.View  5   	   -    'AutoSystem_CourseWork_.View.LogInWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AutoSystem_CourseWork_.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LogInWindow��5	   	   $	��355��6   $	��400��6*    � 
ResizeMode$ NoResize=�66    � WindowStyle$
 None=�6L    � 	Resources 5
       �� Source�� 5   
   $H B/AutoSystem(CourseWork);component/View/ViewStyles/LogInStyles.xaml?�6   %    6k   .��5      �    Background_Window#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $	��180 �6   6+   �� 5      $��50 �6   6*   �� 5      $��25 �6   6*   .+�5   
   � -   5         �Name$ Navbar��5      $��0��6P    
 Navbar#��[ 6]   .+�5      �� -   5         ��Name$ Navbar_Panel��5   2   	 �� Orientation$	 
Horizontal=�6   .+�5      �� -   5        
 ��Name$
 Minimize��5      $A��;/AutoSystem(CourseWork);component/View/Images/MinWindow.png��6I     Minimize_Button#��[ 6�   6�   F� 5      -   5         F�Name$
 Exit��5        Exit_Button#��[ 6@   ����� �� ���A`��"�q@ ��� �� ��� �� �� �, ��W |f1A`��"�q@� �� ��� \�# ��� |f1 �,� �, |f1� �� ��� �� \�#� ` |f1�hfffffh@ �,� �� ��� � ��� �� `W ��hfffffh@� �� ��	6i  5      5      � 5   
   -   5        $ Title_Of_App��5      $��1��6%   .+�5      �� $	 
Horizontal=�6   .+�5      �� -   5        $

 Logo��5      $<��6/AutoSystem(CourseWork);component/View/Images/logo.png��6&     Logo#��[ 6f   6�   �� 5       -   5         ��Name$ 
Title_Text��5         
Title_Text#��[ 60   NSTU Training6o   5!      5"      � 5$   
   -   5        $
 Form��5$      $��2��6    � ColumnDefinitions 5%      �� 5&      $	��340 �6#   61   �� 5'      $��60 �6#   60    5)      �� 5*      $��40 �6    6.   �� 5+      $��50 �6    6.   �� 5,      $��40 �6    6.   �� 5-      $��50 �6    6.   .+�50      �� -	   5        $ Form_Text_Log��50      $��0��6/   $��2��6<     	Form_Text#��[ 6P   Логин:6{   �� 51      -
   5         ��Name$ Form_Input_Login��51      $��1��60   $��2��6=     Form_Input_Login#��[ 6h    �� 	MaxLength$ 40��6�   ��6Q   �� *Login+6�   �� 52      -   5        $ Form_Text_Pass��52      $��2��60   $��2��6=   #��[ 6Q   Пароль:6}   G� 53      -   5         G�Name$ Form_Input_Password_PB��53      $��3��6:   $��0��6G     Form_Input_Password_PB#��[ 6�    G� 	MaxLength$ 20��6�   �� 54      -   5        $ Form_Input_Password_TB��54      $��3��66   $��0��6C   $y�Hidden=�6S    	 Form_Input_Password_TB#��[	 6�   $ 20��6�   ��6g   �� *
Password+6�   �� 55      $��3��6   $��1��6&   .+�56      F� -   5        $ Watch_Password��56       
 Watch_Password#��[
 6/   ������2� ���8�������> z D� z ������#@ z ��	 ���`U  ��T���Q����Mbx?@T���Q��j�t�D@@`U ������	 p����  ~VD� ~V��MbX9K@ ~V"��~j�O@p��2�����H��8b�H���-��2� ���D� Zb�Hڤ Zb2nб+2n H��2n0ޤHڤ 6nD� 6n��+ 6nZd;��C@0ޤZd;��C@ H��Zd;��C@б+�+ ZbD� Zb	6�   57      58      � 5:   
   -   5        $ Form_Submit��5:      $��3��6$   .+�5;      �� -   5         ��Name$ LogIn_Button��5;      $��
Войти��6+     LogIn_Button#��[ 6;   ��6m   �� *StartLogInCommand+6�   5<      � 5>   
   -   5        $ Registration_Submit��5>      $��4��6,   .+�5?      �� -   5        $ Registration_Text��5?        Regestration_Text#��[ 63   �� 5@      -   5          Hyperlink_Text#��[ 5@      $#��/View/RegistrationWindow.xaml?�6Q   .�6�   ><Нет аккаунта? Зарегистрируйтесь!6�   5A      5B      5C      5D      