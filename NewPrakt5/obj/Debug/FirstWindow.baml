   M S B A M L   `   `   `  ����D  @NewPrakt5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NewPrakt5	NewPrakt5  5   	       NewPrakt5.FirstWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NewPrakt5     5   	     � Title$  FirstWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� .@�5      �� $��Роли��6   .��5      �  � ColumnDefinitions 5      �� 5      $	��36* �6+   �� 5      $
��361* �6+   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ RoleDG��5      $��2��6Z   6n   �� 5      $��1��6    $
��Left=�60   $��	5,203,0,0q�6K   $
��Wrap=�6^   $��Новая роль��6r   $	��Top=�6�   $��40��6�   $	��105��6�   $��18(�6�   �� 5      -   5         ��Name$ RoleTbx��5      $��1��6/   $
��Left=�6?   $��123,203,0,0q�6Z    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��173��6�   $��40��6�   �� 5      -   5         ��Name$ 	AddBtRole��5      $��1��60   $��Добавить��6@   $
��Left=�6S   $��	0,269,0,0q�6n   $	��Top=�6�   $��40��6�   $	��115��6�   6�   �� 5      -   5        $ IzmenitBtRole��5      $��1��64   $��Изменить��6D   $
��Left=�6W   $��152,269,0,0q�6r   $	��Top=�6�   $��40��6�   $	��115��6�   6�   �� 5      -   5        $ YdalitBtRole��5      $��1��63   $��Удалить��6C   $��Center=�6U   $��	0,269,0,0q�6r   $	��Top=�6�   $��40��6�   $	��114��6�   6�   �� 5      $��1��6    $
��Left=�60   $��	5,137,0,0q�6K   $
��Wrap=�6^   $��ID��6r   $	��Top=�6|   $��43��6�   $	��105��6�   $��18(�6�   �� 5      -   5        $ 	IdTbxRole��5      $��1��61   $
��Left=�6A   $��123,137,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��173��6�   $��43��6�   �� 5      -   5        $��1��5      $2��,Вернуться к авторизации��6-   $
��Left=�6O   $��524,334,0,0q�6j   $	��Top=�6   $��43��6�   $	��165��6�   6�   5      5      �� 5      $��Сотрудники��6   .��5      �  5      �� 5       $
��189* �6+   �� 5!      $
��605* �6+   .+�5#        -   5        $ SotrydnikiDG��5#      $��2��6`   6t   �� 5$      $
��Left=�6    $��94,0,0,0q�6;   $
��Wrap=�6M   $��Фамилия��6a   $��Center=�6p   $��34��6�   $��80��6�   $��18(�6�   �� 5%      $
��Left=�6    $��
93,231,0,0q�6;   $
��Wrap=�6O   $��Имя��6c   $	��Top=�6n   $��33��6�   $��80��6�   $��18(�6�   �� 5&      $
��Left=�6    $��
94,275,0,0q�6;   $
��Wrap=�6O   $��Отчество��6c   $	��Top=�6s   $��33��6�   $��80��6�   $��18(�6�   �� 5'      -	   5        $ FamiliyaTbx��5'      $
��Left=�63   $��24,0,0,0q�6N   $
 Wrap=�6`   $��Center=�6t   $	��170��6�   $��34��6�   $��1��6�   �� 5(      -
   5        $ ImyaTbx��5(      $
��Left=�6/   $��
24,231,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��170��6�   $��33��6�   $��1��6�   �� 5)      -   5        $ OtchestvoTbx��5)      $
��Left=�64   $��
24,275,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��170��6�   $��33��6�   $��1��6�   �� 5*      $
��Left=�6    $��
94,320,0,0q�6;   $
��Wrap=�6O   $��Роль��6c   $	��Top=�6o   $��33��6�   $��80��6�   $��18(�6�   �� 5+      -   5         ��Name$ SotrydnikiCbx��5+      $
��Left=�66   $��
24,320,0,0q�6Q   $	��Top=�6e   $	��170��6}   $��33��6�   $��1��6�   �� 5,      -   5        $ AddSotrydnikiBt��5,      $��Добавить��66   $
��Left=�6I   $��292,168,0,0q�6d   $	��Top=�6y   $��34��6�   $	��121��6�   $��1��6�   �� 5-      -   5        $ IzmenitSotrydnikiBt��5-      $��Изменить��6:   $
��Left=�6M   $��292,228,0,0q�6h   $	��Top=�6}   $��34��6�   $	��121��6�   $��1��6�   6�   �� 5.      -   5        $ YdalitSotrydnikiBt��5.      $��Удалить��69   $
��Left=�6K   $��292,282,0,0q�6f   $	��Top=�6{   $��34��6�   $	��121��6�   $��1��6�   6�   �� 5/      $
��Left=�6    $��
94,135,0,0q�6;   $
��Wrap=�6O   $��ID��6c   $	��Top=�6m   $��32��6�   $��79��6�   $��18(�6�   �� 50      -   5        $ IdTbxSotrydniki��50      $��1��67   $
��Left=�6G   $��
24,135,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��170��6�   $��32��6�   �� 51      -   5        $��1��51      $2��,Вернуться к авторизации��6-   $
��Left=�6O   $��414,336,0,0q�6j   $	��Top=�6   $��34��6�   $	��161��6�   6�   52      53      �� 54      $0��*Данные для авторизации��6   .��55      � .+�56        -   5        $ DannieDG��56      6\   �� 57      $
��Left=�6    $��
54,135,0,0q�6;   $
��Wrap=�6O   $��ID��6c   $	��Top=�6m   $��28��6�   $��70��6�   $��14(�6�   �� 58      $
��Left=�6    $��
54,219,0,0q�6;   $
��Wrap=�6O   $��Login��6c   $	��Top=�6p   $��29��6�   $��70��6�   $��14(�6�    J� RenderTransformOrigin$ 0.616,2.427&�6�   �� 59      $
��Left=�6    $��
54,272,0,0q�6;   $
��Wrap=�6O   $��Password��6c   $	��Top=�6s   $��29��6�   $��70��6�   $��14(�6�   �� 5:      -   5        $ IdTbx��5:      $
��Left=�6-   $��140,135,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��154��6�   $��27��6�   �� 5;      -   5        $ LoginTbx��5;      $
��Left=�60   $��140,219,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��154��6�   $��29��6�   �� 5<      -   5        $ PasswordTbx��5<      $
��Left=�63   $��140,267,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��154��6�   $��34��6�   �� 5=      -   5        $ AddBt��5=      $��Добавить��6-   $
��Left=�6@   $��569,144,0,0q�6[   $	��Top=�6p   $��36��6�   $��96��6�   6�   �� 5>      -   5        $ 	IzmenitBt��5>      $��Изменить��60   $
��Left=�6C   $��569,216,0,0q�6^   $	��Top=�6s   $��36��6�   $��96��6�   6�   �� 5?      -   5        $ YdalitBt��5?      $��Удалить��6/   $
��Left=�6A   $��569,286,0,0q�6\   $	��Top=�6q   $��36��6�   $��96��6�   6�   �� 5@      -   5        $ PrivyazkaCbx��5@      $
��Left=�65   $��373,172,0,0q�6P   $	��Top=�6e   $	��120��6}   $��31��6�   �� 5A      $
��Left=�6    $��
18,170,0,0q�6;   $
��Wrap=�6O   $\��Vпользователь к которому привязать авторизацию��6c   $	��Top=�6�   $��14(�6�   $��35��6�   $	��334��6�   �� 5B      -   5        $2��,Вернуться к авторизации��5B      $
��Left=�6?   $��
47,323,0,0q�6Z   $	��Top=�6n   $��35��6�   $	��170��6�   6�   5C      5D      5E      5J      5K      