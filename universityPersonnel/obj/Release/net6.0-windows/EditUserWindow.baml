   M S B A M L   `   `   `  ???? N  JuniversityPersonnel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:universityPersonneluniversityPersonnel  (    "universityPersonnel.EditUserWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:universityPersonnel       ? Title$  EditUserWindow??$	??450??$	??800??.??? .+??? .@??? -    ??Name$ accessRightItem??$8??2Права доступа пользователя??.??? -    ?Name$ accessRightItemGrid?? ? ColumnDefinitions ?? $
??397* ??? $??3* ? ? RowDefinitions ?? $??* ??? $
??Auto ?.+?&   System.Windows.Controls.DataGrid  -     Name$ AccessRightGrid??   
IsReadOnly$ False??   AutoGenerateColumns$ False??$	??220??$??Center=?$??	10,0,10,0q????? *AccessRights+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$!	 Название формы??
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding ?? *NameForm.Name+4  .System.Windows.Controls.DataGridCheckBoxColumn  $	 Чтение??$	
 100  ?? *Read+  $	 Запись??$	
 100  ?? *Write+  $"	 Редактирование??$	
 100  ?? *Edit+  $	 Удаление??$	
 100  ?? *Delete+?? $
??Left=? ?? Orientation$ 
Horizontal=?$
??Auto??$??1??.+??? -    ??Name$ saveAccessRightButton??$??Сохранить??$	??106??