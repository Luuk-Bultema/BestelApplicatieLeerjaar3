   M S B A M L   `   `   `  ����K  Gbestelapplicatie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:bestelapplicatie.UserControlsbestelapplicatie.UserControls  5      /    )bestelapplicatie.UserControls.ucCustomers   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:bestelapplicatie.UserControls     5      
�������.��5	      � .+�5
   
   � .+�5      &   System.Windows.Controls.DataGrid  -   5           Name$  dgCustomers��5      $
��Left=�6,   $	��789��6G   $��	10,10,0,0q�6T   $	��Top=�6g   $
��1000��6      CanUserAddRows .     AutoGenerateColumns .     
IsReadOnly . 
���   ����	#FFF0F0F0   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Voornaam��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	firstname+  5      $ 
Achternaam��6)    6=   �� *
lastname+  5      $ 
Woonplaats��6)    6=   �� *city+  5      $ Telefoonnummer��6)    6A   �� *phonenumber+  5      $ E-mail��6)    69   �� *email+5      �� 5      
���   �$��1q�6)   $
��Left=�6=   $	��400��6X   $��1140,10,0,0q�6e   $	��Top=�6z   $	��300��6�   ._�5      � $��-0.8,-0.8,0.2,1.2q�6    � RowDefinitions 5      �� 5      $
��163* �6(   �� 5      $	��36* �6(   .+�5      �� $��
Achternaam��6   $
��Left=�61   $��	10,41,0,0q�6L   $	��Top=�6_   $��23��6w   �� 5      -   5         ��Name$ txtLastname��5      $
��Left=�63   $��23��6N   $��
115,41,0,0q�6Z   	 �� TextWrapping$
	 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��173��6�   �� 5      $��
Woonplaats��6   $
��Left=�61   $��	10,69,0,0q�6L   $	��Top=�6_   $��23��6w   �� 5      -   5        $ txtCity��5      $
��Left=�6/   $��23��6J   $��
115,69,0,0q�6V   $
	 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��173��6�   �� 5      $��Telefoonnummer��6   $
��Left=�65   $��	10,97,0,0q�6P   $	��Top=�6c   $��23��6{   �� 5      -   5        $ txtPhonenumber��5      $
��Left=�66   $��23��6Q   $��
115,97,0,0q�6]   $
	 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��173��6�   �� 5       $��Email��6   $
��Left=�6,   $��
10,125,0,0q�6G   $	��Top=�6[   $��23��6s   �� 5!      -   5        $ txtEmail��5!      $
��Left=�60   $��23��6K   $��115,125,0,0q�6W   $
	 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��173��6�   �� 5"      $��Voornaam��6   $
��Left=�6/   $��	10,13,0,0q�6J   $	��Top=�6]   $��23��6u   �� 5#      -   5        $ txtFirstname��5#      $
��Left=�64   $��23��6O   $��
115,13,0,0q�6[   $
	 Wrap=�6o   $�� ��6�   $	��Top=�6�   $	��173��6�   �� 5$      -   5        
 ��Name$
 btnSave��5$      $��Opslaan��6.   $
��Left=�6@   $��
10,153,0,0q�6[   $	��Top=�6o   $	��278��6�   $��50��6�   6�   �� 5%      $��Geselecteerde klant:��6   $
��Left=�6;   $��
10,208,0,0q�6V   $	��Top=�6j   �� 5&      -   5         ��Name$ lblSelCustId��5&      $��Nieuwe klant��62   $
��Left=�6I   $��131,208,0,0q�6d   $	��Top=�6y   �� 5'      -	   5        $ lblSelCustName��5'      $�� ��64   $
��Left=�6?   $��131,239,0,0q�6Z   $	��Top=�6o   $	��157��6�   �� 5(      -
   5        $
 
btnNewCust��5(      $��Nieuw��61   $
��Left=�6A   $��215,208,0,0q�6\   $	��Top=�6q   $��73��6�   $��26��6�   6�   �� 5)      -   5        $
 btnDeleteCust��5)      $��Verwijderen��64   $
��Left=�6J   $��	10,32,0,0q�6e   $	��Top=�6x   $	��278��6�   $��1��6�   $��30��6�   
���  ��$y�Hidden=�6�   5+      5,      �� 5-      $��Totaal aantal klanten: ��6   $
��Left=�66   $��1015,773,0,0q�6Q   $	��Top=�6g   �� 5.      -   5        $ lblCustCount��5.      $�� ��6*   $
��Left=�65   $��1140,773,0,0q�6P   $	��Top=�6f   50      52      53      