   M S B A M L   `   `   `  ����F  BMechanicApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MechanicApp.PagesMechanicApp.Pages  5      "    MechanicApp.Pages.OrdersPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      +localclr-namespace:MechanicApp.Pages  5      -   5          N� Title$  
OrdersPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      $��60 �6   .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6<   $��Список заявок��6Y   $��36(�6n   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
OrdersGrid��5       $��1��6      AutoGenerateColumns$ False��62      CanUserAddRows$ False��6N      CanUserDeleteRows$ False��6e      
IsReadOnly$
 True��6   A� 5   
   $��2��6    A� Rows$ 1��6#    A� Columns$ 2��6,   .+�5      �� -   5        $��
SaveButton��5   -   $	��160��6   $��30��6!   .��5      '  !MaterialDesignThemes.Wpf.PopupBox  $��Center=�5      $��Center=�5      $��aboba��5      $��16(�5         	PopupMode$ Click=�5      	   ToggleContent	 5      �� 5      
 �� Orientation$
 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  $��20��5    !   $��20��5!   !   
�������   Kind$ ContentSave=�5#   !   �� 5$      $��10,0,0,0q�5%   !   $��Center=�5&   !   $��Center=�5'   !   
�������$��Сохранить��5)   !   5*         PopupContent. 5,      �� .+�5-      �� -   5         ��Name$ 	SaveAsPDF��5-   !   $��Сохранить в PDF��64   6N   �� 5.      -   5        $ 	SaveAsCSV��5.   !   $��Сохранить в CSV��64   6N   5/      50      51      �� 52      -   5        $��
EditButton��52   h   $	��160��6   $��30��6!   $��Изменить��6-   
�������6h   53      54      55      