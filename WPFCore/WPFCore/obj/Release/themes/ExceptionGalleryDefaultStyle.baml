   M S B A M L   `   `   `  ���� B  >WPFCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPFCore.XAML.ConverterWPFCore.XAML.Converter  =#clr-namespace:WPFCore.XAML.ControlsWPFCore.XAML.Controls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   HoverBorderBrush_Outer  �� Color  HoverBorderBrush_Inner  HoverBackgroundBrush �� 
StartPoint �� EndPoint � Color � Offset  SelectedBorderBrush_Outer  SelectedBorderBrush_Inner  SelectedForegroundBrush  SelectedBackgroundBrush �� 
TargetType  AlternateListBoxItem �� Property �� Value �� 
TargetType	 �� CornerRadius
 J� SnapsToDevicePixels �� Padding �� Triggers P� Property P� Value �� 
TargetName0   *WPFCore.XAML.Converter.ObjectTypeConverter  
ObjectType,   &WPFCore.XAML.Controls.ExceptionGallery � RowDefinitions$ �� IsSynchronizedWithCurrentItem �� RelativeSource �� Path �� SelectedItem �� 	Converter � DataContext �� 
IsReadOnly �� TextWrapping �� Mode �� View �� DisplayMemberBinding �� Orientation ��Name�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     2	converter$clr-namespace:WPFCore.XAML.Converter  -local#clr-namespace:WPFCore.XAML.Controls  %�  &	        &	      &	 &     &	 x     &	 �     &	 �     &	 �     &	     7   7  7  7  7  7  7  &	 �    '  �    7  7  �� $  #B8D6FB���� $  #FCFDFE���� $	 0,0&�$	 0,1&�.��� $ #FAFBFD��$ 0Q�� $ #EBF3FD��$ 1Q��� $  #7DA2CE���� $  #EBF3FD���� $  Black���� $	 0,0&�$	 0,1&�.��� $ #DCEBFC��$ 0Q�� $ #C1DBFC��$ 1Q��� " ��.���  � ��$ Stretch=���  � �� �� " ��.R��� $��Border��$��1q�$	 3��
 . ._��� $��InnerBorder��$��1q�$	 2��
 . $ 1q�._���  P�  �@J�IsMouseOver . . ��� $ Border��8    � ���� $ InnerBorder��8   � ���� $ InnerBorder��8   � ��P�  �@��
IsSelected . . ��� $ InnerBorder��8   � ���� $ InnerBorder��8   � ���� $ Border��8   � ���� $ InnerBorder��8   � ��   �� "  .���  � �� �� "  .R��  �� $
��Auto ��� $��50 ��� $
��Auto ��� $
��Auto ��� �� $
��Auto �.+��� $��0��$��Exception list���� $��1��$
 TrueY�8��  ����  �� *TemplatedParent+$ FlatExceptionList� ��  �� *TemplatedParent+$ SelectedException����� .R��� ���� 8  �� $��2��$��5��$��Stretch=�$��Center=��� $��3��$��Message text���� $��4�� ��  �� *TemplatedParent+$ SelectedException�._��  �� �� .+��� $��0��$��1q����	#FF828790$	��0,3q�._��� $��1q�
�������$ 2q�._��� $��50�� . $
 Wrap=�$��Visible=����� $ Message�$ OneWay=��� $��1��.@��� $��Stack��.����  . $
 Wrap=�$��Visible=����� $ 
StackTrace�$ OneWay=��� $��Source��.����  . $
 Wrap=����� $ Source�$ OneWay=��� $
��Data��.���� ���� $
 Data� �� P��� $	��Key�� �� $	 Key��� $��Value�� �� $ Value��� $��5��._��� $ 
Horizontal=�.+��� $ PART_MovePrev��$��<<���� $ PART_MoveNext��$��>>��