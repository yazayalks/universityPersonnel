   M S B A M L   `   `   `  ????N  JuniversityPersonnel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:universityPersonneluniversityPersonnel  5   	   %    universityPersonnel.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:universityPersonnel     5   	     ? Title$  LoginWindow??5   	   $	??450??6   $	??800??6*    ? WindowStartupLocation$ CenterScreen=?5	   	   .??5
      ? .+?5   
   ?? .@?5      ?? $??Авторизация??6   .??5      ??  ?? Orientation$ Vertical=?6   $??Center=?65   $??10q?6R   .+?5      ?? $ 
Horizontal=?6!   .+?5      ?? $??
Эмаил??6    $
??Left=?60   $??Center=?6L   $	??100??6g   ?? 5      -   5         ??Name$ LoginEmailText??5   ^    ?? TextWrapping$
 Wrap=?6"   $??Center=?66   $	??120??6Q   6^   5      ?? 5      $ 
Horizontal=?6!   .+?5      ?? $??Пароль??6    $
??Left=?61   $??Center=?6M   $	??100??6h   G? 5      -   5         G?Name$ LoginPasswordText??5   O   $??Center=?6(   $	??120??6C   6O   5      ?? 5      $??Center=?6!   $ 
Horizontal=?6>   $
??Auto??6X   $??1??6e   $??10q?6r   .+?5      ?? -   5         ??Name$ loginButton??5   !   $??
Войти??66   $	??106??6`   5      5      5      ?? 5      $??Регистрация??6   .??5      ?? $??Center=?6   $ Vertical=?6:   $??10q?6Q   .+?5      ?? $ 
Horizontal=?6!   .+?5      ?? $??
Эмаил??6    $
??Left=?60   $??Center=?6L   $	??100??6g   ?? 5       -   5        $ RegisterEmailText??5    ^   $
 Wrap=?6"   $??Center=?66   $	??120??6Q   6^   5!      ?? 5"      $ 
Horizontal=?6!   .+?5#      ?? $??Пароль??6    $
??Left=?61   $??Center=?6M   $	??100??6h   G? 5$      -   5        $ RegisterPasswordText??5$   N   $??Center=?6'   $	??120??6B   6N   5%      ?? 5&      $ 
Horizontal=?6!   .+?5'      ?? $-??'Подтверждение пароля??6    $
??Left=?6?   $??Center=?6[   $	??100??6v   G? 5(      -   5        $! RegisterPasswordConfirmText??5(   N   $??Center=?6'   $	??120??6B   6N   5)      ?? 5*      $??Center=?6!   $ 
Horizontal=?6>   $
??Auto??6X   $??1??6e   $??10q?6r   .+?5+      ?? -   5        $ registerButton??5+   !   $*??$Зарегистрироваться??69   $	??129??6s   5,      5-      5.      5/      51      52      