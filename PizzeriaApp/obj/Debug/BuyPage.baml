   M S B A M L   `   `   `  ����F  BPizzeriaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PizzeriaAppPizzeriaApp  5          PizzeriaApp.BuyPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:PizzeriaApp     5        N� Title$  BuyPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $
��Left=�6   $	��Top=�6/   $��5 10 5 5q�6G   	Имя:6_   �� 5   
   -   5        $��tbName��5      $��Right=�6    $	��Top=�6<   $��0 5 0 0q�6T   �� 5   
   $��1��6   $
��Left=�6!   $	��Top=�6<   $��5q�6T   Номер тел-на:6n   �� 5   
   -   5        $��tbNumber��5      $��1��6"   $��Right=�6/   $	��Top=�6K   �� 5   
   $��2��6   $
��Left=�6!   $��5q�6<   $	��Top=�6G   " Способ получения:6r   	� 5   
   -   5        $��rbtnWithoutDel��5      $��2��6,    	� 	GroupName$ 	rbtnGroup��69   $
��Left=�6O   $��Center=�6j   $	��138��6�   $��5 30 0 0q�6�   .��6�   Самовывоз6�   	� 5   
   -   5        $��rbtnWithDel��5      $��2��6)   $ 	rbtnGroup��66   $��Center=�6L   $��Center=�6i   $��	30 30 0 0q�6�   .��6�   Доставка6�   �� 5   
   $��1��6   $
��Left=�6$   $	��Top=�6?   $��	10 10 5 5q�6W   Самовывоз:6v   �� 5   
   -   5        $��
cmbStation��5      $��1��6%   $��Right=�65   $	��Top=�6Q   $��5q�6i   $	��175��6t   $��30��6�   {�.  6�   �� 5   
   $��1��6   $��1��6!   $
��Left=�61   $	��Top=�6L   $��10 5 5 5q�6d   Доставка:6�   �� 5    
   -   5        $��
tbDelivery��5       $��1��6$   $��1��61   $��Right=�6A   $	��Top=�6]   $��0 0 5 0q�6u   {�.  6�   �� 5!   
   -   5        $��tbSum��5!      $��2��6!   $��1��6.   $
��Left=�6>   $	��Top=�6Y   $��10 5 5 5q�6q   Стоимость:6�   �� 5"   
   -   5        $��	btnGoBack��5"      $��3��6"   .��6G   
Выход6N   �� 5#   
   -	   5        $��btnOrder��5#      $��3��6!   $��1��6.   .��6U   Заказать6_   (  "System.Windows.Controls.DatePicker  5$   
   -
   5        $��
datePicker��5$      $��2��6'   $��1��64   $��Bottom=�6D      IsDropDownOpen .  $��Verdana)�5%      $	��175��6*   $
��Left=�66   {�.  $��30��6c   6r   5&      5'      