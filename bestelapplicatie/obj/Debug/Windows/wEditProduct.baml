   M S B A M L   `   `   `  ����K  Gbestelapplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:bestelapplicatie.Windowsbestelapplicatie.Windows  5   	   +    %bestelapplicatie.Windows.wEditProduct   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:bestelapplicatie.Windows     5   	     � Title$  wEditProduct��5   	   $	��450��6   $	��250��6+    � WindowStartupLocation$ CenterScreen=�67    � Topmost . .��5	      � .+�5
   
   �� $
��Naam��6   $
��Left=�6   $��	10,10,0,0q�6:   $	��Top=�6M   �� 5   
   $��Prijs��6   $
��Left=�6    $��	10,41,0,0q�6;   $	��Top=�6N   �� 5   
   $��Producttype��6   $
��Left=�6&   $��	10,72,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��23��6>   $��
102,13,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtPrice��5      $
��Left=�6$   $��23��6?   $��
102,44,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5         ��Name$ cmbProducttype��5      $
��Left=�6+   $��
102,76,0,0q�6F   $	��Top=�6Z   $	��120��6r    �� DisplayMemberPath$ producttypeomschrijving��6~   �� 5   
   -   5         ��Name$ btnSave��5      $��Opslaan��6"   $
��Left=�64   $��
10,103,0,0q�6O   $	��Top=�6c   $	��212��6{   $��50��6�   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Verwijderen��6$   $
��Left=�6:   $��
10,322,0,0q�6U   $	��Top=�6i   $	��212��6�   6�   5      5      