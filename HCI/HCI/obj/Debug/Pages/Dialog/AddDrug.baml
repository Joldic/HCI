   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:HCI.Pages.DialogHCI.Pages.Dialog  5      clr-namespace:HCIHCI  64       HCI.Pages.Dialog.AddDrug   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:HCI.Pages.Dialog     5      nclr-namespace:HCI     64     N� Title$  AddDrug��5	      .��5      � -   5        
�������.+�5   
   � $��31,608,-29,-103q�6   .+�5      �� .+�5         HCI.NavButton     Text$
 Home��6      ImageSource$ /Images/home.png��6*      NavUri$ /Pages/Landing.xaml?�6I    J� RenderTransformOrigin$ 0.849,0.702&�6f   $��86��6�   5      �� 5      .+�5        $ Notifications��6   $ /Images/bell.png��63   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��86��6�   5      �� 5      .+�5        $ 
My Profile��6   $ /Images/user.png��60   $ /Pages/Landing.xaml?�6O   $ 0.849,0.702&�6l   $��86��6�   5      �� 5      .+�5        $ Log out��6   $ /Images/logout.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��86��6�   5      �� 5      $��38, 22, 5, 6q�6   .+�5        $ Log out��6   $ /Images/square.png��6-   $ /Pages/Landing.xaml?�6N   $ 0.849,0.702&�6k   $��31��6�   $��31��6�   5      �� 5       $��88, 20, 5, 6q�6   .+�5!        $ Log out��6   $ /Images/new-moon.png��6-   $ /Pages/Landing.xaml?�6P   $ 0.849,0.702&�6m   $��31��6�   $��44��6�   5"      �� 5#      $��88, 20, 5, 6q�6   .+�5$        $ Log out��6   $ /Images/arrow-left.png��6-   $ /Pages/Landing.xaml?�6R   $ 0.849,0.702&�6o   $��44��6�   $��44��6�   5%      5&      �� 5'   
   -   5        $��name_tb��5'      $��Center=�6!   $��	0,138,0,0q�6>    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6�   $	��266��6�   ��6e   ��  �� Path$
 Name� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5(   
   -   5        $��	weight_tb��5(      $��Center=�6#   $��	0,235,0,0q�6@   $
 Wrap=�6S   $	��Top=�6�   $	��266��6�   ��6g   �� $ Weight�6�   �� 5)   
   -   5        $��category_tb��5)      $��Center=�6%   $��	0,337,0,0q�6B   $
 Wrap=�6U   $	��Top=�6�   $	��266��6�   ��6i   �� $ Category�6�   �� 5*   
   -   5        $��quantity_tb��5*      $��Center=�6%   $��	0,436,0,0q�6B   $
 Wrap=�6U   $	��Top=�6�   $	��266��6�   ��6i   �� $ Quantity�6�   �� 5+   
   $
��Name��6   $��Medium"�6   $��Center=�63   $��0,97,0,0q�6P   $	��Top=�6b   $ 0.524,1.141&�6z   �� 5,   
   $��Weight��6   $��Medium"�6!   $��Center=�65   $��	0,194,0,0q�6R   $	��Top=�6e   $ 0.524,1.141&�6}   �� 5-   
   $��Category��6   $��Medium"�6#   $��Center=�67   $��	0,295,0,0q�6T   $	��Top=�6g   $ 0.524,1.141&�6   �� 5.   
   $��Quantity��6   $��Medium"�6#   $��Center=�67   $��	0,389,0,0q�6T   $	��Top=�6g   $ 0.524,1.141&�6   �� 5/   
   $��Add drug��6   $��Center=�6#   $
��Bold"�6@   $��20(�6R   $��0,35,0,0q�6`   $	��Top=�6r   �� 50   
   -   5        $��	AddButton��50      $	��Add��6"   $
��Left=�6R   $��245,496,0,0q�6m   $	��Top=�6�   ��60   �� *SubmitCommand+6�   �� 51   
   $��Cancel��6   $
��Left=�6"   $��345,496,0,0q�6=   $	��Top=�6R   ��6j   �� *CancelCommand+�� 52   
   -   5        $
��Demo��52      $
��Left=�6    $��101,496,0,0q�6;   $	��Top=�6P   6h   55      56      