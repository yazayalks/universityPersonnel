   M S B A M L   `   `   `  ????N  JuniversityPersonnel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:universityPersonneluniversityPersonnel  5   	   (    "universityPersonnel.EditUserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:universityPersonnel     5   	     ? Title$  EditUserWindow??5   	   $	??450??6    $	??800??6-    ? WindowStartupLocation$ CenterScreen=?5	   
   .??5
      ? .+?5   
   ?? .@?5   
   ?? -   5         ??Name$ accessRightItem??5      $8??2Права доступа пользователя??6+   .??5      ? -   5         ?Name$ accessRightItemGrid??5       ? ColumnDefinitions 5      ?? 5      $
??397* ?6'   ?? 5      $??3* ?6'    ? RowDefinitions 5      ?? 5      $??* ?6$   ?? 5      $
??Auto ?6$   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ AccessRightGrid??5   J      
IsReadOnly$ False??6      AutoGenerateColumns$ False??6.   $	??220??6?   $??Center=?6?   $??	10,0,10,0q?6?   ??6c   ?? *AccessRights+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$!
 Название формы??6T      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   ?? *NameForm.Name+6l   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 Чтение??6N   $	 100 6^    65   ?? *Read+6^     5      $
 Запись??6O   $	 100 6_    65   ?? *Write+6_     5      $"
 Редактирование??6N   $	 100 6f    65   ?? *Edit+6f     5      $
 Удаление??6P   $	 100 6b    65   ?? *Delete+6b   50      ?? 52      $
??Left=?6    ?? Orientation$ 
Horizontal=?68   $
??Auto??6R   $??1??6_   .+?53      ?? -   5         ??Name$ saveAccessRightButton??53   !   $??Сохранить??6@   $	??106??6m   54      55      56      57      58      59      