   M S B A M L   `   `   `  ����  lab4    lab4.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Research Manager��5   	   $	��450��6"   $	��800��6/   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� $��Research List��6   $��18(�6)   $
��Bold"�67   �� 5   
   -   5         ��Name$ ResearchListBox��5      $��1��6N    �� DisplayMemberPath$ ToShortString��6[   ��6+   �� *
researches+6[   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�5      �� -   5         ��Name$ 	AddButton��5      $	��Add��6(   $��80��66   $��5q�6A   6L   �� 5      -   5        $ 
EditButton��5      $
��Edit��6)   $��80��68   $��5q�6C   6N   �� 5      -   5        $ DeleteButton��5      $��Delete��6+   $��80��6<   $��5q�6G   6R   �� 5      -   5        $ 
SaveButton��5      $
��Save��6)   $��80��68   $��5q�6C   6N   �� 5      -   5        $ 
LoadButton��5      $
��Load��6)   $��80��68   $��5q�6C   6N   5      5      5      