   M S B A M L   `   `   `  ���� E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator      Calculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Calculator       � Title$  Сalculator��$	��500��$	��400�����#E5F0FF � WindowStyle$ 
ToolWindow=� � 
ResizeMode$ NoResize=� � 	Resources    Calculator.CalculatorLogic   calcLog   
Expression �� 
TargetType �� Property �� Value��%�   &	        '��        $ 0���� " ��.���  � ��$ Calibri)���  � ��$ 30(���  � �� �#BDCCFF��  � ��
 �   ���  � ��$ 10q�.��� -    �Name$ 
LayoutRoot�����#E5F0FF$��20,20,20,20q�	 � RowDefinitions	 �� �� �� �� �� �� 
 � ColumnDefinitions
 �� �� �� �� �� .+��� -    ��Name$ 	textBlock��$��0��$��5�����#E5F0FF �� TextAlignment$ Right=�$��Center=�$��Calibri)�$��20(����� *
Expression+ �� Source# [  �� -    ��Name$ textBox��$��1��$��5�����#E5F0FF �� TextAlignment$ Right=�$��Bottom=�$��Calibri)�$��40(����� *
Expression+# [  �� -    ��Name$ button1��$��0��$��2�� � Cursor$
 Hand��.��1�� -   $ button2��$��1��$��2��$
 Hand��.��2�� -   $ button3��$��2��$��2��$
 Hand��.��3�� -   $ button4��$��0��$��3��$
 Hand��.��4�� -   $ button5��$��1��$��3��$
 Hand��.��5�� -	   $ button6��$��2��$��3��$
 Hand��.��6�� -
   $ button7��$��0��$��4��$
 Hand��.��7�� -   $ button8��$��1��$��4��$
 Hand��.��8�� -   $ button9��$��2��$��4��$
 Hand��.��9�� -   $ button0��$��0��$��5��$��2��$
 Hand��.��0�� -   $ 	buttonDot��$��2��$��5��$
 Hand��.��,�� -   $ buttonDivide��$��3��$��2��$
 Hand��.��/�� -   $ buttonMultiply��$��3��$��3��$
 Hand��.��*�� -   $ buttonSubtract��$��3��$��4��$
 Hand��.��-�� -   $ 	buttonAdd��$��3��$��5��$
 Hand��.��+�� -   $ buttonEquals��$��4��$��4��$��2��$
 Hand��.��=�� -   $ buttonBackspace��$��4��$��2��$
 Hand��.��<-�� -   $ buttonClear��$��4��$��3��$
 Hand��.��C