   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HCI.Pages	HCI.Pages  5      clr-namespace:HCIHCI  5          HCI.Pages.DoctorForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:HCI.Pages     5      nclr-namespace:HCI     5        N� Title$  
DoctorForm��5
      .��5      � -   5        
�������.+�5   
   � 5      � 5   
   $��5, 110, 0, 0q�6   .+�59      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridXAML��59      $��Center=�6K   $	��Top=�6h   $	��378��6�   $	��214��6�   $��	0,145,0,0q�6�   ��6.   �� *Data+ � 	Resources 5;      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5<      "  6   .�5=      ��  � ��
 ���@�67   �� 5>       � ��$ SemiBold"�67   �� 5?       � ��$ 0, 0 , 1 ,2q�6<   �� 5@       � ��
 �   �68   5B      5C         Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *Id+6L     5G      $ Form Id��6)   $ 50 6U   	 6:   �� *FormId+6U     5H      $ Grade��6)   $	 100 6R   	 68   �� *Grade+6R     5I      $ 
Patient Id��6)   $	 100 6[   	 6=   �� *	PatientId+6[     5J      $ 	Doctor Id��6)   $	 100 6Y   	 6<   �� *
DoctorId+6Y   5M      � 5O      $��26,491,-10,13q�6   .+�5P      �� .+�5Q         HCI.NavButton  
   Text$

 Home��6"      ImageSource$ /Images/home.png��6.      NavUri$ /Pages/Landing.xaml?�6M    J� RenderTransformOrigin$ 0.849,0.702&�6j   $��86��6�   5R      �� 5S      .+�5T        $
 Notifications��6"   $ /Images/bell.png��67   $ /Pages/Landing.xaml?�6V   $ 0.849,0.702&�6s   $��86��6�   5U      �� 5V      .+�5W        $
 
My Profile��6"   $ /Images/user.png��64   $ /Pages/Landing.xaml?�6S   $ 0.849,0.702&�6p   $��86��6�   5X      �� 5Y      .+�5Z        $
 Log out��6"   $ /Images/logout.png��61   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��86��6�   5[      �� 5\      $��38, 22, 5, 6q�6   .+�5]        $
 Log out��6"   $ /Images/square.png��61   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��31��6�   $��31��6�   5^      �� 5_      $��88, 20, 5, 6q�6   .+�5`        $
 Log out��6"   $ /Images/new-moon.png��61   $ /Pages/Landing.xaml?�6T   $ 0.849,0.702&�6q   $��31��6�   $��44��6�   5a      �� 5b      $��88, 20, 5, 6q�6   .+�5c        $
 Log out��6"   $ /Images/arrow-left.png��61   $ /Pages/Landing.xaml?�6V   $ 0.849,0.702&�6s   $��44��6�   $��44��6�   5d      5e      �� 5f      -   5        $��Doctors��5f      $
��Left=�6&   $��	89,47,0,0q�6m   $	��Top=�6�   $	��234��6�   ��5g      �� 5h      .R�5i      �� ��6$   �� *
Username+5j      5l      �� 5m      $��Doctors��6   $
��Left=�6&   $
��Bold"�6A   $��
188,18,0,0q�6S   $	��Top=�6g   5n      5o      5p      