   M S B A M L   `   `   `  ����M  ITestContentControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TestContentControlTestContentControl  5   	   M+clr-namespace:TestContentControl.ViewModelsTestContentControl.ViewModels  5   	   #    TestContentControl.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TestContentControl     5   	   :vm+clr-namespace:TestContentControl.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5	       � Title$ 
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� 
���������6   �� *	Modules+��5      �� 5      .R�5      �� 5      ��5      �� 5      .R�5      �� $��40��5      $��10q�6)   ��5      �� *DataContext.OpenCommand+ �� RelativeSource �� *FindAncestor+ �� AncestorType" ����5      �� *Name+��6?   �� *Name+��5       �� 5!       �� 
TargetType" ��6$   .�5"   "   ��  �� Property � �� �� Value$ 1q�6D   �� 5$   "    � �� 5%   &   �� 5&   *    �� 
TargetType" ��6:   .R�5'   .   �� #��z��65   #��z��5(   5   #��z��5)   5   	 �� CornerRadius$	 10��5*   5   ._�5,   2   �� $��Center=�6C   $��Center=�6`   5-   /   5.   +   50   #   
 �� Triggers
 52   "   P� 53   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �54   *   ��  � ��
 ����6H   �� 55   *    � ��
 �����6G   56   '   58      5;      5<      5>      �� 5@   
   $��1��6   ��6)   �� *Page+5D      5E      