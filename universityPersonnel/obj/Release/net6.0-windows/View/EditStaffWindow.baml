   M S B A M L   `   `   `  ???? N  JuniversityPersonnel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:universityPersonneluniversityPersonnel  )    #universityPersonnel.EditStaffWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:universityPersonnel       ? Title$  EditStaffWindow??$	??800??$
??1227??.????  ?? Orientation$ 
Horizontal=?.+??? $	??287??.+??? $ 
Horizontal=?.+??? $??Фамилия??$
??Left=?$??Center=?$	??160????  ?? TextWrapping$
 Wrap=?$??Center=?$	??120??????  ?? Path$ Staff.Surname??? $ 
Horizontal=?.+??? $??Имя??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ 
Staff.Name??? $ 
Horizontal=?.+??? $??Отчество??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ Staff.Middlename??? $ 
Horizontal=?.+??? $??Пол??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120?????? $ Genders? ?? SelectedItem ?? $ Staff.Gender??? $ 
Horizontal=?.+??? $!??Место рождения??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ Staff.PlaceBirth??? $ 
Horizontal=?.+??? $!??Домашний адрес??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ Staff.HomeAddress??? $ 
Horizontal=?.+??? $??Телефон??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ Staff.Phone??? $ 
Horizontal=?.+??? $??Образование??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120?????? $ 
Educations? ?? $ Staff.Education??? $ 
Horizontal=?.+??? $,??&Серия номер паспорта??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ Staff.PassportId??? $ 
Horizontal=?.+??? $&?? Кем выдан паспорт??$
??Left=?$??Center=?$	??160???? $
??Left=?$
 Wrap=?$??Center=?$	??120?????? $ Staff.PassportIssuedBy??? $ 
Horizontal=?.+??? $!??Дата получения??$
??Left=?$??Center=?$	??160??(  "System.Windows.Controls.DatePicker  $??Center=?$??Center=?$	??120??   Text ?? $ Staff.DateIssuePassport??? $ 
Horizontal=?.+??? $??Дата рождения??$
??Left=?$??Center=?$	??160??  $
??Left=?$??Center=?$	??120?? ?? $ Staff.DateBirth??? $ 
Horizontal=?.+??? $??Год окончания??$
??Left=?$??Center=?$	??160??  $
??Left=?$??Center=?$	??120?? ?? $ Staff.YearGraduation??? $ 
Horizontal=?.+??? $!??Ученая степень??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120?? ?? DisplayMemberPath$ Degree?? ?? SelectedValuePath$ Degree?????? $ AcademicDegrees? ?? $ Staff.AcademicDegree??? $ 
Horizontal=?.+??? $??Ученое звание??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120??$ Title??$ Title?????? $ AcademicTitles? ?? $ Staff.AcademicTitle??? $ 
Horizontal=?.+??? $??Должность??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120??$ Title??$ Title?????? $ 	JobTitles? ?? $ Staff.JobTitle??? $ 
Horizontal=?.+??? $ ??Специальность??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120??$
 Name??$
 Name?????? $ Specialties? ?? $ Staff.Speciality??? $ 
Horizontal=?.+??? $ ??Подразделение??$
??Left=?$??Center=?$	??160???? $
??Left=?$??Center=?$	??120??$
 Name??$
 Name?????? $ Subdivisions? ?? $ Staff.Subdivision??? $??25,25,25,25q?$ 
Horizontal=?$??Center=?$
??Auto??$??2??$??40??$	??Top=?.+??? -   $??Сохранить??$	??100??$??5,5,5,5q??? -   $??Выбрать фото??$	??100??$??5,5,5,5q??? .+?? $	??368??$	??358?? ? ColumnDefinitions ?? $	??39* ??? $
??340* ?.+??? $??Фото??$??2???? -   	 ??Name$	 
PhotoImage??$	??300??$	??300??$??34,0,0,0q?$	??300??$	??300??$
??Left=?$??2?????? *BitmapPhoto+?? .+??? $	??288??$	??544??.@??? -   
 ??Name$
 penaltieItem??$??Взыскания??.??? -    ?Name$ penaltieItemGrid?? ?? $
??397* ??? $??3* ? ? RowDefinitions ?? $??* ??? $
??Auto ?.+?&   System.Windows.Controls.DataGrid  -     Name$ PenaltieGrid??   
IsReadOnly$ False??   AutoGenerateColumns$ False??$	??220??$??Center=?$??	10,0,10,0q????? *	Penalties+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Дата??   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding ?? *Date+ ?? StringFormat$ {0:dd.MM.yy HH:mm:ss}??  $ Договор??$	 100  ?? *Order+4  .System.Windows.Controls.DataGridComboBoxColumn  -   PenaltieTypesColumn??$ Тип??$	 120    DisplayMemberPath$
 Name??   SelectedValuePath$
 Name??   SelectedItemBinding ?? *PenaltieType+?? $
??Left=?$ 
Horizontal=?$
??Auto??$??1??.+??? -    ??Name$! deletePenaltieVentureButton??$??Удалить??$	??106???? $??Перемещения??.???  ?? $
??397* ??? $??3* ? ?? $??* ??? $
??Auto ?.+?  -	   $ MovementGrid??$ False??$ False??$	??220??$??Center=?$??	10,0,10,0q????? *	Movements+   $ Название?? ?? *Cause+  $ Дата?? ?? *Date+$ {0:dd.MM.yy HH:mm:ss}??  $ Договор?? ?? *Order+?? $
??Left=?$ 
Horizontal=?$
??Auto??$??1??.+??? -
   $ deleteMovementButton??$??Удалить??$	??106???? -   $
 EncouragementItem??$??Поощрения??.??? -   $ EncouragementItemGrid?? ?? $
??397* ??? $??3* ? ?? $??* ??? $
??Auto ?.+?  -   $ EncouragementGrid??$ False??$ False??$	??220??$??Center=?$??	10,0,10,0q????? *Encouragements+   $ Дата?? ?? *Date+$ {0:dd.MM.yy HH:mm:ss}??  $ Договор?? ?? *Order+  $ Поощрение??-   EncouragementTypesColumn??$	 120 $
 Name??$
 Name?? ?? *EncouragementType+?? $
??Left=?$ 
Horizontal=?$
??Auto??$??1??.+??? -   $ deleteEncouragementButton??$??Удалить??$	??106???? -   $
 EmploymentBookItem??$#??Трудовая книжка??.??? -   $ EmploymentBookItemGrid?? ?? $
??397* ??? $??3* ? ?? $??* ??? $
??Auto ?.+?  -   $ EmploymentBookGrid??$ False??$ False??$	??220??$??Center=?$??	10,0,10,0q????? *EmploymentBooks+   $ Должность?? ?? *
JobTitle+  $ Начало работы?? ?? *Start+$ {0:dd.MM.yy HH:mm:ss}??  $ Конец работы?? ?? *End+$ {0:dd.MM.yy HH:mm:ss}??  $) #Причина увольнения?? ?? *ReasonDismissal+?? $
??Left=?$ 
Horizontal=?$
??Auto??$??1??.+??? -   $  deleteEmploymentBookButton??$??Удалить??$	??106???? -   $
 PreviousVentureItem??$2??,Предыдущее место работы??.??? -   $ PreviousVentureItemGrid?? ?? $
??397* ??? $??3* ? ?? $??* ??? $
??Auto ?.+?  -   $ PreviousVentureGrid??$ False??$ False??$	??220??$??Center=?$??	10,0,10,0q????? *PreviousVentures+   $ Название??$	 100  ?? *Name+  $ 
Адрес??$	 200  ?? *	Address+  $ Телефон??$	 100  ?? *Phone+?? $
??Left=?$ 
Horizontal=?$
??Auto??$??1??.+??? -   $! deletePreviousVentureButton??$??Удалить??$	??106??