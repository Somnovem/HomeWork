   M S B A M L   `   `   `  ????I  EWpfAppGraphics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfAppGraphicsWpfAppGraphics  5   	       WpfAppGraphics.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfAppGraphics     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? -   5         ??Name$ 
backBorder??5   5   $??0??6   
????ح?._?5      r? -   5         r?Name$ mp??5   .    r? Source$ test.mp3??6    r? LoadedBehavior$ Manual=?6:   6?   5      ?? 5   
   -   5         ??Name$	 sld??5      $??1??6    ? Minimum$ 0Q?6+    ? Maximum$	 100Q?67   	 ?? TickPlacement$	 BottomRight=?6E   6a   A? 5   
   $??2??6   
 A? Columns$
 3??6#   .+?5      ?? -   5         ??Name$ btnOpen??5      $
??Open??6&   $??30??65   $	??5,3q?6W   
 ? Tag$ 1??6d   ?? 5      -   5        $ btnPlay??5      $
??Play??6&   $??30??65   $	??5,3q?6W   $ 2??6d   ?? 5      -   5        $ btnStop??5      $??Pause??6&   $??30??66   $	??5,3q?6X   $ 3??6e   5      5      5      