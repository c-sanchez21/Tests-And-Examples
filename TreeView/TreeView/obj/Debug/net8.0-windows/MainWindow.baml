   M S B A M L   `   `   `  ����C  ?TreeView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TreeViewTreeView  5   	       TreeView.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TreeView     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
���   �
������� � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   'R�       'Q� p     �� 5
   
   " R�6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �����6+   5      �� 5   
   " Q�6   .�5      ��  � ��
 �����6+   5      5      .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   ${�False��6&   m� 5      $��_Edit��6   ${�False��6&   m� 5      $��_View��6   ${�False��6&   5      � 5   
   $	��Top=�6    � RowDefinitions 5   
   �� 5      $
��.14* �6   �� 5      $
��.86* �6   .+�5   
   �� .+�5      �� $��0��6   $��Center=�6!   $��	ExtraBold"�6>   $��16(�6U   
�������.��6v   WPF TreeView Test6�   �� 5       �� Orientation$ 
Horizontal=�6   .+�5       �� 
�������.��6+   Name:62   �� 5!      -   5        $��txtName��5!      $��5 5 5 5q�6)   $��75��6:   �� 5"      -   5        $��btnAddChildren��5"      $��5 5 5 5q�6/   $	��100��6@   .��6l   Add Child Test6|   5#      5$      � 5%   
   $��1��6    � ColumnDefinitions 5&      �� 5'      $
��.25* �6#   �� 5(      $
��.75* �6#   .+�5,      �� $��TreeView��6   $��0��6)   .��5-      R� -   5         R�Name$ tvNodes��5-      ��6,   �� *Nodes+ 5.      	 �� DataType   TreeView.Node
 �� ItemsSource��%D  (��       5/   3   *, +)�� 6   "	  63   
 6R   �� *
SubNodes+.R�50      �� $ 
Horizontal=�6)   .+�51   "   �� ��6,   �� *Name+�� 52   "   $	��  (��6,   
����� �67   �� 53   "   
����� ���6,   �� *TotalSubNodesCount+6P   �� 54   "   $��)��6,   
����� �65   55      56      57      58      59      5;      5=      5>      5?      