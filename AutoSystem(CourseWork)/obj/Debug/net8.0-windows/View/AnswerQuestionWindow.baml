   M S B A M L   `   `   `  ����Q  MAutoSystem(CourseWork), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AutoSystem_CourseWork_.ViewAutoSystem_CourseWork_.View  5   	   6    0AutoSystem_CourseWork_.View.AnswerQuestionWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AutoSystem_CourseWork_.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AnswerQuestionWindow��5	   	   $	��450��6&   $	��700��63    � 
ResizeMode$ NoResize=�6?    � WindowStyle$
 None=�6U    � 	Resources 5
       �� Source�� 5   
   $W Q/AutoSystem(CourseWork);component/View/ViewStyles/AnswerQuestionWindowStyles.xaml?�6   %    6z   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   � -   5         �Name$ Navbar��5      $��0��6Q    
  Navbar#��[  6^   .+�5      �� -   5         ��Name$ Navbar_Border��5        Navbar_Border#��[ 6,   ._�5      �� -   5        	 ��Name$	 Navbar_Panel��5   6   
 �� Orientation$
 
Horizontal=�6   .+�5      �� -   5         ��Name$ Minimize��5      $A��;/AutoSystem(CourseWork);component/View/Images/MinWindow.png��6M     Minimize_Button#��[ 6�   6�   F� 5      -   5         F�Name$
 Exit��5        Exit_Button#��[ 6D   ����� �� ���A`��"�q@ ��� �� ��� �� �� �, ��W |f1A`��"�q@� �� ��� \�# ��� |f1 �,� �, |f1� �� ��� �� \�#� ` |f1�hfffffh@ �,� �� ��� � ��� �� `W ��hfffffh@� �� ��	6m  5      5      5      � 5   
   -   5        $ Text_Of_Window��5      $��1��6'    � ColumnDefinitions 5      �� 5      6%   �� 5       6%   �� 5!      6%   �� 5"      6%   .+�5$      � $��0��6   .+�5%      �� $��Вопрос��6     
Title_Text#��[ 6*   6]   5&      � 5'      $��1��6   .+�5(      �� #��[ 6<   
���   ���6   �� *QuestionNumber+6�   5)      � 5*      $��2��6   .+�5+      �� $
��из��6   #��[ 6&   6X   5,      � 5-      $��3��6   .+�5.      �� #��[ 6;   
���   ���6   �� *QuestionCount+6�   5/      50      � 51   
   $��2��6   .+�52      ��   Question_Text#��[ 66   $
��Wrap=�6i   ��6   �� *QuestionText+6   53      � 55   
   $��3��6   .+�56      ��   Answer_Style#��[ 62   ��6   �� *
AnswerText+6f   57      � 58   
   -   5        $ Answer_Question_Button��58      $��4��6/   .+�59      �� $��Ответил��6     Button_style#��[ 6I   ��6'   �� *AnswerCommand+6}   5:      5;      5<      