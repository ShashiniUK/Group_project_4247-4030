   M S B A M L   `   `   `  ����G  CGroupProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GroupProject.ViewGroupProject.View  5   	   ?$clr-namespace:GroupProject.ViewModelGroupProject.ViewModel  5   	   &     GroupProject.View.StudentDetails   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:GroupProject.View     5   	   7loacl1$clr-namespace:GroupProject.ViewModel     5   	     � Title$  StudentDetails��5	   	   $	��450��6    $	��800��6-    � DataContext 5
      -  'GroupProject.ViewModel.StudentDetailsVM  5   
   .��5      � .+�5   
   �� $	��433��6   
�������$��Center=�69    �� Orientation$ Vertical=�6T   .+�5      �� $��	 40 0 0 0q�6   $
��Left=�6-   $	��600��6H   
������ $ 
Horizontal=�6n   .+�5      �� $��	FirstName��6   
����  �   ListView#��[  6@   �� 5      $��LastName��6   
����  �#��[  6@   �� 5      $��email��6   
����  �#��[  6<   �� 5      $	��Gpa��6   
����  �#��[  6:   5      �� 5      -   5         ��Name$ Listview��5      $��0 20 0 0q�6*   
������ $	��280��6U   ��6b   �� *Users+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedUser+$ PropertyChanged=���5      �� 5      .R�5      �� 
������ 
���   �$��1q�6N    �� Padding$	 0.1q�5   !    �� CornerRadius$ 5��6/   $	��600��6@   $��35��6L   ._�5      �� $	��600��6)   
������ $ 
Horizontal=�6O   .+�5!   "   �� $��30��6(   $��30��63   $��1q�6?   ��6J   �� *Image+�� 5"   "   #��[  6l   ��6,   �� *	FirstName+$ PropertyChanged=�6l   �� 5#   "   #��[  6k   ��6,   �� *
LastName+$ PropertyChanged=�6k   �� 5$   "   #��[  6h   ��6,   �� *Email+$ PropertyChanged=�6h   �� 5%   "   #��[  6f   ��6,   �� *GPA+$ PropertyChanged=�6f   5'      5*      5+      5.      �� 5/      $
��Back��6   $��51��6D   $	��564��6P   ��6$   �� *BackCommand+6P   50      53      54      