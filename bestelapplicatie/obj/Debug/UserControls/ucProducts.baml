   M S B A M L   `   `   `  ����K  Gbestelapplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:bestelapplicatie.UserControlsbestelapplicatie.UserControls  5      .    (bestelapplicatie.UserControls.ucProducts   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:bestelapplicatie.UserControls     5      
�������.��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  
dgProducts��5
      $
��Left=�6'   $	��789��6B   $��	10,10,0,0q�6O   $	��Top=�6b   $	��650��6z      CanUserAddRows .     
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Naam��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *productName+  5      $ Prijs��6%    64   �� *price+  5      $ Producttype��6%    6:   �� *%#producttype.producttypeomschrijving+5      �� 5   
   $
��Naam��6   $
��Left=�6   $��
665,10,0,0q�6:   $	��Top=�6N   �� 5   
   $��Prijs��6   $
��Left=�6    $��
665,41,0,0q�6;   $	��Top=�6O   �� 5   
   $��Producttype��6   $
��Left=�6&   $��
665,72,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��22��6>   $��
758,14,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtPrice��5      $
��Left=�6$   $��23��6?   $��
758,44,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        	 ��Name$	 cmbProducttype��5      $
��Left=�6+   $��
758,76,0,0q�6F   $	��Top=�6Z   $	��120��6r   
 �� DisplayMemberPath$
 producttypeomschrijving��6~   �� 5   
   -   5         ��Name$ btnSave��5      $��Opslaan��6"   $
��Left=�64   $��665,103,0,0q�6O   $	��Top=�6d   $	��213��6|   $��50��6�   6�   �� 5   
   -   5        $ btnManagePT��5      $��Beheren��6&   $
��Left=�68   $��
883,76,0,0q�6S   $	��Top=�6g   $��75��6   $��22��6�   6�   5      5      