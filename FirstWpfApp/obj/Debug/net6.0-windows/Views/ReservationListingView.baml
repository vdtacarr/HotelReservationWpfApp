   M S B A M L   `   `   `  ????F  BFirstWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FirstWpfApp.ViewsFirstWpfApp.Views  5      .    (FirstWpfApp.Views.ReservationListingView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FirstWpfApp.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $
??auto ?6#   .+?5      ?? $??0??6   $??24(?6(    
  Header#??[  66   $??View reservations??6W   ?? 5      $??1??6   $??MakeReservation??6%   ??6?   ?? *MakeReservationCommand+5      ?? 5   
   $??1??6   ??6    ?? *Reservations+ ?? View 5      ?? 5      .P?5      ?? $?? ??6%    ?? CellTemplate 5      ?? 5       .R?5!   "   ?? -   5        $??Check It??5!   +    d? 	IsChecked 6>   ??  ?? RelativeSource ?? *FindAncestor+ ?? AncestorType" ?? ?? Path$ 
IsSelected?5#   M   5$      5&      ?? 5'      $??Room ID??6%    5(      ?? 5)      .R?5*   "   ??  ?? Padding$ 0 0 20 0q?6,   ??6?   ?? *RoomID+5+      5.      ?? 50      $??Username??6%    51      ?? 52      .R?53   "   ?? $ 0 0 20 0q?6,   ??6?   ?? *
Username+54      56      ?? 58      $??
Start Date??6%    59      ?? 5:      .R?5;   "   ?? $ 0 0 20 0q?6,   ??6?   ?? *	StartDate+5<      5>      ?? 5@      $??End Date??6%    5A      ?? 5B      .R?5C   "   ?? $ 0 0 20 0q?6,   ??6?   ?? *	EndDate+5D      5F      5G      5I      ?? 5J   
   $??2??6   $??
0 20 20 20q?6C   $??Go To Detail??6W   
????  ?$	??100??6?   $
??Left=?6?   ??6   ?? *GoDetailCommand+6?   5K      5L      