   M S B A M L   `   `   `  ����J  FCompras.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Compras.Desktop.JanelasCompras.Desktop.Janelas  5   	   ,    &Compras.Desktop.Janelas.TelaNovaCompra   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Compras.Desktop.Janelas     5   	     � Title$  
NovaCompra��5   	   $��Verdana)�5	   	   $��Expanded&�5
   	    � WindowStyle$ ThreeDBorderWindow=�5   	    � SizeToContent$ WidthAndHeight=�5   	    � Icon$ ../Images/cart.png��5   	    � 	Resources 5      4   .Compras.Desktop.Janelas.DinheiroValueConverter   DinheiroValueConverter��%   &	          5   
   6'   5      .��5      �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��15 15 15 15q�6   $��Center=�6.   Data da compra:5      (  "System.Windows.Controls.DatePicker  5      $��15 15 15 15q�6   $��Center=�6/   5      �� 5   
   $ 
Horizontal=�6   .+�5      �� $��15 15 15 15q�6   $��Center=�6.   Nota fiscal:6X   �� 5      -   5        $��5 5 5 5q�5      $��5 5 5 5q�6'   .��6O   Selecionar arquivo6c   �� 5      -   5         ��Name$ lblNomeArquivo��5   J   $��15 15 15 15q�6   $��Center=�6.   ��6b   �� *
NotaFiscal+6�   5      � 5   
   $��15 15 15 15q�6   $��Center=�6$    � ColumnDefinitions 5      �� 5       $��* �6#   6/   �� 5!      $��* �6#   6/    � RowDefinitions 5$      �� 5%      6"   �� 5&      6"   .+�5)      � $��0��6    5*      �� 5+      $
��Auto �6$   64   �� 5,      $��* �6$   61   .+�5.      �� $
��Bold"�6   $��	15 5 15 5q�6.   $��0��6A   Itens:6V   &   System.Windows.Controls.DataGrid  50      -   5        $��DG_ItensCompra��51      $��	15 5 15 5q�50      $��1��52      $
}�True��54      	   AutoGenerateColumns$	 False��55      $	��150��56      ��53      �� 
 �� Path$
 Itens� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 58      4  .System.Windows.Controls.DataGridTemplateColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header 5:      �� 5;   "    �� Padding$ 5 5 5 5q�6,   $
��Bold"�6>   Descrição6[      CellTemplate 5=      �� 5>   "   .R�5?   &   �� $ 5 5 5 5q�60   ��6B   �� *	Descricao+6_   5@   #   5B        5D       5E      �� 5F   "   $ 5 5 5 5q�6,   $
��Bold"�6>   Valor unitário6`    5H      �� 5I   "   .R�5J   &   �� $ 5 5 5 5q�60   ��6B   �� *ValorUnitario+ �� ConverterCulture$ pt-BR�� �� StringFormat$ C��6�   5K   #   5M        5O       5P      �� 5Q   "   $ 5 5 5 5q�6,   $
��Bold"�6>   
Quantidade6\    5S      �� 5T   "   .R�5U   &   �� $ 5 5 5 5q�60   ��6B   �� *
Quantidade+6`   5V   #   5X      5Z      5[      � 5\      $��	15 5 15 5q�6   $��1��6&    5]      �� 5^      $
��Auto �6'   66   �� 5_      $	��200 �6'   65    5b      �� 5c      6&   �� 5d      6&   �� 5e      6&   �� 5f      6&   �� 5g      6&   .+�5j      �� $��0��6   $��	Novo item��6,   $
��Bold"�6=   $��0 0 0 5q�6O   6b   �� 5l      $ 5q�6   $��1��6(   $��Descrição:��65   $��Center=�6G   6d   �� 5m      -   5         ��Name$ txtDescricao��5m   �   $��5q�6   $��1��6%   $��1��6y   $��2 5 2 5q�6�    � DataContext 62   �� $
 	ItemAtual���6Y   �� $
 	Descricao�6�   �� 5o      $ 5q�6   $��2��6(   $��Valor unitário:��65   $��Center=�6L   6i   �� 5p      -   5        $ txtValorUnitario��5z      $��5q�5q      $
|�True��5s      $��2��5x      $��1��5y       �� TextAlignment$ Right=�5{      $��2 5 2 5q�5|       5r      �� $
 	ItemAtual���5w      �� $
 ValorUnitario� �� 	Converter# [  .��5|   '   5}      �� 5      $ 5q�6   $��3��6(   $��Quantidade:��65   $��Center=�6H   6e   �� 5�      -   5        $ txtQuantidade��5�   �   $��5q�6   $��3��6%   $��1��62   $ Right=�6�   $��2 5 2 5q�6�    �� 	MaxLength$ 8��6�    6d   �� $
 	ItemAtual���6�   �� $
 
Quantidade�6-  �� 5�      $��2��6   $��4��6-   $ 
Horizontal=�6:   $��5q�6S   $��Right=�6^   .+�5�      �� -   5        $��	10 5 10 5q�5�      .��6G   	Adicionar6R   5�      5�      5�      � 5�   
   $��15 15 15 15q�6    5�      �� 5�      $��2* �6#   60   �� 5�      6%   �� 5�      $��2* �6#   60   .+�5�      �� -   5        $��5 7 5 7q�5�      .��6>   
Cancelar6H   �� 5�      -	   5        $��5 7 5 7q�5�      $��2��6'   .��6N   	Confirmar6Y   5�      5�      5�      