   M S B A M L   `   `   `  ����B  >pr5_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:pr5_wpfpr5_wpf  5   	       pr5_wpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:pr5_wpf     5   	     � Title$  BankAccount��5   	   $	��242��6   $	��317��6*   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFFFFFFF��6    � Offset$ 2Q�6-   � 5      $ 	#FFCBDEF6��6   $	 0.1Q�6-   5      .��5      � $��0,0,0,1q�6   .+�5   
   � $
��Left=�6   $	��166��6*   $��	0,-11,0,0q�67   $	��Top=�6J   $	��279��6b    � RowDefinitions 5      �� 5      $��11 �6    �� 5      $��40.373 �6    �� 5      $��10.627 �6    �� 5      $	��40* �6    �� 5      $	��11* �6    �� 5      $	��40* �6    �� 5      $��6* �6    .+�5      �� -   5        $��
Btn_credit��5         CustomButtonStyle#��[  6'   $��Пополнить��6R   $
��Left=�6f   $��10,0,0,0q�6�   $��Center=�6�   $��80��6�   $��26��6�   $��5��6�   6�   �� 5      -   5        $��	Btn_debit��5      #��[  6&   $��
Снять��6Q   $
��Left=�6a   $��	104,0,0,0q�6|   $��Center=�6�   $��80��6�   $��26��6�   $��5��6�   6�   �� 5      -   5        $��
TxtBox_sum��5        CustomTextBoxStyle#��[ 6(   $
��Left=�6T   $��60,0,0,0q�6o   $��3��6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $��Center=�6�   $	��197��6�   $��30��6�   �� 5       -   5        $��TxtBl_balance��5       $
��Left=�6.   $��	66,13,0,0q�6I   $��1��6\   $
��Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��191��6�   $��17��6�   �� 5"      $��Сумма:��6     CustomLabelStyle#��[ 6%   $
��Left=�6O   $��3��6j   $��Center=�6w   $��30��6�   $��50��6�   $��10,0,0,0q�6�   �� 5#      $��Баланс:��6   #��[ 6&   $
��Left=�6P   $��10,0,0,0q�6k   $��1��6}   $��Center=�6�   $��56��6�   5(      5*      5+      