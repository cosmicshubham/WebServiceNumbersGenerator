   M S B A M L   `   `   `  ����H  DNumGen Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NumGen_ClientNumGen_Client  5   	       NumGen_Client.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:NumGen_Client     5   	     � Title$  Number Generator��5   	   $��360.244��6"   $��421.707��63    � 
ResizeMode$ NoResize=�6C   .��5	      � .+�5
   
   �� -   5         ��Name$ lbURL��5
      $��URL: ��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   �� 5   
   -   5         ��Name$ tbURL��5      $
��Left=�6!   $��23��6<   $��	64,10,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��329��6�   $��http://shubham.somee.com��6�   �� 5   
   -   5        $ label��5      $��Type: ��6   $
��Left=�60   $��	10,41,0,0q�6K   $	��Top=�6^   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��	64,44,0,0q�6@   $	��Top=�6S   $	��329��6k    �� SelectedIndex$ 0��6w   .@�5      �� $��Prime Numbers��6   �� 5      $��Composite Numbers��6   �� 5      $��Perfect Squares��6   �� 5      $��Fibonacci Numbers��6   �� 5      $��Power of 2's��6   �� 5      $��Even Numbers��6   �� 5      $��Odd Numbers��6   �� 5      $��Palindromic Numbers��6   5      �� 5   
   -   5        $ label1��5      $��Start: ��6    $
��Left=�62   $��	10,76,0,0q�6M   $	��Top=�6`   �� 5   
   -   5        $ tbStart��5      $
��Left=�6#   $��23��6>   $��	64,76,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��193��6�   �� 5   
   -   5        $ lbEnd��5      $��End: ��6   $
��Left=�6/   $��
10,104,0,0q�6J   $	��Top=�6^   �� 5   
   -   5        $ tbEnd��5      $
��Left=�6!   $��23��6<   $��
64,104,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��193��6�   �� 5   
   -	   5         ��Name$ btnGenerate��5      $��GENERATE��6&   $
��Left=�69   $��
262,76,0,0q�6T   $	��Top=�6h   $	��131��6�   $��51��6�   6�   �� 5   
   -
   5        $ tbResult��5      $
��Left=�6$   $	��164��6?   $��
10,147,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��383��6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   	 �� 
IsReadOnly	 . $��5q�6�   5       5!      