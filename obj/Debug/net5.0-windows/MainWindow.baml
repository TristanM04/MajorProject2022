   M S B A M L   `   `   `  ����K  GMajorProject2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MajorProject2022MajorProject2022  5   	   !    MajorProject2022.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MajorProject2022     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   66   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � WindowStartupLocation$ CenterScreen=�65    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��2* �6    �� 5      $��3* �6    .+�5      ��  �� CornerRadius$ 20��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ DarkBlue��6'    � Offset$	 0.0Q�68   � 5      $ #010917��6'   $ 1Q�67   5      5      �� 5      	 �� Orientation$	 
Horizontal=�6   $��0,0,0,0q�62   .+�5      �� -   5        
 ��Name$
 
ExitButton��5      $��
340,10,0,0q�5       $��30��5!      $��30��5"      $
��Left=�5$      $	��Top=�5%      $��2q�5&      .��5(      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ 
CloseThick=�61   
�������5)   -   5*      5+      �� 5-      .+�5.      �� $��0,50,0,0q�5/      $��JACKED��50      $��	ExtraBold"�51      $��	Helvetica)�52      $��36(�53      ���#ffffff$��Center=�55      $��Center=�56      �� 57      $��67��6   $	��140��6%   58      �� 5=      $��1��6   .+�5>      �� $	 
Horizontal=�6   $��0,25,0,0q�66   .+�5?      �� -   5         ��Name$ UsernameBox��5?      $��	Helvetica)�63   $��Light"�5@      $��Username��5A      $��20(�5C      $��Center=�5D      
�������
������ $��0q�5G      $	��235��5H      $
��Left=�5I       J� Opacity$	 0.4Q�5J      $��25��5K      $��63,0,0,0q�5L        5M      $ Account=�61   $��Center=�5N   -   $��Center=�5O   -   
�������5P   -   5R      �� 5S      $	��250��6   $��2��5T      
�������$	 1.0Q�5V      �� 5X      $	 
Horizontal=�6   $��0,25,0,0q�66   .+�5Y      G� -   5         G�Name$ PasswordBox��5Y   "   $��	Helvetica)�67   $��Light"�5Z       G� Password$ Password��5[      $��20(�5]      $��Center=�5^      
�������
������ $��0q�5a      $	��235��5b      $
��Left=�5c      $	 0.4Q�5d      $��25��5e      $��63,0,0,0q�5f        5i      $
 Lock=�61   $��Center=�5j   -   $��Center=�5k   -   
�������5l   -   5m      �� 5n      $	��250��6   $��2��5o      
�������$	 1.0Q�5q      �� 5s      $	 
Horizontal=�6   $��0,60,0,0q�66   .+�5t      �� -   5        $	��100��5t      $��40��5u      $��LOGIN��5v      $��	60,0,60,0q�5w      5x      �� 5y      -   5        $
 MainRegisterButton��5y      $	��100��5z      $��40��5{      $��REGISTER��5|      5}      5      5�      5�      5�      5�      