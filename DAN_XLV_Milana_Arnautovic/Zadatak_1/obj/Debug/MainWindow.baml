   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zadatak_1	Zadatak_1  5   	       Zadatak_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zadatak_1     5   	     � Title$  Manager��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridResults��5       $��1��6      
IsReadOnly .    HeadersVisibility$ Column=�5         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �
���   �
���   �$
��Bold"�5      ��5      �� *ProductList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedProduct+$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 ProductName��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5!   %   �� *ProductName+  5"      $	 
ProductKey��6%   
 5#   %   �� *
ProductKey+  5%      $	 Quantity��6%   
 5&   %   �� *
Quantity+  5(      $	 Price��6%   
 5)   %   �� *Price+  5*      $	 Stored��6%   
 5+   %   �� *Stored+4  .System.Windows.Controls.DataGridTemplateColumn  5-         CellTemplate 5.      �� 5/      .R�50      �� $��btnDeleteProduct��6%   $��Delete��51   &   ��50   =   �� *DeleteProduct+$ PropertyChanged=�51   &   52      54      57      �� 58   
   -   5        $��btnAdd��58      $��2��6   $��Add Product��6,   $��90��6B   $��20��6M   $
��Bold"�59   U   $��170,5.2,533.6,5.2q�6g   ��6   �� *
AddCommand+$ PropertyChanged=�6g   �� 5:   
   -   5        $��btnEdit��5:      $��Edit Product��6    $��90��67   $��20��6B   $
��Bold"�5;   V   $��21,5.8,682.6,4.6q�6h   $��2��6�   ��6   �� *EditCommand+$ PropertyChanged=�6�   5=      5?      