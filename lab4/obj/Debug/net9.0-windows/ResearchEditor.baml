   M S B A M L   `   `   `  ����  lab4    lab4.ResearchEditor   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Edit Research��5   	   $	��400��6   $	��600��6,   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   $��0,0,0,10q�69   .+�5      �� $��Client Information��6   $
��Bold"�62   �� 5      $��Organization Name��6   �� 5      -   5         ��Name$ OrganizationNameBox��5      $	��0,5q�63   ��6@   �� *Client.OrganizationName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Research Topic��6   �� 5      -   5        $ ResearchTopicBox��5      $	��0,5q�60   ��6=   �� *Client.ResearchTopic+$ TwoWay=�$ PropertyChanged=��� 5      $��Contract Value��6   �� 5      -   5        $ ContractValueBox��5      $	��0,5q�60   ��6=   �� *Client.ContractValue+$ TwoWay=�$ PropertyChanged=�5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��0,0,0,10q�6;   .+�5      �� $��Contract Date:��6   $��Center=�6.   $��0,0,10,0q�6I   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ ContractDatePicker��5      $	��200��6�      SelectedDate 65   �� *ContractDate+$ TwoWay=�$ PropertyChanged=�6�   5      �� 5"   
   $��Publications��6   $��2��6)   .��5#      �  5$      �� 5%      $��* �6$   �� 5&      $
��Auto �6$   .+�5(      �� -   5         ��Name$ PublicationsListBox��5(      ��67   �� *Publications+�� 5*      $��1��6   $ 
Horizontal=�6*   $��Center=�6C   $	��0,5q�6`   .+�5+      �� -   5        	 ��Name$	 AddPublicationButton��5+      $	��Add��6;   $��80��6I   $��5q�6T   6_   �� 5,      -   5        $	 EditPublicationButton��5,      $
��Edit��6<   $��80��6K   $��5q�6V   6a   �� 5-      -   5        $	 DeletePublicationButton��5-      $��Delete��6>   $��80��6O   $��5q�6Z   6e   5.      5/      50      �� 53   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�54      �� -	   5        $��OK��54      $��80��6"   $��5q�6-   
 �� 	IsDefault$

 True��68   6I   �� 55      $��Cancel��6   $��80��6&   $��5q�61    �� IsCancel$
 True��6<   56      57      58      