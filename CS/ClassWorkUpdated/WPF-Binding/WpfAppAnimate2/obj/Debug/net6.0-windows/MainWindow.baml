   M S B A M L   `   `   `  ����I  EWpfAppAnimate2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfAppAnimate2WpfAppAnimate2  5   	       WpfAppAnimate2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfAppAnimate2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� 
���   �.+�5
   
   A� $��20��6   $��20��6    �� Left$	 120��6)    �� Bottom$ 0��6;   ��5      
� 5       
� RadiusX$ 1Q�6&    
� RadiusY$ 1Q�62    
� GradientOrigin$ 0.3,0.3&�6>   .��5      �  � Color$ White��6#    � Offset$ 0Q�61   � 5      $ Black��6#   $ 1Q�61   5       � Triggers 5      :� 5      	 :� RoutedEvent$	 Window.Loaded��6   .[�5      �� .��5      �� .��5      U� 
 �� TargetProperty$
 (Canvas.Bottom)�6<    g� Duration$ 0:0:3D�5   <    g� AutoReverse$
 True��6M    g� RepeatBehavior$ Forever��6`    g� DecelerationRatio$ 1Q�6y   .\�5   "   ��  O� KeyTime$ 0%��67    O� Value$ 0Q�6D   �� 5   "   $	 33%��67   $ 60Q�6E   �� 5   "   $	 66%��67   $	 120Q�6E   �� 5   "   $	 99%��67   $	 180Q�6E   5      �� 5      $ 
 Fill.GradienStops[1].Color�6;   $ 0:0:3D�5   ;   $ Forever��6L   $
 True��6e   g�5    &   ��  �� KeyTime$ 0:0:1��6:    �� Value$ Green��6J   �� 5!   &   $ 0:0:2��6:   $	 Red��6J   5#      5$      5%      5&      5(      5)      5*      