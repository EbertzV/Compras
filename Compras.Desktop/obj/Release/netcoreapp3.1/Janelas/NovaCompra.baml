   M S B A M L   `   `   `  ���� J  FCompras.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Compras.Desktop.JanelasCompras.Desktop.Janelas  ,    &Compras.Desktop.Janelas.TelaNovaCompra   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:Compras.Desktop.Janelas       � Title$  
NovaCompra��$��Verdana)�$��Expanded&� � WindowStyle$ ThreeDBorderWindow=�
������� � SizeToContent$ WidthAndHeight=� � Icon$ ../Images/cart.png��.���� .+��� $��Center=�$��	5 15 5 15q�$��Nova compra��$
��Bold"�$	��Top=���  �� Orientation$ 
Horizontal=�.+��� $��15 15 15 15q�$��Center=�Data da compra:(  "System.Windows.Controls.DatePicker  $��15 15 15 15q�$��Center=�� $��15 15 15 15q�$��Center=�
�����_� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� �� .+�� $��0�� �� $
��Auto ��� $��* �.+��� $
��Bold"�$��	15 5 15 5q�$��0��Itens:&   System.Windows.Controls.DataGrid  -   $��DG_ItensCompra��$��	15 5 15 5q�$��1��$
}�True��$	��150������  �� Path$ Itens� �� UpdateSourceTrigger$ PropertyChanged=�� $��	15 5 15 5q�$��1�� �� $
��Auto ��� $	��200 � �� �� �� �� �� .+��� $��0��$��	Novo item��$
��Bold"�$��0 0 0 5q��� 	 �� Padding$	 5q�$��1��$��Descrição:��$��Center=��� -   
 ��Name$
 txtDescricao��$��5q�$��1��$��1��$��2 5 2 5q��� $	 5q�$��2��$��Valor unitário:��$��Center=��� -   $
 txtValorUnitario��$��5q�$��2��$��1�� �� TextAlignment$ Right=�$��2 5 2 5q��� $	 5q�$��3��$��Quantidade:��$��Center=��� -   $
 txtQuantidade��$��5q�$��3��$��1��$ Right=�$��2 5 2 5q� �� 	MaxLength$ 4���� $��2��$��4��$ 
Horizontal=�$��5q�$��Right=�.+��� -   $��	10 5 10 5q�.��	Adicionar� $��15 15 15 15q� �� $��2* ��� �� $��2* �.+��� -   $��5 7 5 7q�.��
Cancelar�� -   $��5 7 5 7q�$��2��.��	Confirmar