   M S B A M L   `   `   `  ����G  CGroupProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GroupProject.ViewGroupProject.View  5   	       GroupProject.View.Login   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:GroupProject.View     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$   .��5	      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Student Management System��6   $��45(�64   $��Heavy"�6B   $��2��6U   $��Center=�6i   $��Center=�6�   �� 5   
   
���   �$��10��6!   $��Bottom=�6-   $��2��6H   �� 5   
   $��/Images/image1.jpeg��6   $��1��6-   $��
10,1,10,17q�6:   �� 5   
   $��Bottom=�6   $��2��6+   $I��CFor Teacher Login, Use User name - 'Teacher' and Password - '1234' ��68   �� 5   
   $��Bottom=�6   $��2��6+   $
��0,20q�68   $E��?For Admin Login, Use User name - 'admin' and Password - '1234' ��6F   � 5   
   $��1��6   $��1��6    5      �� 5      $��50 �6    �� 5      $��* �6    �� 5      $��* �6    �� 5       $��* �6    �� 5!      $��* �6    �� 5"      $��* �6     5%      �� 5&      $��4* �6#   �� 5'      $
��3.5* �6#   .+�5*      �� $��0��6   $��10q�6"   $��4��6.   $��2��6?   
���   �$��1q�6g   �� 5,      $��System Login-��6   $��Bottom=�6,   $��10,0,0,0q�6G   $��30(�6Y   $��DemiBold"�6g   �� 5.      $��Username��6   $��1��6(   $��Center=�65   $
��50,0q�6P   $��20(�6^   �� 5/      $��Password��6   $��2��6(   $��Center=�65   $
��50,0q�6P   $��20(�6^   �� 51      -   5        $��text_username��51      $��1��6+   $��1��6;   $��
0,15,20,10q�6H   $��Center=�6\   $��30��6w   G� 52      -   5        $��text_password��52      $��1��6/   $��2��6?   $��
0,15,20,10q�6L   $��Center=�6`   $��30��6{   �� 53      -   5        $��Admin Login��53   5   $��4��6K   $��2��6X   $��10,15,10,10q�6l   �� 54      -   5        $��Teacher Login��54   :   $��5��6R   $��2��6_   $��10,15,10,10q�6s   55      57      58      