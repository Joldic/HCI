   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HCI.Pages	HCI.Pages  5      clr-namespace:HCIHCI  5          HCI.Pages.Form   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:HCI.Pages     5      nclr-namespace:HCI     5        N� Title$
  Form��5
      .��5      � -   5        
�������.+�5   
   � 5      � 5   
   $��5, 110, 0, 0q�6   .+�59      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridXAML��59      $��Center=�6K   $	��Top=�6h   $	��340��6�   $	��214��6�   $��	0,145,0,0q�6�   ��6.   �� *Data+ � 	Resources 5;      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5<      "  6   .�5=      ��  � ��
 ���@�67   �� 5>       � ��$ SemiBold"�67   �� 5?       � ��$ 0, 0 , 1 ,2q�6<   �� 5@       � ��
 �   �68   5B      5C         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *Id+6L     5G      $ Form Id��6)   $ 70 6U   	 6:   �� *FormId+6U     5H      $ Grade��6)   $	 102 6R   	 68   �� *Grade+6R     5I      $ 
Patient Id��6)   $	 100 6[   	 6=   �� *	PatientId+6[   5L      � 5N      $��26,491,-10,13q�6   .+�5O      �� .+�5P         HCI.NavButton  
   Text$

 Home��6"      ImageSource$ /Images/home.png��6.      NavUri$ /Pages/Landing.xaml?�6M    J� RenderTransformOrigin$ 0.849,0.702&�6j   $��86��6�   5Q      �� 5R      .+�5S        $
 Notifications��6"   $ /Images/bell.png��67   $ /Pages/Landing.xaml?�6V   $ 0.849,0.702&�6s   $��86��6�   5T      �� 5U      .+�5V        $
 
My Profile��6"   $ /Images/user.png��64   $ /Pages/Landing.xaml?�6S   $ 0.849,0.702&�6p   $��86��6�   5W      �� 5X      .+�5Y        $
 Log out��6"   $ /Images/logout.png��61   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��86��6�   5Z      �� 5[      $��38, 22, 5, 6q�6   .+�5\        $
 Log out��6"   $ /Images/square.png��61   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��31��6�   $��31��6�   5]      �� 5^      $��88, 20, 5, 6q�6   .+�5_        $
 Log out��6"   $ /Images/new-moon.png��61   $ /Pages/Landing.xaml?�6T   $ 0.849,0.702&�6q   $��31��6�   $��44��6�   5`      �� 5a      $��88, 20, 5, 6q�6   .+�5b        $
 Log out��6"   $ /Images/arrow-left.png��61   $ /Pages/Landing.xaml?�6V   $ 0.849,0.702&�6s   $��44��6�   $��44��6�   5c      5d      �� 5e      $��Forms About Hospital��6   $��Center=�63   $
��Bold"�6P   $��16(�6b   $��0,48,0,0q�6p   $	��Top=�6�   5f      5g      5h      