   M S B A M L   `   `   `  ����K  Gbestelapplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:bestelapplicatie.UserControlsbestelapplicatie.UserControls  5      ,    &bestelapplicatie.UserControls.UcOrders   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:bestelapplicatie.UserControls     5      
�������.��5	      � .+�5
   
   �� -   5          ��Name$  btnAddToOrder��5
      $��Toevoegen aan bestelling��6(   $
��Left=�6K   $��
55,255,0,0q�6f   $	��Top=�6z   $	��195��6�   $��35��6�   6�   �� 5   
   $��Producttype��6   $
��Left=�6&   $��
50,143,0,0q�6A   $	��Top=�6U   �� 5   
   $��Product��6   $
��Left=�6"   $��
50,175,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Aantal��6   $
��Left=�6!   $��
50,206,0,0q�6<   $	��Top=�6P   �� 5   
   -   5         ��Name$ cmbProducttype��5      $
��Left=�6+   $��130,143,0,0q�6F   $	��Top=�6[   $	��120��6s    �� DisplayMemberPath$ producttypeomschrijving��6   6�   �� 5   
   -   5        $ 
cmbProduct��5      $
��Left=�6'   $��130,177,0,0q�6B   $	��Top=�6W   $	��120��6o   $ productName��6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgbestelling��5      $
��Left=�6)   $	��315��6D   $��400,125,0,0q�6Q   $	��Top=�6f   $	��210��6~      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Product��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *product.productName+  5      $ Aantal��6%    65   �� *amount+4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� $  btnDeleteIPO��6%   -   5        $��Verwijderen��5   ;   6Q   5      5      5      �� 5   
   -   5         ��Name$ 	txtAantal��5      $
��Left=�6%   $��23��6@   $��130,218,0,0q�6L   	 �� TextWrapping$
	 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5    
   $��Klant: ��6   $
��Left=�6"   $��	47,25,0,0q�6=   $	��Top=�6P   �� 5!   
   -   5        $ cmbCustomer��5!      $
��Left=�6(   $��	95,25,0,0q�6C   $	��Top=�6V   $	��200��6n   $��26��6z   $ lastname��6�   6�   � 5"   
   $��970,51,324,609.8q�6   .+�5#      �� -   5        
 ��Name$
 lblLastname��5#      $��
Achternaam��6)   $
��Left=�6>   $��	10,10,0,0q�6Y   $	��Top=�6l   �� 5$      -	   5        $
 lblFirstname��5$      $��Voornaam��6*   $
��Left=�6=   $��	10,36,0,0q�6X   $	��Top=�6k   �� 5%      -
   5        $
 lblCity��5%      $��
Woonplaats��6%   $
��Left=�6:   $��	10,62,0,0q�6U   $	��Top=�6h   �� 5&      -   5        $
 lblPhonenumber��5&      $��Telefoonnummer��6,   $
��Left=�6E   $��	10,88,0,0q�6`   $	��Top=�6s   �� 5'      -   5        $
 lblEmail��5'      $��E-mail��6&   $
��Left=�67   $��
10,114,0,0q�6R   $	��Top=�6f   5(      �� 5)   
   -   5        $  btnOrder��5)      $��Plaats Bestelling��6#   $
��Left=�6?   $��720,255,0,0q�6Z   $	��Top=�6o   $	��175��6�   $��35��6�   6�   5+      5,      