   M S B A M L   `   `   `  ����  WPF-C-Sharp-Lesson-2%    WPF_C_Sharp_Lesson_2.CartWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  Shopping Cart��5      $	��450��6   $	��529��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��21* �6   �� 5      $	��89* �6   �� 5	      $	��15* �6   .+�5   
   �� $��Select Item:��6   $��	20,20,0,0q�6(   $
��Left=�6;   $	��Top=�6V   �� 5   
   -   5        $��ItemComboBox��5      $	��200��6'   $��	16,20,0,0q�63   $
��Left=�6F   $	��Top=�6a    �� DisplayMemberPath$
 Name��5   0   $��1��6|   ��6   �� *
ItemList+ �� SelectedItem 6I   �� *SelectedItem+ �� Mode$ TwoWay=�6|   �� 5   
   -   5        $��Add to Cart��5      $	��100��6'   $��
236,20,0,0q�63   $
��Left=�6G   $	��Top=�6b   $��1��6�   �� 5   
   -   5        $��CartListBox��5      $	��300��6%   $	��200��61   $��	16,60,0,0q�6>   $
��Left=�6Q   $	��Top=�6l   $ DisplayText��5   0   $��1��6P   ��6   �� *	CartItems+6P   �� 5   
   -   5        $��Remove Selected��5      $	��100��6+   $��
330,60,0,0q�67   $
��Left=�6K   $	��Top=�6f   $��44��6�   $��2��6�   $��1��6�   �� 5   
   $��Total Price:��6   $��
16,280,0,0q�6(   $
��Left=�6<   $	��Top=�6W   $��14(�6o   $��1��6}   �� 5   
   -   5        $��TotalPriceTextBlock��5      $��116,280,0,0q�6/   $
��Left=�6D   $	��Top=�6_   $��14(�6w   $��1��5   <   ��6   �� *
TotalPrice+ �� StringFormat$ C��6<   5      5      