   M S B A M L   `   `   `  ����F  BNovelReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NovelReaderNovelReader  5   	   5clr-namespace:NovelReader.ModelNovelReader.Model  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   !    NovelReader.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:NovelReader     5   	   1modelclr-namespace:NovelReader.Model     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          �Name$  theMainWindow��5   	    � Title$ NovelReader��5
   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	   
������  � 
ResizeMode$ CanResizeWithGrip=�5   	    � 	Resources 5      )  #NovelReader.Model.FontSizeConverter   fontSizeConverter0  *NovelReader.Model.DoublePrecisionConverter  doublePrecisionConverter  backgroundColor �� Color �� Opacity  RightContextMenu	 �� Orientation
 � Maximum � Minimum � Value �� Source%  System.Windows.Markup.Reference �� Mode �� 	Converter � SmallChange � LargeChange��%�  &	        &	      &	 &     &	 Z     7   7  7    5   
   6"     5   
   6)   �� 5   
   $ Orange��62   $	 0.5Q�6A   6Q   �� 5   
   .@�5      �� $	 
Horizontal=�6   .+�5       �� -   5        $��打开��5       $
��auto��6=   6L   5!      �� 5#      6   �� 5&      $	 
Horizontal=�6   .+�5'      �� $��字体大小：��6   �� 5(      $
 72Q�5*      $ 1Q�6&   $	��100��5+       5)      �� *
FontSize+   *DisplayPanel+5,      �� 5-      ��5.      �� *Value+   *slder+$ OneWay=�8   5/      �� 52      6   �� 55      $	 
Horizontal=�6   .+�56      �� $��全局不透明度：��6   �� 57      $
 1Q�58   !   $
 0.01Q�6-   $	 0.1Q�59   !   $	 0.2Q�63   $	��100��5:   !    57      �� *	Opacity+   *theMainWindow+$ TwoWay=�5;      �� 5<      ��6   �� *	Opacity+   *theMainWindow+8  5=      �� 5@      6   �� 5C      $	 
Horizontal=�6   .+�5D      �� $��背景不透明度：��6   �� 5E      $
 1Q�5F   !   $
 0.01Q�6-   $	 0.1Q�5G   !   $	 0.2Q�63   $	��100��5H   !    5E      �� *Background.Opacity+   *DisplayPanel+$ TwoWay=�5I      �� 5J      ��6   �� *Background.Opacity+   *DisplayPanel+8  5K      �� 5N      6   �� 5Q      $	 
Horizontal=�6   .+�5R      �� -   5        $��自动隐蔽��5R      6f   5S      5U      5W      .��5Y      ]� .+�5\   
   o� $	��Top=�6   $y�	Collapsed=�6$   .@�5]      m� $��文件��6   .@�5^      m� -   5        $��打开��5^      6@   5_      m� 5`      $��配置��6   6%   5a      �� 5d   
   $��Bottom=�6   $y�	Collapsed=�6,   .@�5f      �� .��5g      �� $	 
Horizontal=�6   .+�5h      �� $��字体大小：��6    �� 5i      -   5        $��slder��5i      $
 72Q�5k      $ 1Q�6&   $	��100��5l       5j      �� *
FontSize+ �� ElementName$ DisplayPanel��5m      �� 5n      -   5         ��Name$ fontSizeText��5n       ��5o      �� *Value+$ slder��$ OneWay=�# [  5p      5r      �� 5t      .��5v      �� $	 
Horizontal=�6   .+�5w      �� $��不透明度：��6    �� 5x      $
 1Q�5y   !   $ 0Q�6-   $	 0.1Q�5z   !   $	 0.2Q�63   $	��100��5{   !    5x      �� *	Opacity+$ theMainWindow��$ TwoWay=�5|      �� 5}      ��6    �� *	Opacity+$ theMainWindow��# [ 5~      5      �� 5�      .��5�      �� $	 
Horizontal=�6   .+�5�      �� $��背景不透明度：��6    �� 5�      $
 1Q�5�   !   $
 0.01Q�6-   $	 0.1Q�5�   !   $	 0.2Q�63   $	��100��5�   !    5�      �� *Background.Opacity+$ DisplayPanel��$ TwoWay=�5�      �� 5�      ��6    �� *Background.Opacity+$ DisplayPanel��# [ 5�      5�      �� 5�      $��Right=�6   .��5�      �� -   5        $ statusControl��5�      5�      5�      �� 5�   
   -   5         ��Name$ DisplayPanel��5�       � IsSharedSizeScope . ��.  %� IsVirtualizing .  %� VirtualizationMode$ 	Recycling=�5�      $��Disabled=�5�       �� SelectionMode$ Single=�5�        ListBoxControlTemplate1#��[ 6$    � ContextMenu# [ 5�      #��[ 5�      $��0q�5�      ��5�   #   �� *	TxtList+��5�      �� 5�      .R�5�      � $
��auto��6   $
��auto��6(   $��0q�66    � ColumnDefinitions 5�      �� 5�      $
��auto �6/    z� SharedSizeGroup$ A��6<   6R   �� 5�      $��10 �6/   6<   �� 5�      61   .+�5�      �� 
��� ���$��Center=�5�   $   $��Center=�6?   $
��Wrap=�5�   $   $��0��68   ��5�   $   �� *
LineNumber+5�   8   �� 5�      $
��Wrap=�6F   $��2��6Z   $��10q�5�   $   ��5�   $   �� *ParagraphContent+5�   $   5�      5�      5�      5�      5�      