   M S B A M L   `   `   `  ����T  PschulerAppMayssaAlnawaqil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:schulerAppMayssaAlnawaqilschulerAppMayssaAlnawaqil  5   	   *    $schulerAppMayssaAlnawaqil.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:schulerAppMayssaAlnawaqil     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   $��14(�6R   .��5	      ]�    lightTuerkis#��[  6   .+�5
   
   o� $	��Top=�6   $��25��6$     	lightBlue#��[ 60   .@�5      m� $��Datei��6     Blue#��[ 6&   $��1,1,1,1q�6K   .@�5      m� -   5        $��neues Schuler��5        
lightGreen#��[ 6U    m� Icon 5      �� 5      $��/icons/student.png��6    5      5      m� 5      -   5        $��
Bearbeiten��5      #��[ 6+   $��1,1,1,1q�6g   .@�5      m� -   5        $��ausgew. Schuler loeschen��5      #��[ 6Z    5      �� 5      $��/icons/trash.png��6    5      5      5      � 5   
   $
��Left=�6   $	��300��6%    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� .+�5       �� $��	Firstname��6   �� 5!      $��Lastname��6   �� 5"      $��Class Number��6   �� 5#      -   5        $	��Add��5#      $��Center=�6'   $��3,75,3,3q�6D   $	��Top=�6V   $	��130��6n   #��[ 6�   6�   �� 5$      -   5         ��Name$ delete1��5$      $��Delete��6*   $��Center=�6;   $��3,3,3,3q�6X   #��[ 6i   $	��Top=�6�   $	��130��6�   6�   �� 5%      -   5        $ update��5%      $��Update��6)   #��[ 6:   $	��130��6_   6k   �� 5&      $	��130��6   $��30��6&   $��3,3,3,3q�6L     lighterGreen#��[ 6]   ��62   �� *
SuchText+6]   �� 5'      -   5        $	��130��5'   4   $��0,3,0,3q�6@   #��[ 6Q   .��6w   Suchen6   5(      �� 5)      $��1��6   .+�5*      �� -	   5         ��Name$ txt_firstname��5*       �� TextWrapping$
 Wrap=�61   $	��120��6m   $��2,2,2,2q�6y   #��[ 6�   ��6E   �� *NeuesSchuler.Firstname+6�   �� 5+      -
   5        $ txt_lastname��5+      $
 Wrap=�60   $	��120��6k   $��2,2,2,2q�6w   #��[ 6�   ��6D   �� *NeuesSchuler.Lastname+6�   �� 5,      -   5        $ txt_classno��5,      $
 Wrap=�6/   $	��120��6j   $��2,2,2,2q�6v   #��[ 6�   ��6C   �� *NeuesSchuler.ClassNo+6�   5.      50      �� 51   
   $��50��6   $��Bottom=�6      	lightPink#��[ 68   .@�52      �� $	��150��6   ��6(   �� *Statusanzeige+�� 53      $	��150��6   ��6(   �� * AusgewaehltesSchuler.Firstname+�� 54      $	��192��6=   $��0,-2,0,2q�6I   ��6   �� *ErrorMessage+6I   55      &   System.Windows.Controls.DataGrid  56   
   -   5          Name$
 dgv1��56   @   #��[ 6   $	��478��6N   $	��329��6Z    �� SelectedIndex$ 0��6�   	 J� IsManipulationEnabled	 . $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6�   58      59      5:      