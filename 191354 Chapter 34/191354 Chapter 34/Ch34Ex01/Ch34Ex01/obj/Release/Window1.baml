   M S B A M L   `   `   `  ����   Ch34Ex01    Ch34Ex01.Window1   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6x,http://schemas.microsoft.com/winfx/2006/xaml     � Title$  Color Spinner��$	��370��$	��270�� � 	Resources    Spin g� 	BeginTime �� 
TargetName �� TargetProperty g� RepeatBehavior O� KeyTime O� Value��%�  &	        �� .��U� $ 00:00:00X�$ ellipse1��$V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(RotateTransform.Angle)�$ Forever��.\��� $ 00:00:10��$	 360Q�U� $ 00:00:00X�$ ellipse2��$V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(RotateTransform.Angle)�$ Forever��.\��� $ 00:00:10��$
 -360Q�U� $ 00:00:00X�$ ellipse3��$V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(RotateTransform.Angle)�$ Forever��.\��� $ 00:00:05��$	 360Q�U� $ 00:00:00X�$ ellipse4��$V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(RotateTransform.Angle)�$ Forever��.\��� $ 00:00:05��$
 -360Q� � Triggers :� 	 :� RoutedEvent$	 FrameworkElement.Loaded��.[��� -   
 ��Name$
 Spin_BeginStoryboard��#��[  :� $	 ButtonBase.Click�� :� 
SourceName$ goButton��.[���  �� BeginStoryboardName$ Spin_BeginStoryboard��:� $	 ButtonBase.Click��$ 
stopButton��.[�?� $ Spin_BeginStoryboard������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFFFFFFF�� � Offset$ 0Q�� $ 	#FFFFC45A��$ 1Q�.��� .+�A� -   $��ellipse5��$��	50,50,0,0q�
���   �$	��150��$
��Left=�$	��Top=�$	��150�� J� BitmapEffect ��  �� Radius$ 10Q���
� .��� $ 	#FF000000��$ 1Q�� $ 	#FFFFFFFF��$ 0.306Q�A� -   $��ellipse1��$��	15,85,0,0q�$��80��$
��Left=�$	��Top=�$	��120��
���  �� J� Opacity$	 0.5Q� J� RenderTransformOrigin$ 0.92,0.5&���Z�  �� z�V� .~���  �� Angle$ 0Q�A� -   $��ellipse2��$��	85,15,0,0q�$	��120��$
��Left=�$	��Top=�$��80��
����  �$	 0.5Q�$ 0.5,0.92&���Z�  �� z�V� .~��� $ 0Q�A� -   $��ellipse3��$��
115,85,0,0q�$��80��$
��Left=�$	��Top=�$	��120��$	 0.5Q�
��� ���$ 0.08,0.5&���Z�  �� z�V� .~��� $ 0Q�A� -   $��ellipse4��$��
85,115,0,0q�$	��120��$
��Left=�$	��Top=�$��80��$	 0.5Q�
��� � �$ 0.5,0.08&���Z�  �� z�V� .~��� $ 0Q��� -   $��goButton��$��23��$
��Left=�$��	20,0,0,56q�$��Bottom=�$��75��$��Go���� -   $��
stopButton��$��23��$
��Left=�$��
152,0,0,56q�$��Bottom=�$��75��$
��Stop���� -	   $��toggleButton��$��23��$
��Left=�$��
85,0,86,16q�$��Bottom=�$��75��$��Toggle��