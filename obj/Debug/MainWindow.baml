   M S B A M L   `   `   `  ����I  EJoesFruitDrink, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JoesFruitDrinkJoesFruitDrink  5   	       JoesFruitDrink.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:JoesFruitDrink     5   	     � Title$  Joe's Fruit Drinks��5	   	   $	��450��6$   $	��800��61   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $"��How Many Drinks for 1 fruit?��6-   $��10q�5      $��20(�6   $��Center=�5      $��Center=�64   6X   �� 5   
   $��1��6   $��0��6   $#��How Many Drinks for 2 fruits?��6-   $��10q�5      $��20(�6   $��Center=�5      $��Center=�64   6X   �� 5   
   $��2��6   $��0��6   $#��How Many Drinks for 3 fruits?��6-   $��10q�5      $��20(�6   $��Center=�5      $��Center=�64   6X   �� 5   
   -   5        $��oneFruit��5      $��0��5      $��1��6   $��10q�5   "   $��20(�6.   $��Center=�6<   $��Right=�6^   ��5   /   �� *
OneFruit+5   �   �� 5    
   -   5        $��twoFruit��5!      $��1��5       $��1��6   $��10q�5!   "   $��20(�6.   $��Center=�6<   $��Right=�6^   ��5    /   �� *
TwoFruit+5!   �   �� 5"   
   -   5        $��
threeFruit��5#      $��2��5"      $��1��6   $��10q�5#   $   $��20(�60   $��Center=�6>   $��Right=�6`   ��5"   /   �� *
ThreeFruit+5#   �   �� 5$   
   -   5        $��invoice��5$   2   $��3��6   $��2��6   $��Generate Invoice��6A   $��30q�5%      $��20(�6   $��Center=�5&      $��Center=�65   6Y   5'      5(      