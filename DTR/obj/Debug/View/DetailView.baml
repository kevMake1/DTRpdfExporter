   M S B A M L   `   `   `  ����>  :DTR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DTR.ViewDTR.View  5   	   -clr-namespace:DTR.ViewModelDTR.ViewModel  5   	       DTR.View.DetailView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DTR.View     5   	   *vmclr-namespace:DTR.ViewModel     5   	     � Title$  Edit Shipper��5	   	   $	��230��6   $	��400��6+    � 	Resources 5
         DTR.ViewModel.DetailVM   vm��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $
��Edit��5      �� 5    
   -   5         ��Name$ infoBox��5       $��1��5!      $��2��6#   $	��120��60   � 5$   
   $��1��6   $��3��6    5%      �� 5&      $��* �6#   �� 5'      $��* �6#    5)      �� 5*      $
��auto �6    .+�5-      �� -   5        $��0��5-      $��0��6%   $��Update��5.      $	��100��6&   5/      �� 50      -   5        $��1��50      $��0��6%   $��Delete��51      $	��100��6&   
���  ��
�������53      54      56      57      