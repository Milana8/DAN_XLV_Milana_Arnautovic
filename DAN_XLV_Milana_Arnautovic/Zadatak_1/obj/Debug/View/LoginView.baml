   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Zadatak_1.ViewZadatak_1.View  5   	       Zadatak_1.View.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Zadatak_1.View     5   	     � Title$  	LoginView��5   	   $	��450��6   $	��500��6(   .��5	      ��  �� CornerRadius$ 20��6   $��20q�6    ._�5
   
   �� $��15q�6   .+�5      �� $��Login��6   
���   �$��25(�67   $��Center=�6E   �� 5      6   �� 5      $��Username��6   
���   �$
��0 -5q�6:   �� 5      -   5        $��txtUsername��5      
���   �$��12(�6�   $��0,10,-0.2,10q�6�   $��34��6�   ��6)   �� *
UserName+ �� UpdateSourceTrigger$ 	LostFocus=� �� ValidatesOnDataErrors . 6�   �� 5      $��Password��6   
���   �$
��0 10q�6:   G� 5      -   5        $��passwordBox��5      
���   �$��12(�6A   $��0,-10,-0.2,-10q�6O   $��35��6g   �� 5      -   5        $��btnLogin��5      $��Login��6%   $��111,25,98.8,25q�65   ���#545d6a
�������$��18(�6u    �� 	IsDefault . ��5      �� *Login+$ PropertyChanged=���6T   ��  �� ElementName$ passwordBox����5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6*   �� $ txtUsername��	 �� Path$
	 Text�
 �� Value
  5   *   .a�5   "   ��  �� Property � {� �� Value .  5   )   5      �� 5       6*   �� $ txtPassword��$	 Password�
  5   )   .a�5   "   ��  � {� .  5   )   5       5"      5$      5&      5'      5(      