   M S B A M L   `   `   `  ����K  GSmart_University, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Smart_University.StudentsFunction!Smart_University.StudentsFunction  5   	   2    ,Smart_University.StudentsFunction.GroupsIMod   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Smart_University.StudentsFunction     5   	     � Title$  
MainWindow��5   	    � WindowStyle$
 None=�6    � WindowState$ 	Maximized=�60   .��5	      � ���#820300.+�5
   
   �� $
��1110��6   $	��810��6   ���#BF3131 �� CornerRadius$ 54��6@   $��Center=�6R   $��Center=�6o   ._�5      �� .+�5      � .+�5      �� $
��Left=�6   $	��100��67   $��../images/uni.png��6D   $��20q�6_   �� 5      $��Center=�6    $��20q�6=   $��60(�6I   $
��Bold"�6W   Grupy i moduły6y   �� 5      -   5        $��0q�5   1   ���	#00000000$	��140��6\   $��Right=�6i   $��20 0 0 0q�6�   $��0 0 0 0q�6�   .��5      �� $��Right=�6    $	��100��6<   $��../images/left.png��6I   $��20q�6e   5      5      �� 5       �� Orientation$ 
Horizontal=�6   $
��1100��66   .+�5      &   System.Windows.Controls.DataGrid  $
��1100��6G   $	��600��6T   $��Center=�6a   $��Center=�6~   ���#D9D9D9   AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .  $��0 26 0 0q�6�   ��6   �� *data_Groups_lst+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nazwa Grupy��61   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 350 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *	GrpName+6b     5      $	 Forma��61   $	
 300 6^    6@   �� *	TypeGrade+6^     5      $	 Prowadzący��61   $	
 400 6a    6E   �� *	Teacher+6a   5      5      5      5      5      5       