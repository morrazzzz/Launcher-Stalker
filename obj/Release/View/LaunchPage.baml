   M S B A M L   `   `   `  ���� F  BCoPLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CoPLauncher.ViewCoPLauncher.View  !    CoPLauncher.View.LaunchPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:CoPLauncher.View       N� Title$  
LaunchPage�� � 	Resources    LaunchButtTemplate �� 
TargetType �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Path	 �� ElementName
 �� Value  ButtonUpdateOneTwo �� CornerRadius  LabelTemplate ��Name  GroupBoxTemplate  ProgressBarStyle��%�  &	        &	 �    &	      &	 �    &	 �    �� " ��.R�� $	��Btn��.+��� 
�������$��0q�._��� .+��� $��SelectedButt��
�������$��1q����� " ��.���  �@J�Opacity$ 0Q� ��  �� $ IsMouseOver�$		 Btn��
 true.a���  �@J�Opacity$	 0.3Q��� #��z��
������ 
���   �$��48(�$��Center=�$��Center=�$:��4/CoPLauncher;component/View/res/Fonts/#MatterhornCTT)�$��280,0,263,0q�$	��167��$
��Bold"��� " ��.R��� 
���"�"�$��1q�$ 12������ " ��.���  �@J�Opacity$ 1Q� �� �� " ��.R��� $ 	LabelTemp��
�������$��1q�$ 20��._��� #��z��
������ $��50(�$9��3/CoPLauncher;component/View/res/Fonts/#Graffiti1CTT)�
���  ���� " ��.R��� �� " �.R��� 
�������
��� � �$��1q�$ 12������ " ��.���  �@J�Opacity$ 1Q�._�� ���� " �.���  �@J�Opacity$	 0.8Q� .��� .+��� $��Center=�$��0��$��Center=�$
��Fill=�$��res/Background/back_5.jpg���� -   $��LaunchGameBtn��$��Stretch=�$��Bottom=�$��60��
���   � J� Opacity$	 0.6Q�$!��Запустить игру��#��[  �� -   $��DownNewVersion��$��Обновить��$	��150��$��50��$��550,405,10,65q�{�.  #��[ �� -   $��CheckVersion��$-��'Проверить обновления��$	��150��$��50��$��10,405,550,65q�#��[ � -   $��SearchProgressBar�� � Minimum$ 0Q� � Maximum$	 100Q�$��175,405,175,65q�#��[ �� -    ��Name$ CheckBox_close_launcher��$E��?Закрыть лаунчер после входа в игру��$
��Left=�$��
478,10,0,0q� � ToolTip$e _Закрывает лаунчер после входа в игру(рекомендуется)��$	��Top=� J� RenderTransformOrigin$ 0.533,0.662&� d� 	IsChecked$ FalseY��� -    ��Name$ ComboBox_mode_Stalker��$
��Left=�$��
441,37,0,0q�$� �Выбор части сталкера, если вы выберете не ту часть сталкера, то игра может не запуститься. Для сторонних модов, имеющие название exe файла:`xrEngine`, лучше выбирать ЗП��$	��Top=�$	��120��.@��� $
��ТЧ���� $
��ЧН���� $
��ЗП���� $,��&Выбор части сталкера��$
��Left=�$��
568,35,0,0q�$	��Top=��� -    ��Name$ TextBox_Keys��$
��Left=�$��
441,73,0,0q�$� �Ключи для запуска XRay, не опытному пользователю лучше сюда ничего не писать.�� �� TextWrapping$
 Wrap=�$	��Top=�$	��120���� $&�� Ключи для запуска��$
��Left=�$��
577,69,0,0q�$	��Top=�
������ ���	#FFF4F52F