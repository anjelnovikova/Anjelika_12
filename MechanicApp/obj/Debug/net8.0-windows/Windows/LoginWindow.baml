   M S B A M L   `   `   `  ����F  BMechanicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MechanicApp.WindowsMechanicApp.Windows  5      %    MechanicApp.Windows.LoginWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:MechanicApp.Windows     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$5  /Система АвтоМеханик. Вход��5	      $	��486��5
      $	��450��5       � AllowsTransparency$
 True��5      
������  � 
ResizeMode$ NoResize=�5         MaterialDesignWindow#��[  5      $��14(�5      $��Medium"�5        MaterialDesignBody#���  5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      ��5      :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �� 
�������$��2q�5   	    �� CornerRadius$ 20��5   	   ._�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5        $
��Host��5   $      CornerRadius$ 20��60   .��5      � -   5         �Name$ MainGrid��5      .+�5      �� -   5        $��45��5      $��40��5      $��0,-1,0,0q�5       $��Right=�5!      $	��Top=�5"      
������ $��X��5%      $��16(�5&      
�������5'      �� 5(      -   5        $��45��5)      $��40��5*      $��	0,-1,50,0q�5+      $��Right=�5,      $	��Top=�5-      
������ $��-��50      $��16(�51      
�������52      �� 53      .+�54      �� $	��185��55      $��50��56      $��0,20,0,0q�57      $��Center=�58      $��18(�59      $4��.Форма авторизации AutoMechanic��5:       �� TextAlignment$ Center=�5;      $
��Wrap=�5<      '  !MaterialDesignThemes.Wpf.PackIcon  5=      $	��151��5>      $	��140��5?      $��Center=�5@      	   Kind$	 	CarWrench=�5A      �� 5B      -   5        $��loginTextBox��5C      $	��260��5D      $��0,20,0,0q�5E      $��Center=�5F      $	��Top=�5G      )  #MaterialDesignThemes.Wpf.HintAssist
   
Background

 ���� &   FloatingHintHorizontalAlignment$ Inherit=�5I         
Foreground
 �   �   Hint$ 
Логин��5K         
IsFloating$ False��5L      $��14(�5M       ! MaterialDesignOutlinedTextBox#���  5N       �� TextWrapping$
 Wrap=�5P      ��5O      ��  �� RelativeSource �� *Self+ �� Path$	 Tag�5P      G� 5Q      -   5        $��passwordBox��5R      $	��260��5S      $��0,20,0,0q�5T      $��Center=�5U      $	��Top=�5V      

 ���� $ Inherit=�5X      
 �   �$ Пароль��5Z      $ False��5[      $��14(�5]       + 'MaterialDesignOutlinedRevealPasswordBox#���  5^      0  *MaterialDesignThemes.Wpf.PasswordBoxAssist   Password 5\      ��  �� *Self+$	 Tag�5^      �� 5_      -   5        $��btnAuth��5`      $	��230��5a      $��45��5b      $��0,30,0,0q�5c      $��Center=�5d      $	��Top=�5e      $��Вход��5g      
�������5h      5i      5j      5k      5l      5m      