   M S B A M L   `   `   `  ????F  BFirstWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FirstWpfApp.ViewsFirstWpfApp.Views  5      +    %FirstWpfApp.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FirstWpfApp.Views     5      .??5	      ?   ? IsSharedSizeScope$
  True??6    ? RowDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??6   $??24(?6!   $??Make reservation??5      ? 5   
   $??1??6   $??0 50 0 0q?6    5      ?? 5      ?? 5      .+?5      ?? $??0??6   $
??Name??6%   ?? 5      $??1??6   $??0 5 0 0q?6#   ??64   ?? *
Username+ ?? UpdateSourceTrigger$ PropertyChanged=?5      ? 5   
   $??2??6    5       ?? 5!      ?? 5"       ? ColumnDefinitions 5$      ?? 5%       z? SharedSizeGroup$ FirstColumn??6#   ?? 5&      $ SecondColumn??6#   .+?5)      ?? $??0??6   $??0??6%   $??	Floor No.??65   $??0 5 0 0q?6F   ?? 5*      $??1??6   $??0??6#   $??0 5 0 0q?64   ??6F   ?? *	FloorNo+$ PropertyChanged=??? 5,      $??0??6   $??1??6%   $??Room No.??65   $??0 5 0 0q?6E   ?? 5-      $??1??6   $??1??6#   $??0 5 0 0q?64   ??6E   ?? *RoomNo+$ PropertyChanged=?5.      ? 50   
   $??3??6    51      ?? 52      ?? 53       55      ?? 56      $ FirstColumn??6#   ?? 57      $ SecondColumn??6#   .+?5:      ?? $??0??6   $??0??6%   $??
Start Date??65   $??0 5 0 0q?6G   (  "System.Windows.Controls.DatePicker  5;      $??1??6   $??0??6&   $??0 5 0 0q?6~      SelectedDate 66   ?? *	StartDate+$ PropertyChanged=?6~   ?? 5=      $??0??6   $??1??6%   $??End Date??65   $??0 5 0 0q?6E     5>      $??1??6   $??1??6&   $??0 5 0 0q?6}    67   ?? *	EndDate+$ PropertyChanged=?6}   5?      ?? 5A   
   $??4??6    ?? Orientation$ 
Horizontal=?6"   .+?5B      ?? $??Submit??6   $??0 5 0 0q?6&   ??67   ?? *SubmitCommand+?? 5C      $??Cancel??6   $??0 5 0 0q?6&   ??68   ?? *CancelCommand+5D      5E      5F      