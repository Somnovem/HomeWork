   M S B A M L   `   `   `  ????H  DWpfAppAnimate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfAppAnimateWpfAppAnimate  5   	       WpfAppAnimate.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfAppAnimate     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         geometryPath E? IsClosed E? 
StartPoint ? Points??%?   &	        B? 5
   
   .??5      E? $
 True??6   $ 10,10&?6)   .??5      ? ' ?    ????  ??In
??? ?In
6"   5      5      5      .??5      ?? .+?5   
   F? 
???  ??#??[  6   
 ?? Top$ 10??6A    ?? Left$ 10??6Q   A? 5   
   $??60??6   $??60??6   
???  ??$ 10??66   $ 10??6F   ??5      
? 5       
? RadiusX$ 1Q?6&    
? RadiusY$ 1Q?62   	 
? GradientOrigin$	 0.3,0.3&?6>   .??5      ? 
 ? Color$
 White??6#    ? Offset$ 0Q?61   ? 5      $
 Black??6#   $ 1Q?61   5       ? Triggers 5      :? 5       :? RoutedEvent$ Window.Loaded??6   .[?5      ?? .??5      ?? .??5      T?  ?? TargetProperty$ (Canvas.Top)?67    g? Duration$ 0:0:5D?5   7    g? RepeatBehavior$ Forever??6H    T? PathGeometry# [  5   7    T? Source$ Y=?6d   T? 5       $ (Canvas.Left)?67   $ 0:0:5D?5!   7   $ Forever??6H   # [  5"   7   $ X=?6d   5#      5$      5%      5'      5(      5)      