   M S B A M L   `   `   `  ����Q  MAutoSystem(CourseWork), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:AutoSystem_CourseWork_.ViewAutoSystem_CourseWork_.View  5   	   <    6AutoSystem_CourseWork_.View.ChangeUserRepositoryWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:AutoSystem_CourseWork_.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$  ChangeUserRepositoryWindow��5	   	   $	��560��6,   $	��400��69    � WindowStyle$
 None=�6E    � 
ResizeMode$ NoResize=�6X    � 	Resources 5
       �� Source�� 5   
   $W Q/AutoSystem(CourseWork);component/View/ViewStyles/ChangeUserRepositoryStyles.xaml?�6   %    6z   .��5      �    Background_Window#��[  6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��70 �6   6*   �� 5      $��30 �6   6*   �� 5      $��1* �6   6*   �� 5      $��50 �6   6*   .+�5   
   � -   5         �Name$ Navbar��5      $��0��6P    
 Navbar#��[ 6]   .+�5      �� -   5         ��Name$ Navbar_Border��5        Navbar_Border#��[ 6,   ._�5      �� -   5        	 ��Name$	 Navbar_Panel��5   6   
 �� Orientation$
 
Horizontal=�6   .+�5      �� -   5         ��Name$ Minimize��5      $A��;/AutoSystem(CourseWork);component/View/Images/MinWindow.png��6M     Minimize_Button#��[ 6�   6�   F� 5      -   5         F�Name$
 Exit��5        Exit_Button#��[ 6D   ����� �� ���A`��"�q@ ��� �� ��� �� �� �, ��W |f1A`��"�q@� �� ��� \�# ��� |f1 �,� �, |f1� �� ��� �� \�#� ` |f1�hfffffh@ �,� �� ��� � ��� �� `W ��hfffffh@� �� ��	6m  5      5      5      � 5   
   -   5        $ Info_About_Roles��5      $��1��6   .+�5      �� ._�5       ��   Info_AU#��[ 6   0 - Ученик�� 5!   !   1 - Учитель�� 5"   "    2 - Администратор5$      5%      5&      � 5'   
   -   5        $ 	Roles_Box��5'      $��2��6   .+�5(      �� -   5         �� 	MaxLength$ 2��5(        Roles_Box_Styles#��[ 6$   ��6Z   �� *	Role_Id+6�   5)      � 5+   
   -	   5        $ 	User_List��5+      $��3��6"   .+�5,      �� .��5-      �� -
   5         ��Name$ List_Of_Users��5-      ��61   �� *
UserList+ �� SelectedIndex 6R   �� *Index+��5.      �� 5/      .R�50      �   User_List_Style#��[ 6#    51   "   �� 52   &   66   �� 53   &   66   �� 54   &   66   �� 55   &   66   .+�57   "   ��  ��Name$ User_Id��6|   $��0��6@     	User_Text#��[ 6M   ��6,   �� *Id+6�   �� 58   "   $ 
User_Login��6   $��1��6C   #��[ 6P   ��6,   �� *Login+6�   �� 59   "   $ 	User_Name��6~   $��2��6B   #��[ 6O   ��6,   �� *Name+6�   �� 5:   "   $ 	User_Role��6�   $��3��6E   #��[ 6R   ��6,   �� *	Role_Id+6�   5;      5<      5>      5?      5@      � 5B   
   -   5        $ Courses_Add��5B      $��4��6$   .+�5C      �� $
 
Horizontal=�6   .+�5D      �� -   5         ��Name$ User_Delete_Button��5D      $��Удалить��65    	 UserDelete_Button#��[	 6G   ��6~   �� *DeleteUserCommand+6�   �� 5E      -   5        $ User_ChangeRole_Button��5E      $��Изменить��69    
 UserChangeRole_Button#��[
 6L   ��6�   �� *ChangeUserRoleCommand+6�   5F      5G      5H      5I      