   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	   #    Zadatak_1.View.AddProductView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  AddProductView��5   	   $	��450��6    $	��500��6-   .��5	      � .+�5   
   �� -   5        $��lblName��5      $��ProductName:��5      $
��Left=�5      $	��Top=�5      $��	50,84,0,0q�5      $��88��5      �� 5   
   -   5        $��lblProductKey��5      $��ProductKey:��5      $
��Left=�5      $	��Top=�5      $��
50,134,0,0q�5      $��88��5      �� 5   
   -   5        $��lblQuantity��5      $��	Quantity:��5      $
��Left=�5      $	��Top=�5      $��
50,190,0,0q�5      $��70��5      �� 5   
   -   5        $��lblPrice��5      $��Price:��5      $
��Left=�5      $	��Top=�5       $��
50,239,0,0q�5!      $��70��5"      �� 5#   
   -   5        $��txtName��5$      $
��Left=�5#      $��23��5%       �� TextWrapping$
 Wrap=�5&      $	��Top=�5'      $	��120��5(      $��
266,87,0,0q�5)      ��5*      �� *Product.ProductName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5,   
   -   5        $��txtKey��5-      $
��Left=�5,      $��23��5.      $
 Wrap=�5/      $	��Top=�51      $	��120��52      $��266,134,0,0q�53      ��50      �� *Product.ProductKey+$ PropertyChanged=�53      �� 54   
   -   5        $��txtQuantity��55      $
��Left=�54      $��23��56      $
 Wrap=�57      $	��Top=�59      $	��120��5:      $��266,192,0,0q�5;      ��58      �� *Product.Quantity+$ PropertyChanged=�5;      �� 5=   
   -   5        $��txtPrice��5>      $
��Left=�5=      $��23��5?      $
 Wrap=�5@      $	��Top=�5B      $	��120��5C      $��266,242,0,0q�5D      ��5A      �� *Product.Price+$ PropertyChanged=�5D      �� 5F   
   $
��Save��6   $
��Left=�5G      $	��Top=�5H      $��75��5I      $��140,304,0,0q�5J      ��5K      �� *Save+$ PropertyChanged=��� 5L   
   $��Close��6   $
��Left=�5M      $	��Top=�5N      $��75��5O      $��253,304,0,0q�5P      ��5Q      �� *Close+$ PropertyChanged=�5R      5S      