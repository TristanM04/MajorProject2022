   M S B A M L   `   `   `  ����K  GMajorProject2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MajorProject2022MajorProject2022  5   	   %    MajorProject2022.SettingsWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MajorProject2022     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   66   -   5          � Title$  RegisterWindow��5   	   $	��720��6    $
��1280��6-    � WindowStartupLocation$ CenterScreen=�6:    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels	 �� StrokeDashArray  Button.Static.Background
 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 HomeBtnStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName  ProfileBtnStyle  SettingsBtnStyle  CloseBtnStyle��%p  &	        &	 �     &	 �     &	 �     &	     &	 =    &	 `    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 &	     7   7  7  7  7  7 	 &	 @    7   7  7  7  7  7 	 &	 j    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $
 true��6/   #��� ��6J   $��1��6�   $		 1 2R�6�   5      5      5      �� 5   
   $
 #FFDDDD��6;   �� 5   
   $
 	#FF707070��67   �� 5   
   $
 	#FFBEE6FD��6>   �� 5   
   $
 	#FF3C7FB1��6:   �� 5   
   $
 	#FFC4E5F6��6<   �� 5   
   $
 	#FF2C628B��68   �� 5   
   $
 	#FFF4F4F4��6=   �� 5   
   $
 	#FFADB2B5��69   �� 5    
   $
 	#FF838383��6=   �� 5$   
   " ��6%   .�5%      ��  �@�FocusVisualStyle8   61   �� 5&       � ��8  6+   �� 5'       � ��8  6,   �� 5(       � ��# � ��6+   �� 5)       � ��$ 1q�60   �� 5*       � ��$ Center=�6;   �� 5+       � ��$ Center=�69   �� 5,       � ��$ 1q�6(   �� 5-       � �� 5.      �� 5/      " ��6&   .R�50      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   $
 true��6�   ._�51      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  52       53      P� 54       �@��IsDefaulted$
 true��6=   . �55   "   �� $ border��6@   # � ��6T    � ��56      P� 57       �@J�IsMouseOver$
 true��6=   . �58   "   �� $ border��6?    � �� �#3A61806S   �� 59   "   $ border��6@    � �� �#3A61806T   5:      P� 5;       � ��$
 true��6;   . �5<   "   �� $ border��6?    � �� �#3A61806S   �� 5=   "   $ border��6@    � �� �#3A61806T   5>      P� 5?       � {�$ false��6;   . �5@   "   �� $ border��6?   8   � ��6S   �� 5A   "   $ border��6@   8   � ��6T   �� 5B   "   $ contentPresenter��6K   8   � ��6i   5C      5E      5G      5H      �� 5L   
   " ��6(   .�5M      ��  �@�FocusVisualStyle8   61   �� 5N       � ��8  6+   �� 5O       � ��8  6,   �� 5P       � ��# � ��6+   �� 5Q       � ��$ 1q�60   �� 5R       � ��$ Center=�6;   �� 5S       � ��$ Center=�69   �� 5T       � ��$ 1q�6(   �� 5U       � �� 5V      �� 5W      " ��6&   .R�5X      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   $
 true��6�   ._�5Y      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5Z       5[      P� 5\       �@��IsDefaulted$
 true��6=   . �5]   "   �� $ border��6@   # � ��6T    � ��5^      P� 5_       �@J�IsMouseOver$
 true��6=   . �5`   "   �� $ border��6?    � �� �#3A61806S   �� 5a   "   $ border��6@    � �� �#3A61806T   5b      P� 5c       � ��$
 true��6;   . �5d   "   �� $ border��6?    � �� �#3A61806S   �� 5e   "   $ border��6@    � �� �#3A61806T   5f      P� 5g       � {�$ false��6;   . �5h   "   �� $ border��6?   8   � ��6S   �� 5i   "   $ border��6@   8   � ��6T   �� 5j   "   $ contentPresenter��6K   8   � ��6i   5k      5m      5o      5p      �� 5t   
   " ��6)   .�5u      ��  �@�FocusVisualStyle8   61   �� 5v       � ��8  6+   �� 5w       � ��8  6,   �� 5x       � ��# � ��6+   �� 5y       � ��$ 1q�60   �� 5z       � ��$ Center=�6;   �� 5{       � ��$ Center=�69   �� 5|       � ��$ 1q�6(   �� 5}       � �� 5~      �� 5      " ��6&   .R�5�      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   $
 true��6�   ._�5�      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5�       5�      P� 5�       �@��IsDefaulted$
 true��6=   . �5�   "   �� $ border��6@   # � ��6T    � ��5�      P� 5�       �@J�IsMouseOver$
 true��6=   . �5�   "   �� $ border��6?    � �� �#3A61806S   �� 5�   "   $ border��6@    � �� �#3A61806T   5�      P� 5�       � ��$
 true��6;   . �5�   "   �� $ border��6?    � �� �#3A61806S   �� 5�   "   $ border��6@    � �� �#3A61806T   5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   �� 5�   "   $ contentPresenter��6K   8   � ��6i   5�      5�      5�      5�      �� 5�   
   " ��6&   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   $
 true��6�   ._�5�      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5�       5�      P� 5�       �@��IsDefaulted$
 true��6=   . �5�   "   �� $ border��6@   # � ��6T    � ��5�      P� 5�       �@J�IsMouseOver$
 true��6=   . �5�   "   �� $ border��6?    � ��
 ���� 6S   �� 5�   "   $ border��6@    � ��
 ���� 6T   5�      P� 5�       � ��$
 true��6;   . �5�   "   �� $ border��6?    � ��
 ���� 6S   �� 5�   "   $ border��6@    � ��
 ���� 6T   5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   �� 5�   "   $ contentPresenter��6K   8   � ��6i   5�      5�      5�      5�      5�      .��5�      ��  �� CornerRadius$ 20��6   ��5�   
   �� 5�      .��5�      �  � Color$ DarkBlue��6    � Offset$	 0.0Q�60   � 5�      $ #010917��6   $ 1Q�6/   5�      ._�5�   
   �  � ColumnDefinitions 5�      �� 5�      $	��100 �6#   �� 5�      $	��100 �6#    � RowDefinitions 5�      �� 5�      $
��auto �6    �� 5�      $
��auto �6    �� 5�      $��* �6    .+�5�      �� $��3��6   $ 	20,0,0,20��6&   ���#0c0838._�5�      � .+�5�      �� $	��Top=�6!   .+�5�      �� .+�5�      �� -   5         ��Name$ Workout��5�   %   $	��100��5�      
������ 
������ $��
0,180,0,20q�5�      #��� 
 5�      .��5�   "   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Dumbbell=�6=   $��Center=�5�   -   $��Center=�5�   -   
�������$��40��5�   -   $��40��5�   -   5�      �� 5�      $ 20��6%   �� 5�      -   5        $ Settings��5�   %   $	��100��5�      
������ 
������ $��0,10,0,0q�5�      #���  5�      .��5�   "     $	 Cog=�6=   $��Center=�5   -   $��Center=�5  -   
�������$��40��5  -   $��40��5  -   5     5     5
     5     5     � 5     $��1��6   $��
100,30,0,0q�6#    5     �� 5     $��* �6'   �� 5     $
��auto �6'   .+�5     � $��2��6   $��0,0,-1050,0q�6+   .+�5     �� $��Center=�6    
�������$��	62,0,30,0q�5      $C��=Current details                                   New details��5       K� ZIndex$ 1��5      $��	Helvetica)�5      $��	ExtraBold"�5      $��36(�5      $y�Visible=�5       J� IsHitTestVisible$ False��5      �� 5      -   5        $
 Exit��5      $��40��5!     $��40��5"     
������ $��0q�5$     $��Center=�5%     $��Right=�5&     $��0,0,0,0q�5'     #���  5(     .��5,       $ Close=�65   $��Center=�5-  -   $��Center=�5.  -   
�������5/  -   51     54     57     � 59     $��1��6   $��0,73,-474,0q�6#   $��3��68   .+�5:     �� $
{�True��6   $��30q�6.   $��Center=�6:   .+�5=     ��  �� Orientation$ 
Horizontal=�6!   $��0,0,70,0q�6:   .+�5>     �� -   5         ��Name$ EmailBox��5>  $   $��	Helvetica)�66   $��Light"�5?     $��25(�5A     $��Center=�5B     
�������
������ $	��235��5E      J� Opacity$	 0.4Q�5F     $��35��5G     $��
105,50,0,0q�5H     ��5@     ��  �� Path$ Globals.eMail�  �� UpdateSourceTrigger$  PropertyChanged=�5H       5I     $ Email=�65   $��Bottom=�5J  -   $��Center=�5K  -   $��	0,20,35,3q�5L  -   
�������5M  -   5O     �� 5P     $	��250��6   $��2��5Q     
�������$	 1.0Q�5S     �� 5U     $ 
Horizontal=�6!   $��	0,100,0,0q�6:   .+�5V     �� -   5        $ UsernameBox��5V  $   $��	Helvetica)�69   $��Light"�5W     $��25(�5Y     $��Center=�5Z     
�������
������ $	��235��5]     $	 0.4Q�5^     $��35��5_     $��	105,0,0,0q�5`     ��5X     �� $ Globals.userName�$  PropertyChanged=�5`       5a     $ Account=�65   $��Center=�5b  -   $��Center=�5c  -   
�������5d  -   5f     �� 5g     $	��250��6   $��2��5h     
�������$	 1.0Q�5j     �� 5l     $ 
Horizontal=�6!   $��	0,100,0,0q�6:   .+�5m     �� -   5        $ PasswordBox��5m  $   $��	Helvetica)�69   $��Light"�5n     $��25(�5p     $��Center=�5q     
�������
������ $	��235��5t     $	 0.4Q�5u     $��35��5v     $��	105,0,0,0q�5w     ��5o     �� $ Globals.passWord�$  PropertyChanged=�5w       5z     $
 Lock=�65   $��Center=�5{  -   $��Center=�5|  -   
�������5}  -   5     �� 5�     $	��250��6   $��2��5�     
�������$	 1.0Q�5�     �� 5�     $ 
Horizontal=�6"   $��0,60,0,0q�6;   .+�5�     �� -   5        $ 
NewRefresh��5�  !   $	��250��5�     $��60��5�     $��Refresh��5�     $��20(�5�     $��107,20,60,0q�5�     5�     5�     5�     5�     � 5�     $��2��6   $��573,73,-1114,0q�6#   $��3��6;   .+�5�     �� $
{�True��6   $��30q�6.   $��Center=�6:   .+�5�     �� $ 
Horizontal=�6!   $��0,0,70,0q�6:   .+�5�     �� -	   5        ! ��Name$! NewEmailBox��5�  "   $��	Helvetica)�67   $��Light"�5�     $��Email��5�     $��25(�5�     $��Center=�5�     
�������
������ $
��Left=�5�     $	��235��5�     $	 0.4Q�5�     $��35��5�     $��
105,50,0,0q�5�       5�     $ Email=�65   $��Bottom=�5�  -   $��Center=�5�  -   $��	0,20,35,3q�5�  -   
�������5�  -   5�     �� 5�     $	��250��6   $��2��5�     
�������$	 1.0Q�5�     �� 5�     $ 
Horizontal=�6!   $��	0,100,0,0q�6:   .+�5�     �� -
   5        $! NewUsernameBox��5�  "   $��	Helvetica)�6:   $��Light"�5�     $��Username��5�     $��25(�5�     $��Center=�5�     
�������
������ $	��235��5�     $	 0.4Q�5�     $��35��5�     $��	105,0,0,0q�5�       5�     $ Account=�65   $��Center=�5�  -   $��Center=�5�  -   
�������5�  -   5�     �� 5�     $	��250��6   $��2��5�     
�������$	 1.0Q�5�     �� 5�     $ 
Horizontal=�6!   $��	0,100,0,0q�6:   .+�5�     G� -   5        " G�Name$" NewPasswordBox��5�  &   $��	Helvetica)�6>   $��Light"�5�     # G� Password$# Password��5�     $��25(�5�     $��Center=�5�     
�������
������ $	��235��5�     $	 0.4Q�5�     $��35��5�     $��	105,0,0,0q�5�       5�     $
 Lock=�65   $��Center=�5�  -   $��Center=�5�  -   
�������5�  -   5�     �� 5�     $	��250��6   $��2��5�     
�������$	 1.0Q�5�     �� 5�     $ 
Horizontal=�6"   $��0,60,0,0q�6;   .+�5�     �� -   5        $ 
NewConfirm��5�  !   $	��250��5�     $��60��5�     $��Confirm��5�     $��20(�5�     $��115,20,60,0q�5�     5�     5�     5�     5�     5�     5�     5�     