   M S B A M L   `   `   `  ���� J  FCompras.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Compras.Desktop.JanelasCompras.Desktop.Janelas  *    $Compras.Desktop.Janelas.ListaCompras   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:Compras.Desktop.Janelas     -     � Title$  Compras efetuadas��$��Expanded&�$��Verdana)� � Icon$ ../Images/cart.png�� � WindowStyle$ ThreeDBorderWindow=�
�������$	��600��$	��800��.���  � RowDefinitions �� $��* ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� �� .+�� $��2��$��0�� �� $
��Auto ��� �� �� $
��Auto �.+��� $��Center=� �� Padding$ 15 15 15 15q�$��5 5 5 5q�$��16(�$
��Bold"�$��Compras efetuadas��R� -    R�Name$ ComprasEfetuadasView��$��1��$��2��
�������$��15 15 15 15q�$��15 15 15 15q� � 	Resources  �� 
TargetType	 �� Property
 �� Value �� Orientation �� RelativeSource �� Mode �� AncestorType �� Path4   .Compras.Desktop.Janelas.HeaderToImageConverter   Instance �� 	Converter��%�   'Q�       �� " Q�.��� 	 � ��
 �� .R��� $��5 5 5 5q�$ 
Horizontal=�.+��� $��20������  �� $ FindAncestor=�" Q�$	 Tag�# Z �� $ 5 5 5 5q�$��Center=�����  �� $ FindAncestor=�" Q�$ Header�