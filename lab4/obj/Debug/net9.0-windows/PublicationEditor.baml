   M S B A M L   `   `   `  ����  lab4    lab4.PublicationEditor   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Edit Publication��5   	   $	��300��6"   $	��350��6/   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Student Information��6   $
��Bold"�6/   $��0��6A   $��0,0,0,5q�6N   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $	��0,2q�6;   .+�5      �� $��First Name:��6   $��90��6+   $��Center=�66   �� 5      -   5         ��Name$ FirstNameBox��5      $	��180��6,   5      �� 5   
   $ 
Horizontal=�6   $��2��6.   $	��0,2q�6;   .+�5      �� $��
Last Name:��6   $��90��6*   $��Center=�65   �� 5      -   5        $ LastNameBox��5      $	��180��6+   5      �� 5   
   $ 
Horizontal=�6   $��3��6.   $	��0,2q�6;   .+�5      �� $��Enrollment Year:��6   $��90��60   $��Center=�6;   �� 5      -   5        $ EnrollmentYearBox��5      $	��180��61   5      �� 5    
   $ 
Horizontal=�6   $��4��6.   $	��0,8q�6;   .+�5!      �� $��Achievement:��6   $��90��6,   $��Center=�67   �� 5"      -   5         ��Name$ AchievementBox��5"      $	��180��6/   5#      �� 5%   
   $��5��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5&      �� -   5        $��OK��5&      $��80��6"   $��5q�6-    �� 	IsDefault$
 True��68   6I   �� 5'      $��Cancel��6   $��80��6&   $��5q�61    �� IsCancel$
 True��6<   5(      5)      5*      