   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HCI.Pages	HCI.Pages  5      clr-namespace:HCIHCI  5          HCI.Pages.Merge   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:HCI.Pages     5      nclr-namespace:HCI     5        N� Title$  Merge��5
      .��5      � -   5        
�������.+�5   
   �� -   5        $��Rooms_1��5      $
��Left=�6"   $��
101,56,0,0q�6=   $	��Top=�6Q   $	��224��6i   ��5      �� 5      .R�5      �� ��6    �� *Name+5      5      � 5   
   $��26,603,-24,-114q�6   .+�5      �� .+�5         HCI.NavButton     Text$
 Home��6      ImageSource$ /Images/home.png��6*      NavUri$ /Pages/Landing.xaml?�6I    J� RenderTransformOrigin$ 0.849,0.702&�6f   $��86��6�   5      �� 5      .+�5        $ Notifications��6   $ /Images/bell.png��63   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��86��6�   5      �� 5      .+�5        $ 
My Profile��6   $ /Images/user.png��60   $ /Pages/Landing.xaml?�6O   $ 0.849,0.702&�6l   $��86��6�   5       �� 5!      .+�5"        $ Log out��6   $ /Images/logout.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��86��6�   5#      �� 5$      $��38, 22, 5, 6q�6   .+�5%        $ Log out��6   $ /Images/square.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��31��6�   $��31��6�   5&      �� 5'      $��88, 20, 5, 6q�6   .+�5(        $ Log out��6   $ /Images/new-moon.png��6-   $ /Pages/Landing.xaml?�6P   $ 0.849,0.702&�6m   $��31��6�   $��44��6�   5)      �� 5*      $��88, 20, 5, 6q�6   .+�5+        $ Log out��6   $ /Images/arrow-left.png��6-   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��44��6�   $��44��6�   5,      5-      �� 5/   
   $��Merge��6   $
��Left=�6    $
��bold"�6;   $��24(�6M   $��	172,0,0,0q�6[   $	��Top=�6n   �� 50   
   $
��Room��6   $
��Left=�6   $
��bold"�6:   $��	40,52,0,0q�6L   $	��Top=�6_   �� 51   
   $
��Room��6   $
��Left=�6   $
��bold"�6:   $��
40,109,0,0q�6L   $	��Top=�6`   �� 52   
   -   5         ��Name$ Rooms_2��52      $
��Left=�6$   $��101,109,0,0q�6?   $	��Top=�6T   $	��224��6l   ��53      �� 54      .R�55      �� ��6    �� *Name+56      58      �� 59   
   -   5        $��	Room_name��59      $
��Left=�6#   $��101,163,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��224��6�   �� 5:   
   $
��Name��6   $
��Left=�6   $
��bold"�6:   $��
40,159,0,0q�6L   $	��Top=�6`   �� 5;   
   -   5        $��Client��5;      $
��Left=�6!   $��101,214,0,0q�6<   $	��Top=�6Q   $	��224��6i   ��6u   �� *	RoomTypes+�� 5<   
   $
��Type��6   $
��Left=�6   $
��bold"�6:   $��
40,214,0,0q�6L   $	��Top=�6`   (  "System.Windows.Controls.DatePicker  5=   
   -   5          Name$	 DP1��5=      $
��Left=�6Q   $��101,265,0,0q�6l   $	��Top=�6�   $	��224��6�   �� 5>   
   $��Start��6   $
��Left=�6    $
��bold"�6;   $��
40,261,0,0q�6M   $	��Top=�6a   �� 5?   
   -   5        $ cboTP��5?   g   $
��Left=�6   $��101,317,0,0q�6.   $	��Top=�6C   $	��224��6[   .@�5@      �� $��08:00��6   �� 5A      $��08:30��6   �� 5B      $��09:00��6   �� 5C      $��09:30��6   �� 5D      $��10:00��6   �� 5E      $��10:30��6   �� 5F      $��11:00��6   �� 5G      $��11:30��6   5H      �� 5I   
   $
��Time��6   $
��Left=�6   $
��bold"�6:   $��
40,313,0,0q�6L   $	��Top=�6`     5J   
   -   5        $ DP1_Copy��5J      $
��Left=�6[   $��101,375,0,0q�6v   $	��Top=�6�   $	��224��6�   �� 5K   
   $	��End��6   $
��Left=�6   $
��bold"�69   $��
40,371,0,0q�6K   $	��Top=�6_   $ 0.617,-1.814&�6w   �� 5L   
   -	   5        $ cboTP1��5L   g   $
��Left=�6   $��101,432,0,0q�6.   $	��Top=�6C   $	��224��6[   .@�5M      �� $��08:00��6   �� 5N      $��08:30��6   �� 5O      $��09:00��6   �� 5P      $��09:30��6   �� 5Q      $��10:00��6   �� 5R      $��10:30��6   �� 5S      $��11:00��6   �� 5T      $��11:30��6   5U      �� 5V   
   $
��Time��6   $
��Left=�6   $
��bold"�6:   $��
39,428,0,0q�6L   $	��Top=�6`   �� 5W   
   -
   5        $��Merge��5W      $
��Left=�6!   $��169,494,0,0q�6<   $	��Top=�6Q   $��84��6i   6t   5X      5Y      