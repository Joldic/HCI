   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI.Pages.DialogHCI.Pages.Dialog  5      clr-namespace:HCIHCI  64   !    HCI.Pages.Dialog.UpdateRoom   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:HCI.Pages.Dialog     5      nclr-namespace:HCI     64   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
UpdateRoom��5
      .��5      � -   5        
�������.+�5   
   �� -   5        $��room_name_tb��5      $��Center=�6&   $��	0,119,0,0q�6C    �� TextWrapping$
 Wrap=�6V   $	��Top=�6�   $	��234��6�   ��6j   ��  �� Path$ roomName�6�   �� 5   
   $��Update Room��6   $
��Bold"�6&   $��20(�68   $��Center=�6F   $��0,48,0,0q�6c   $	��Top=�6u   � 5   
   $��26,603,-24,-114q�6   .+�5      �� .+�5         HCI.NavButton     Text$
 Home��6      ImageSource$ /Images/home.png��6*      NavUri$ /Pages/Landing.xaml?�6I    J� RenderTransformOrigin$ 0.849,0.702&�6f   $��86��6�   5      �� 5      .+�5        $ Notifications��6   $ /Images/bell.png��63   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��86��6�   5      �� 5      .+�5        $ 
My Profile��6   $ /Images/user.png��60   $ /Pages/Landing.xaml?�6O   $ 0.849,0.702&�6l   $��86��6�   5      �� 5      .+�5        $ Log out��6   $ /Images/logout.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��86��6�   5      �� 5      $��38, 22, 5, 6q�6   .+�5        $ Log out��6   $ /Images/square.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��31��6�   $��31��6�   5       �� 5!      $��88, 20, 5, 6q�6   .+�5"        $ Log out��6   $ /Images/new-moon.png��6-   $ /Pages/Landing.xaml?�6P   $ 0.849,0.702&�6m   $��31��6�   $��44��6�   5#      �� 5$      $��88, 20, 5, 6q�6   .+�5%        $ Log out��6   $ /Images/arrow-left.png��6-   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��44��6�   $��44��6�   5&      5'      �� 5(   
   -   5        $��RoomEnum��5(      $��Center=�6E   $��	0,194,0,0q�6b   $	��Top=�6u   $	��234��6�   ��6#   �� *	RoomTypes+6�   �� 5)   
   -   5        $��square_footage_tb��5)      $��Center=�6+   $��	0,275,0,0q�6H   $
 Wrap=�6[   $	��Top=�6�   $	��234��6�   ��6o   �� $ squareFootage�6�   �� 5*   
   -   5        $��Update��5*      $
��Left=�6"   $��240,343,0,0q�6=   $	��Top=�6R   6j   �� 5+   
   $
��Name��6   $
��Left=�6   $��Medium"�6:   $��
26,119,0,0q�6N   $	��Top=�6b   �� 5,   
   $
��Type��6   $
��Left=�6   $��Medium"�6:   $��
26,194,0,0q�6N   $	��Top=�6b   �� 5-   
   $��Surface��6   $
��Left=�6"   $��Medium"�6=   $��
26,271,0,0q�6Q   $	��Top=�6e   5.      5/      