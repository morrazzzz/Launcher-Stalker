   M S B A M L   `   `   `  ���� F  BCoPLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CoPLauncherCoPLauncher  G(clr-namespace:CoPLauncher.View.ViewModelCoPLauncher.View.ViewModel  !    CoPLauncher.View.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:CoPLauncher     7vm(clr-namespace:CoPLauncher.View.ViewModel       � Title$#  S.T.A.L.K.E.R. Scurlet Sunset��$	��600��$
��1000��$	��600��$
��1000��$	��600��$
��1000�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������� � ShowInTaskbar .  � DataContext .  (CoPLauncher.View.ViewModel.MainViewModel   � 	Resources    ExitButtonTemp �� 
TargetType �Name	 �� 
TargetType
 �� Property �� Value �� Triggers �� Binding �� Path �� ElementName �� Value �� RelativeSource �� Mode �� AncestorType  SlideMenuButtons �� Orientation  Img  TopMenuLabel��%  &	        &	 �    &	 \    �� " ��.R�� $ BtnClose��.+��� #��z��
������ $��15(�$��Center=�$��Center=��� $��
OverBorder��
���  ������ "	 ��.��� 
 �@J�Opacity$	 0.5Q��� 
 �@��CornerRadius$ 3�� ��  �� $ IsMouseOver�$ BtnClose�� true.a��� 
 �@J�Opacity$	 0.1Q��� $��SelectedBorder��
���   ����� "	 ��.��� 
 �@J�Opacity$ 0Q� ��  ��  �� $ FindAncestor=�" ��$ 	IsFocused� true.a��� 
 �@J�Opacity$	 0.5Q��� " ��.R�� $	��Btn��$��80��$��0,0,0,5q�.+��� 
�������._��� $ 
Horizontal=�.+��� #���  $��Center=�$
��Left=�$��60��$��60��$
��Fill=�$��10,0,0,0q��� #��z��
������ $��17(�$��Center=�$��Center=����� "	 ��.��� 
 � ��
 �   ��� $��
OverBorder��
����������� "	 ��.��� 
 �@J�Opacity$ 0Q� ��  �� $ IsMouseOver�$	 Btn�� true.a��� 
 �@J�Opacity$	 0.1Q��� $��SelectedBorder��
����������� "	 ��.��� 
 �@J�Opacity$ 0Q� ��  ��  �� $ FindAncestor=�" ��$ 	IsFocused� true.a��� 
 �@J�Opacity$	 0.1Q��� $��SelectedBorder2��
������ ���� "	 ��.��� 
 � y�$ Hidden=��� 
 � ��$ 5,0,0,0q��� 
 � ��
 �  �� ��  ��  �� $ FindAncestor=�" ��$ 	IsFocused� true.a��� 
 � y�$ Visible=��� " ��.R�� $��Label��.+��� #��z��
������ $��30(�$��Center=�$��TimesNewRoman)����� "	 ��.��� 
 � ��
 �  ��.���  � ColumnDefinitions �� $	��290 ���  � RowDefinitions �� $��80 ��� .+� � $��10��$��10��  � NavigationUIVisibility$ Hidden=����� *	CurPage+� -   $��TopMenu��$��0��$��2��.+��� $��0,0,0,1q�
�������
������ ._��� $ 
Horizontal=�.+��� $ ��Launcher for S.T.A.L.K.E.R��#��[ $��10q��� -    ��Name$ CloseWindow��$��X��$��46��$��30�� � ToolTip$# Закрыть лаунчер��$��	595,0,0,0q�$	��Top=�#��[  � -   $��	SlideMenu��$��0��$��1��$��Stretch=�.+��� $��1,0,1,1q�
��������� $��0q�
���   � J� Opacity$	 0.6Q��� $ Vertical=�.+��� #��[ $��Запуск игры������ *OpenHomePage+ ��%&   &	       ��res/icons/home.png���� #��[ $'��!Настройки Графики������ *OpenGraphicsPage+ ��%*   &	       ��res/icons/graphics.png���� #��[ $!��Настройки Игры������ *OpenSettingsPage+ ��%*   &	       ��res/icons/settings.png���� #��[ $.��(Информация о лаунчере������ *OpenDescrPage+ ��%'   &	       ��res/icons/descr.png��