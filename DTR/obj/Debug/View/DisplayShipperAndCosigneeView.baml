   M S B A M L   `   `   `  ����>  :DTR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DTR.ViewDTR.View  5   	   -clr-namespace:DTR.ViewModelDTR.ViewModel  5   	   ,    &DTR.View.DisplayShipperAndCosigneeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DTR.View     5   	   *vmclr-namespace:DTR.ViewModel     5   	     � Title$   All Shippers And Cosignees��5	   	   $	��400��6,   $	��800��69    � 	Resources 5
      /  )DTR.ViewModel.DisplayShipperAndCosigneeVM   vm��%   &	          5   
   6)   5      .��5      � -   5         �Name$ myGrid��5       � DataContext# [  6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��Shipper/Exporter��5       �� 5"   
   -   5         ��Name$ ShipperView��5"      $��1��5#      $��2��6#   $	��300��60   $��4,0,4,0q�6>   ��5&      �� 5'      .R�5(      ��  �� Orientation$ 
Horizontal=�6!   .+�5)      �� ��6$   �� *ShipperInfo+5*      5+      5-      �� 5/   
   $��2��6   $��1��6$   $��Cosignee��50      �� 51   
   -   5        $ CosigneeView��51      $��2��52      $��2��6#   $	��300��60   $��4,0,4,0q�6=   ��55      �� 56      .R�57      �� $ 
Horizontal=�6!   .+�58      �� ��6$   �� *CosigneeInfo+59      5:      5<      � 5>   
   $��1��6   $��3��6    5?      �� 5@      $��* �6#   �� 5A      $��* �6#    5C      �� 5D      $
��auto �6    5F      5H      5I      