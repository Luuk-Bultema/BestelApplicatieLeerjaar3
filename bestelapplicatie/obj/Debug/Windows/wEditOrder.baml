   M S B A M L   `   `   `  ����K  Gbestelapplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:bestelapplicatie.Windowsbestelapplicatie.Windows  5   	   )    #bestelapplicatie.Windows.wEditOrder   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:bestelapplicatie.Windows     5   	     � Title$  
wEditOrder��5   	   $	��700��6   $	��850��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btnSave��5
      $��Klant wijzigen��6"   $
��Left=�6;   $��
160,95,0,0q�6V   $	��Top=�6j   $	��120��6�   $��20��6�   6�   �� 5   
   -   5        $ 	btnDelete��5      $��Bestelling verwijderen��6$   $
��Left=�6E   $��160,210,0,0q�6`   $	��Top=�6u   $	��250��6�   $��25��6�   6�   �� 5   
   -   5         ��Name$ cmbCustomer��5      $
��Left=�6(   $��
160,50,0,0q�6C   $	��Top=�6W   $	��120��6o    �� DisplayMemberPath$ lastname��6{   6�   �� 5   
   $��Klant��6   $
��Left=�6    $��
160,10,0,0q�6;   $	��Top=�6O   $��25��6g   $	��150��6s   � 5   
   $
��Left=�6   $	��157��6*   $��
415,33,0,0q�67   $	��Top=�6K   $	��600��6c   .+�5      �� -   5         ��Name$ txtFirstname��5      $��
Achternaam��6*   $
��Left=�6?   $��	10,10,0,0q�6Z   $	��Top=�6m   $��25��6�   $��80��6�   �� 5      -   5        $ txtLastname��5      $��Voornaam��6)   $
��Left=�6<   $��	10,40,0,0q�6W   $	��Top=�6j   $��25��6�   $��65��6�   �� 5      -   5        $ txtCity��5      $��
Woonplaats��6%   $
��Left=�6:   $��	10,70,0,0q�6U   $	��Top=�6h   $��25��6�   $	��110��6�   �� 5      -   5        $ txtPhonenumber��5      $��Telefoonnummer��6,   $
��Left=�6E   $��
10,100,0,0q�6`   $	��Top=�6t   $��25��6�   $	��100��6�   �� 5      -   5        $ txtEmail��5      $��E-mail��6&   $
��Left=�67   $��
10,125,0,0q�6R   $	��Top=�6f   $��25��6~   $	��180��6�   5      &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dgIPOs��5      $
��Left=�6#   $	��391��6>   $��	0,280,0,0q�6K   $	��Top=�6^   $	��844��6v      CanUserAddRows .     AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Producttype��6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *-+product.producttype.producttypeomschrijving+6e     5      $
 Product��6M    6%   �� *product.productName+6M     5      $
 Aantal��6@    6%   �� *amount+6@     5      $
 Prijs per product��6G    6%   �� *product.price+6G   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5       .R�5!      �� $ btnVerwijderIPOs��6%   -
   5        $��verwijderen��5!   ?   6U   5"      5$      5&      5'      5)      