   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI.Pages.DialogHCI.Pages.Dialog  5      clr-namespace:HCIHCI  5          HCI.Pages.Dialog.AddRoom   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:HCI.Pages.Dialog     5      nclr-namespace:HCI     5        N� Title$  AddRoom��5
      .��5      � -   5        
�������.+�5   
   � $��31,608,-29,-103q�6   .+�5      �� .+�5         HCI.NavButton     Text$
 Home��6      ImageSource$ /Images/home.png��6*      NavUri$ /Pages/Landing.xaml?�6I    J� RenderTransformOrigin$ 0.849,0.702&�6f   $��86��6�   5      �� 5      .+�5        $ Notifications��6   $ /Images/bell.png��63   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��86��6�   5      �� 5      .+�5        $ 
My Profile��6   $ /Images/user.png��60   $ /Pages/Landing.xaml?�6O   $ 0.849,0.702&�6l   $��86��6�   5      �� 5      .+�5        $ Log out��6   $ /Images/logout.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��86��6�   5      �� 5      $��38, 22, 5, 6q�6   .+�5        $ Log out��6   $ /Images/square.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��31��6�   $��31��6�   5       �� 5!      $��88, 20, 5, 6q�6   .+�5"        $ Log out��6   $ /Images/new-moon.png��6-   $ /Pages/Landing.xaml?�6P   $ 0.849,0.702&�6m   $��31��6�   $��44��6�   5#      �� 5$      $��88, 20, 5, 6q�6   .+�5%        $ Log out��6   $ /Images/arrow-left.png��6-   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��44��6�   $��44��6�   5&      5'      �� 5(   
   -   5        $��name_tb��5(      $��Center=�6!   $��	0,138,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6�   $	��266��6�   ��6e   ��  �� Path$ RoomName� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5)   
   -   5        $��
surface_tb��5)      $��Center=�6$   $��	0,337,0,0q�6A   $
 Wrap=�6T   $	��Top=�6�   $	��266��6�   ��6h   �� $ Surface�6�   �� 5*   
   $
��Name��6   $��Medium"�6   $��Center=�63   $��0,97,0,0q�6P   $	��Top=�6b   $ 0.524,1.141&�6z   �� 5+   
   $
��Type��6   $��Medium"�6   $��Center=�63   $��	0,194,0,0q�6P   $	��Top=�6c   $ 0.524,1.141&�6{   �� 5,   
   $��Surface��6   $��Medium"�6"   $��Center=�66   $��	0,295,0,0q�6S   $	��Top=�6f   $ 0.524,1.141&�6~   �� 5-   
   $��Add room��6   $��Center=�6#   $
��Bold"�6@   $��20(�6R   $��0,35,0,0q�6`   $	��Top=�6r   �� 5.   
   -   5        $��	AddButton��5.      $	��Add��6"   $
��Left=�6R   $��245,462,0,0q�6m   $	��Top=�6�   $ 0.504,-0.73&�6�   ��60   �� *SubmitCommand+6�   �� 5/   
   $��Cancel��6   $
��Left=�6"   $��338,462,0,0q�6=   $	��Top=�6R   ��6j   �� *CancelCommand+�� 50   
   -   5        $��RoomEnum��50      $��Center=�6E   $��	0,246,0,0q�6b   $	��Top=�6u   $	��266��6�   ��6#   �� *	RoomTypes+6�   53      54      