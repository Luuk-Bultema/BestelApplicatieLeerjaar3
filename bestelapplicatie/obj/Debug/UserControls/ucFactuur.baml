   M S B A M L   `   `   `  ����K  Gbestelapplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:bestelapplicatie.UserControlsbestelapplicatie.UserControls  5      -    'bestelapplicatie.UserControls.ucFactuur   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:bestelapplicatie.UserControls     5      
�������.��5	      � $��-14,0,14,-0.2q�6   .+�5
   
   �� -   5          ��Name$  cmbKlant��5
      $
��Left=�6%   $��
230,29,0,0q�6@   $	��Top=�6T   $	��120��6l    �� DisplayMemberPath$ lastname��6x   6�   �� 5   
   $��Klant��6   $
��Left=�6    $��
135,29,0,0q�6;   $	��Top=�6O   � 5   
   $
��Left=�6   $	��157��6*   $��
580,19,0,0q�67   $	��Top=�6K   $	��485��6c   .+�5      �� -   5         ��Name$ txtFirstname��5      $��
Achternaam��6*   $
��Left=�6?   $��	10,10,0,0q�6Z   $	��Top=�6m   $��25��6�   $��80��6�   �� 5      -   5        $ txtLastname��5      $��Voornaam��6)   $
��Left=�6<   $��	10,40,0,0q�6W   $	��Top=�6j   $��25��6�   $��65��6�   �� 5      -   5        $ txtCity��5      $��
Woonplaats��6%   $
��Left=�6:   $��	10,70,0,0q�6U   $	��Top=�6h   $��25��6�   $	��110��6�   �� 5      -   5        $ txtPhonenumber��5      $��Telefoonnummer��6,   $
��Left=�6E   $��
10,100,0,0q�6`   $	��Top=�6t   $��25��6�   $	��100��6�   �� 5      -   5        $ txtEmail��5      $��Email��6&   $
��Left=�66   $��
10,125,0,0q�6Q   $	��Top=�6e   $��25��6}   $	��180��6�   �� 5      -   5        $ lblSelCustId��5      $��Nieuwe klant��6*   $
��Left=�6A   $��131,208,0,0q�6\   $	��Top=�6q   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCustomers��5      $
��Left=�6(   $	��254��6C   $��
30,185,0,0q�6P   $	��Top=�6d   $
��1180��6|      CanUserAddRows .     AutoGenerateColumns .     
IsReadOnly . 
���   ����	#FFF0F0F0$ lastname��6(     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *date+  5      $ Voornaam��6%   	 67   �� *customer.firstname+  5      $ 
Achternaam��6%   	 69   �� *customer.lastname+  5      $ 
Woonplaats��6%   	 69   �� *customer.city+  5      $ Telefoonnummer��6%   	 6=   �� *customer.phonenumber+  5      $ E-mail��6%   	 65   �� *customer.email+5        5   
   -	   5        $ dgIPO��5      $
��Left=�6"   $	��254��6=   $��
30,476,0,0q�6J   $	��Top=�6^   $
��1180��6v    .   .   . 
���   ����	#FFF0F0F0 5        5       $ Producttype��6e   	 6%   �� *-+product.producttype.producttypeomschrijving+6e     5!      $ Product��6M   	 6%   �� *product.productName+6M     5"      $ Aantal��6@   	 6%   �� *amount+6@     5#      $ Prijs per product��6G   	 6%   �� *product.price+6G   5%      (  "System.Windows.Controls.DatePicker  5&   
   -
   5        
  Name$
 DPdate1��5&      $
��Left=�6&   $��
198,83,0,0q�6A   $	��Top=�6U   6m   �� 5'   
   $	��Van��6   $
��Left=�6   $��
135,81,0,0q�69   $	��Top=�6M   �� 5(   
   $	��Tot��6   $
��Left=�6   $��
350,83,0,0q�69   $	��Top=�6M     5)   
   -   5        $
 DPdate2��5)      $
��Left=�6&   $��
415,83,0,0q�6A   $	��Top=�6U   �� 5*   
   -   5         ��Name$ btnSelectTimePeriod��5*      $��Selecteer periode��6.   $
��Left=�6J   $��198,145,0,0q�6e   $	��Top=�6z   $	��302��6�   $��31��6�   6�   5+      5.      