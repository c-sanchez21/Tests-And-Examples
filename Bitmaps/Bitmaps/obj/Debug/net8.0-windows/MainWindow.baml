   M S B A M L   `   `   `  ����B  >Bitmaps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BitmapsBitmaps  5   	       Bitmaps.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Bitmaps     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
���   �.��5	      ]� .+�5
   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $��_Open��5      6*   5      m� 5      $��_Edit��6   ${�False��6&   m� 5      $��_View��6   ${�False��6&   5      � 5   
   $	��Top=�6    � ColumnDefinitions 5      �� 5      $	��.5* �6#   �� 5      $	��.5* �6#   .+�5      �� -   5         ��Name$ 	imgViewer��5      $��0��6'   �� 5      $��1��6    �� CanHorizontallyScroll$
 True��6)   .+�5      � -   5        $��glyphImageData��5       � FontUri$  C:\WINDOWS\Fonts\ARIAL.TTF?�5       � FontRenderingEmSize$ 12(�5       � StyleSimulations$ BoldSimulation=�5       � UnicodeString$ 
Image Data��5        � Fill
 �   �	 � OriginX$	 0��5"      
 � OriginY$
 25��5#      �� 5%      -   5         ��Name$ tbImageData��5%   ,   $��1��6   $
��Wrap=�6A   $
��Auto=�6U   5&      �� 5)      -   5         ��Name$ rtbImageData��5)   *   $��1��6   " �� VerticalScrollBarVisibility$ Visible=�6@   5*      5+      5,      