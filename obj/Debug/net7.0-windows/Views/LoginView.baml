   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PasswordManager.ViewsPasswordManager.Views  5   	   G(clr-namespace:PasswordManager.ViewModelsPasswordManager.ViewModels  5      O,clr-namespace:PasswordManager.CustomControlsPasswordManager.CustomControls  5   	   %    PasswordManager.Views.LoginView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PasswordManager.Views     5   	   >	viewModel(clr-namespace:PasswordManager.ViewModels     5      GcustomControls,clr-namespace:PasswordManager.CustomControls     5   	     � Title$  	LoginView��5
   	   $	��550��6   $	��800��6(    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      /   )PasswordManager.ViewModels.LoginViewModel  5   
    � 	Resources 5         BooleanToVisibility��%   &	        �� 5      6!   5      y�5      �� 5       �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6!   	 �� 	Converter#	 [  6/   .��5      �� 
 �� CornerRadius$
 12��6   ��5   
   �� 5        �� ImageSource$c ]C:\Users\Allen\Desktop\CS WORK\projects\PasswordManager\PasswordManager\Images\back-image.png��6    j� Stretch$
 None=�5!      ._�5$   
   �� $
 10��6   $��2q�5%       J� Opacity$	 0.8Q�5&      ��5(      �� 5)       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5*      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5+      $ #DA34AE��6#   $
 0.75Q�63   � 5,      $ #8A16C1��6#   $ 1Q�63   5-      ��50      �� 51      $	 0,1&�6&   $	 1,0&�67   .��52      � $ #060531��6#   $ 0Q�63   � 53      $ #1B1448��6#   $ 1Q�63   54      ._�57      �  � RowDefinitions 58      �� 59      $��30 �6$   �� 5:      .+�5=      � $��0��6    � ColumnDefinitions 5?      �� 5@      �� 5A      $��25 �6+   �� 5B      $��25 �6+   �� 5C      $��5 �6+   .+�5F      �� $��LOG IN��6    
�������$��10(�5H       $��
Montserrat)�5I       $��0��5J       $��Center=�5K       $��10,0,0,0q�5L       �� 5N      -   5         ��Name$ btnMinimize��5N      $��0q�5O      $��-��5P      
�������$��16(�5R      $��
Montserrat)�5S       � Cursor$
 Hand��5T      $��1��5U      ��5W      �� 5X       �� 
TargetType" ��6$   .�5Y   "   ��  �� Property � �� �� Value �#28AEED6?    �� Triggers 5Z   "   P� 5[   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5\   *   ��  � �� �#278BEF6G   5]   '   5_      ��5b      �� 5c       �� 
TargetType" ��6.   .R�5d   "   �� $��18��6)   $��18��64   $
 9��5e   )   #��z��5f   )   ._�5g   &   �� $��Center=�67   $��Center=�5h   7   5i   #   5j      5m      �� 5o      -   5        $ btnClose��5o      $��0q�5p      $��X��5q      
�������$��12(�5s      $��
Montserrat)�5t      $
 Hand��5u      $��2��5v      ��5x      �� 5y      " ��6$   .�5z   "   ��  � �� �#DA34AE6?    5{   "   P� 5|   &    �@J�IsMouseOver$
 True��6E   . �5}   *   ��  � �� �#C62DAE6G   5~   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��18��6)   $��18��64   $
 9��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      �� 5�      $	��220��6   $��1��5�       �� Orientation$ Vertical=�5�      $��0,35,0,0q�5�      .+�5�      �� $��/Images/logo.png��6   $	��100��5�      $	��100��6(   �� 5�      $��Password Manager��6    
�������$��21(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $L��FSecure, fast and reliable                                by Allen Saju��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       �� 5�      $��Username��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      -   5         ��Name$ txtUser��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
�������  �� 
CaretBrush
  �����
�������$��0,0,0,2q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�      ��5�   	   �� *
Username+! �� UpdateSourceTrigger$! PropertyChanged=�.��5�   1   5�      �� 5�      $��Password��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,15,0,0q�5�       8   2PasswordManager.CustomControls.BindablePasswordBox  5�      $��28��5�   9   $��0,5,0,0q�5�   9   "   Password" 5�   9   �� *
Password+$ TwoWay=�$! PropertyChanged=�5�      �� 5�      ���#D7596D$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,10,0,0q�5�       $
��Wrap=�5�       ��5�       �� *ErrorMessage+5�       �� 5�      -   5        $ btnLogin��5�      $��0q�5�      $��LOG IN��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,50,0,0q�5�      ��5�      �� *LoginCommand+��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#462AD86?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#28AEED6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $
 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,15,0,0q�5�   !   .+�5�      �� $��Forgot Password?��6$   
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       �� 5     $��Reset��6$   
�������$��12(�5      $��Medium"�5      $��
Montserrat)�5      $
 Hand��5      $��8,0,0,0q�5      5	     5     5     5     5     5     