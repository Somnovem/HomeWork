   M S B A M L   `   `   `  ????G  CWpfTemplates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTemplatesWpfTemplates  5   	       WpfTemplates.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTemplates     5   	     ? Title$  	Templates??5   	   $	??450??6   $	??600??6(    ? WindowStartupLocation$ CenterScreen=?64   $	??300??6Y   $	??400??6i    ? 	Resources 5	       ?? MergedDictionaries ?? Source?? 5
   
    5      ?? 5      $ TemplateDictionary.xaml??6%   %    5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??90* ?6   ?? 5      $	??10* ?6   .+?5   
   ?? -   5         ??Name$ lstToDo??5      $??0??6#   $??2??5      $??5q?6#   $??Stretch=?6.   ??5      ?? 5       ?? 
TargetType" ??6    ?? Triggers 5      P? 5      	 P? Property	 ?@J?IsMouseOver
 P? Value$

 True??69   . ?5      ??  ?? Property ? ?? ?? Value
 ? ? ?6;   5      5      ??5       ?? 5!      .R?5"      ?? 
???????$??3q?65    ?? CornerRadius$ 5??6I    ?? Padding$ 5q?6Z   ._?5#      ?  5$      ?? 5%   "   ?? 5&   "   ?? 5'   "   .+?5)      ?? $??0??6(   $
??Bold"?65   $??14(?6G   ??5*   "   `? 5+   &    ?? StringFormat$ {0}) Task {1}}??63   .1?5,   *   ??  ?? Path$ Id?62   ?? 5-   *   $ Title?62   5.   '   50      ?? 51      $??1??6(   $??Italic$?6W   $??12(?6j   ??65   ?? $ Description?6j   ?? 52      $??2??6(   $??14(?6?   ??65   ?? $ Deadline?$&  Deadline at {0:dd-MM-yyyy HH:mm}??6?   53      54      55      57      A? 58   
   $??1??6   $
??Auto??6#    A? Columns$ 2??60   .+?59      ?? $
??Save??6      btnTemplate#??[  6$   $
??Auto??6L   $
??30,3q?6Y   ?? 5:      $
??Load??6   #??[  6$   $
??Auto??6L   $
??30,3q?6Y   5;      5<      5=      