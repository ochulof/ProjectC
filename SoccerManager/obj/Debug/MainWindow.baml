   M S B A M L   `   `   `  ����  SoccerManager    SoccerManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  Soccer_Manager_��5   	    � Title$ Welkom bij Soccer Manager��5   	   $��372.993��6+   $	��520��6<    � WindowStyle$ ThreeDBorderWindow=�6H    � 
ResizeMode$ NoResize=�6i    � WindowStartupLocation$ CenterScreen=�6   ���	#FF658097.��5      � $
��Left=�6   $	��325��6&   $	��Top=�63   $	��520��6K    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5
   
   �� 5      $	��25* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   o� -   5         o�Name$ mnu_hoofdmenu��5      $
��Left=�6&   $��25��6A   $	��Top=�6M   $	��510��6e   $��2��6q   .@�5      m� -   5         m�Name$ mnu_Bestand��5      $��Bestand��6,   .@�5      m� -   5        $ mnu_Inloggen��5      $��Inloggen��61   $
��Left=�6C   $	��200��6^   	 � ToolTip$ 	 Inloggen als administrator��6j   6�   m� 5      -   5        $ mnu_Afmelden��5      $��Afmelden��61   $
��Left=�6C   $	��200��6^   $!	 Uitloggen als administrator��6j   6�   m� 5      -   5        $ 	mnu_Nieuw��5      $��Nieuw��6.   $
��Left=�6=   $	��200��6X   .@�5      m� -   5        $ mnu_nieuw_speler��5      $��Speler��69   $
��Left=�6I   $	��145��6d   $	 Maak nieuwe spelers��6p   6�   m� 5      -   5        $ mnu_nieuw_team��5      $
��Team��67   $
��Left=�6E   $	��145��6`   $	 Maak een nieuw team��6l   6�   m� 5      -	   5        $ mnu_nieuw_wedstrijd��5      $��	Wedstrijd��6<   $
��Left=�6O   $	��145��6j   $	 Maak een nieuwe wedstrijd��6v   6�   5      m� 5      -
   5        $ mnu_Wedstrijdschema��5      $��Wedstrijdschema��68   $
��Left=�6Q   $	��200��6l   $	 Wedstrijdschema weergeven��6x   6�   m� 5      -   5        $ 	mnu_teams��5      $��Teams��6.   $
��Left=�6=   $	��200��6X   $	 Toon de teams��6d   6|   m� 5      -   5        $ mnu_spelerslijst��5      $��Spelerslijst��65   $
��Left=�6K   $	��200��6f   $	 Toon de spelerslijst��6r   6�   m� 5      -   5        $ 
mnu_Finale��5      $��Finales��6/   $
��Left=�6@   $	��200��6[   $	 Toon de finales��6g   6�   m� 5      -   5        $ mnu_afsluiten��5      $��	Afsluiten��62   $
��Left=�6E   $	��200��6`   $	 Sluit het programma af��6l   6�   5      m� 5      -   5        $ mnu_Help��5      $
��Help��6)   $	 	Toon Hulp��67   6K   5       �� 5!   
   -   5        
 ��Name$
 btn_wedstrijdschema��5!      $��Wedstrijdschema��6.   $
��Left=�6H   $��	50,10,0,0q�6c   $��1��6v   $��Center=�6�   $	��150��6�   $��80��6�   $	 Toon het wedstrijdschema��6�      ButtonStyle#��[  6�   �� 5"   
   -   5        $
 btn_klassement��5"      $��
Klassement��6)   $
��Left=�6>   $��	50,10,0,0q�6Y   $��2��6l   $	��Top=�6y   $	��150��6�   $��80��6�   $	 Toon het klassement��6�   #��[  6�   �� 5#   
   -   5        $
 	btn_teams��5#      $��Teams��6$   $
��Left=�64   $��	50,10,0,0q�6O   $��1��6b   $	��Top=�6o   $	��150��6�   $��80��6�   $	 
Toon teams��6�   $��1��6�   #��[  6�   �� 5$   
   -   5        $
 btn_spelerslijst��5$      $��Spelerslijst��6+   $
��Left=�6B   $��	50,10,0,0q�6]   $��2��6p   $	��Top=�6}   $	��150��6�   $��80��6�   $	 Toon de spelerslijst��6�   $��1��6�   #��[  6�   �� 5%   
   -   5        $
 btn_nieuw_team��5%      $��
Nieuw Team��6)   $
��Left=�6>   $��	50,10,0,0q�6Y   $��3��6l   $	��Top=�6y   $	��150��6�   $��80��6�   $	 Maak een nieuw team��6�   #��[  6�   �� 5&   
   -   5        $
 btn_nieuwe_spelers��5&      $��Nieuwe spelers��6-   $
��Left=�6F   $��	50,10,0,0q�6a   $��3��6t   $	��Top=�6�   $	��150��6�   $��80��6�   $	 Maak nieuwe spelers��6�   $��1��6�   #��[  6   5'      5(      