   M S B A M L   `   `   `  ����J  FCompras.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Compras.DesktopCompras.Desktop  5   	        Compras.Desktop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Compras.Desktop     5   	     � Title$  Compras��5   	   $��Expanded&�5	   	    � Icon$ Images/cart.png��5
   	   $��Verdana)�5   	   $��12(�5   	    � WindowStyle$ ThreeDBorderWindow=�5   	   
�������.��5      � -   5         �Name$ 	MainPanel��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� .+�5      o� $��Expanded&�6   $��Verdana)�6*   .@�5      m� $��10 10 10 10q�6   $��Arquivo��61   .@�5      m� -   5        $
��Sair��5      6-   5      m� 5      $��10 10 10 10q�6   $��Exibir��61   m� 5      $��10 10 10 10q�6   $��Ferramentas��61   .@�5      m� -   5        $��Compras��5      60   5      m� 5      $��10 10 10 10q�6   $��Sobre��61   5       �� 5"      $��5 5 5 5q�6   
�������.+�5#      �� $��Center=�6    �� Padding$ 15 15 15 15q�69   $��5 5 5 5q�6O   $��16(�6`   $
��Bold"�6n   $4��.Programa de registro de compras - Puro Recheio��6�   5$      � 5'      $��5 5 5 5q�6    � ColumnDefinitions 5(      �� 5)      $��* �6'   �� 5*      $��5* �6'    5-      �� 5.      $��* �6$   �� 5/      $��* �6$   �� 50      $��* �6$   .+�53      �� -   5        
���   �$��2q�53   -   $��
0 10 10 10q�6A   $
��Bold"�6V   $��0��6h   $��1��6x   $��5 5 5 5q�6�   .��54      �� $
��Left=�6!    �� Orientation$ 
Horizontal=�6<   .+�55      �� $
��Left=�6    $��Images/list.png��6;   $��20��6T   $��5 0 5 0q�6_   �� 56      $��Center=�6$   $
��Left=�6?   $��Ver compras efetuadas��6Z   6y   57      58      �� 5:      -   5        
���   �$��2q�5:   -   $��
0 10 10 10q�6A   $
��Bold"�6V   $��0��6h   $��2��6x   $��5 5 5 5q�6�   .��5;      �� $
��Left=�6!   $ 
Horizontal=�6<   .+�5<      �� $
��Left=�6    $��Images/add.png��6;   $��20��6S   $��5 0 5 0q�6^   �� 5=      $��Center=�6$    �� TextAlignment$
 Left=�6?   $
��Left=�6T   $��Nova compra��6o   6�   5>      5?      5@      5A      �� 5C   
   $��1��6   $��5 15 5 5q�6"   
�������.+�5D      �� $��15 15 15 15q�6    Contato: vitorebertz@gmail.com5F      �� 5G      $��15 15 15 15q�6   http://www.purorecheio.com.br5I      5J      5L      5M      