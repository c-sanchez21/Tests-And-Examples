   M S B A M L   `   `   `  ����F  BUniformGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:UniformGridUniformGrid  5   	       UniformGrid.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:UniformGrid     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
���������5	      �� 5
   
    �� EndPoint$ 0.5,0&�6    �� 
StartPoint$
 .5,1&�6/   .��5      �  � Color$ 	#FF171717��6    � Offset$ 0Q�6-   � 5      $ 	#FF040404��6   $ 1Q�6-   5       � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��.1* �6   �� 5      $	��.1* �6   �� 5      $	��.8* �6   .+�5   
   �� $��0��6   $��Center=�67   ��6   �� *Month+67   �� 5   
   $��1��6   
������ ��6   �� *	DayOfWeek+��5       �� 5!      .R�5"      A� 
 A� Rows$
 1��6"    A� Columns$ 7��6+   5#      ��5%      �� 5&      .R�5'      �� $��Center=�61   
���������6    �� 6N   5)      5+      �� 5.   
   $��2��6   
������ $��Stretch=�6U   $��Stretch=�6z   ��6   �� *Days+��5/      �� 50      .R�51      A� $
 5��6"   $ 7��6+   52      ��54      �� 55      .R�56      �� $��1q�6   
�������._�57      (� .��58      �� 
���������6;   �� *Date+ �� Mode$ TwoWay=� �� TargetNullValue$  �� �� UpdateSourceTrigger$ PropertyChanged=� �� StringFormat$ dd����59   "   �� 5:   &   " ��6,    �� Triggers 5;   *   �� 5=   .    �� Binding 6:   �� *	IsToday+ �� Value True6V   .a�5>   2   ��  � �� 5?   6   �� 5@   :   $ 0.5,1&�6N   $ 0.5,0&�6_   .��5A   >   � $
 Blue��6K   $	 0.5Q�6Y   � 5B   >   $
 Cyan��6K   $ 1Q�6Y   5C   ;   5E   3   5F   /   5H   '   5J      5K      5L      5M      5O      5Q      5R      