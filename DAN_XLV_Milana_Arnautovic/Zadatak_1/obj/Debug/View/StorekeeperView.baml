   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	   $    Zadatak_1.View.StorekeeperView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  StorekeeperView��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5      $��6 �6   �� 5      $
��auto �6   �� 5       $��20 �6   .+�5"   
   � $��1��6   $��1��5#      $
��auto��5$      $
��auto��5%      .+�5&      &   System.Windows.Controls.DataGrid  -   5        $��DataGridResults��5&         
IsReadOnly .    HeadersVisibility$ Column=�5*         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �
���   �
���   �$
��Bold"�50      ��5'      �� *ProductList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5(      �� *	Product+$ PropertyChanged=�y�5,      �� *ViewProduct+$ PropertyChanged=�	   Columns	 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Product Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 53   )   �� *ProductName+  54      $
 Product Key��6)    55   )   �� *
ProductKey+  56      $
 Quantity��6)    57   )   �� *
Quantity+  58      $
 Price��6)    59   )   �� *Price+  5:      $
 Stored��6)    5;   )   �� *Stored+5=      5>      �� 5?   
   -   5        $��btnStoreProduct��5@      $��Store Product��5A      $��80��5B      $��20��5C      $
��Bold"�5E      $��51.2,0.2,-110.4,6.2q�6#   $��4��6@   $��1��6P   ��5D      �� *StoreProduct+$ PropertyChanged=�5E   P   5G      5H      