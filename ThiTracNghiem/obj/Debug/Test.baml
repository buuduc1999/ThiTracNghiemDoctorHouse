   M S B A M L   `   `   `  ����  ThiTracNghiem    ThiTracNghiem.Test   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v20.1, Version=20.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$
  Test��5   	   $��922.05��6   $	��850��6&    � 
ResizeMode$ NoResize=�6D   .��5	      �� -   5         ��Name$ 	thanhcuon��5	      $
��auto��6&   $
��auto��63   .��5
   
   � -   5         �Name$ 
KetquaGrid��5
       � RowDefinitions 5      �� 5      $	��150 �6    �� 5      $	��300 �6    �� 5      $
��422* �6     � ColumnDefinitions 5      �� 5      $	��400 �6#   �� 5      .+�5      � $��0��6   $
��140 ��6    $��2��63   $	��0,5q�6G   .+�5      �� $��
header.png��6   $
��Fill=�6,   �� 5      -   5         ��Name$	 STT��5      $��unknown��6%   $
��Left=�67   
���   �$��
652,43,0,0q�6e   $	��Top=�5      $
��Bold"�60   $��18(�6B    J� RenderTransformOrigin$ 	0.2,3.773&�5      $	��149��6:   $��28��6F   �� 5      -   5         ��Name$ ProjectLabel��5      $��TIN HOC VAN PHONG��62   $
��Left=�6K   
���   �$
��Bold"�6y   $��
682,71,0,0q�5      $	��Top=�60   $
��Wrap=�6H   $ 	0.2,3.773&�5      $	��130��6>   $��50��6J   $��18(�6V   5      � 5      $��1��6   $��1��6    $��2��60    5      �� 5       $
��344* �6$   �� 5!      $	��49* �6$   .+�5#      �� ���	#FFF7F7ED$
��Left=�6-   $	��224��6H   $��	10,55,0,0q�6U   
���   �$	��Top=�5$      $	��339��64   �� 5%      $�� ��6   $��20(�6$   $
��Left=�62   $	��Top=�6M   $
��Bold"�6e   $��40��5&      $��	44,50,0,0q�6(   �� 5'      $$��ĐIỂM SỐ ĐẠT ĐƯỢC: ��6   $��30(�66   $
��Left=�6D   $	��Top=�6_   $
��Bold"�5(      $��40��5)      $��	10,10,0,0q�6(   $��	Underline{�6;   ���	#FFE45353$ 1.177,0.612&�5*      �� 5+      -   5        $ DiemSoLb��5+      $��Center=�6*   $��Center=�6N   $��Label��5,      $��80(�6(   $
��Left=�66   $��	44,76,0,0q�6Q   $	��Top=�5-      $��DemiBold"�5.      $	��160��5/      $	��272��6%   ���	#FFE4535361   51      � 52      -   5        	 �Name$	 	wrappanel��52      $��1��6+   $��0��68   $
��Left=�6H   $	��294��6c   $��	11,10,0,0q�53      $	��Top=�6+   $	��400��6C   $��2��6O   .+�54      �� $��Họ Tên: ��6   $��20(�6,   $
��Left=�6:   $	��Top=�6U   $
��Bold"�55      $��36��56      �� 57      -   5        $ hotenlb��57      $
��Wrap=�6-   $��unknown��6A   $��20(�6P   $	��302��6^   �� 58      $��Vị Trí: ��6   $��20(�6,   $
��Left=�6:   $	��Top=�6U   $
��Bold"�59      $��33��5:      �� 5;      -	   5        $ chucvulb��5;      $
��Wrap=�6.   $��unknown��6B   $��20(�6Q   $	��328��6_   $ 0.5,0.5&�5<      �� 5=      $��
Mã Số: ��6   $��20(�6+   $
��Left=�69   $	��Top=�6T   $
��Bold"�5>      $��68��5?      $��35��6'   �� 5@      -
   5        $ masolb��5@      $
��Wrap=�6,   $��unknown��6@   $��20(�6O   $	��316��6]   �� 5A      $��Số câu hỏi: ��6   $��20(�60   $
��Left=�6>   $	��Top=�6Y   $
��Bold"�5B      $��40��6.   $	��116��6:   �� 5C      -   5        $ socaulb��5C      $
��Wrap=�6-   $��unknown��6A   $��20(�6P   $	��170��6^   �� 5D      $��Thời gian cho phép: ��6   $��20(�68   $
��Left=�6F   $	��Top=�6a   $
��Bold"�5E      $��38��6.   $	��207��6:   �� 5F      -   5        $ 
thoigianlb��5F      $
��Wrap=�60   $��unknown��6D   $��20(�6S   $	��125��6a   �� 5G      $!��Thời gian thực hiện: ��6   $��20(�69   $
��Left=�6G   $	��Top=�5H      $
��Bold"�5I      $��38��6.   $	��199��6:   �� 5J      -   5        $ thoigianthuchienlb��5J      $
��Wrap=�68   $��unknown��6L   $��20(�6[   $	��108��6i   5K      �� 5N      -   5        
 ��Name$
 
stackpanel��5N   :   $��2��6   $��2��6&   $
��Left=�6N   $
��auto��6i   $��6,0,0,0q�5O      $��Stretch=�5P      $	��800��65   .+�5Q      �� $
��Wrap=�6   $,��&             ĐÁP ÁN TRẮC NGHIỆM��61   
���  ��$
��Bold"�6i   $��40(�6{   $��10,0,0,0q�6�   5T      5V      5Y      5Z      