   M S B A M L   `   `   `  ���� F  BHomework1_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Homework1_1Homework1_1      Homework1_1.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Homework1_1       � Title$  Multithreading Tasks��$	��600��$
��1000�����#C2C2FF$
��1000��$	��600�� � Icon$ /2822708.png�� � WindowStartupLocation$ CenterScreen=�.��� .+��� .@��� $��Task 1��.��� ���	#FFE5E5E5 � ColumnDefinitions �� $	��40* ��� $	��60* � � RowDefinitions �� $��* ��� $��* �.+��� -    ��Name$ edText��$��	5,20,5,20q� �� TextWrapping$
 Wrap=�$��3��$��2���� $��Text: ��$	��Top=�$��13(�� $��0��$��1�� �� $��* ��� $��* � �� $	��20* ��� $	��80* �.+��� $��0��$��0��$��Settings��$��14(�$
��Bold"�$��Center=�$	��Top=�$��2���� $��Output destination��$
��Bold"�$��13(�$��1��$��0��
�����_�
�������$��10q� � 	Resources  �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value �� ScaleX �� ScaleY��%�   '	�       �� " 	�.��� 	 � ��$
 14(��� 	 � ��$

 5,10q� P�  �@J�IsMouseOver$
 True��. ��� 	 � z�
 �� $	 1.2Q�$	 1.2Q�.���� $��Center=�.+�	� -    	�Name$ rbOutputMessage��$��
To message�� d� 	IsChecked$
 TrueY�	� -   $ rbOutputFile��$��To file���� $��Output content��$��DemiBold"�$��13(�$��1��$��1��
�����_�
�������$��10q� ��%�   '��       �� " ��.��� 	 � ��$
 11(��� 	 � ��$
 5q��� 	 �@d�	IsChecked$

 TrueY� P�  �@J�IsMouseOver$
 True��. ��� 	 � z�
 �� $	 1.2Q�$	 1.2Q�.���� $��Center=�.+��� -   $��cbCountSentences��$��Number of sentences���� -   $��cbCountSymbols��$��Number of  symbols���� -   $��cbCountWords��$��Number of words���� -   $��cbCountQuestions��$��Number of questions���� -   $��cbCountExlamations��$��Number of exclamations��� $��1��$��1��$��5q� �� $��* ��� $��* ��� $��* � �� $��* ��� $��* � ��%g   '��       �� " ��.��� 	 � ��$

 5,23q��� 	 � ��
 �#0D5F82�� 	 � ��
 �#58C1EE.+��� -	   $��btnStart��$��0��$��0��$��Start���� -
   $��btnStop��$��0��$��2��$
��Stop���� -   $��btnOpenFileText��$��1��$��1��.���� $
��Wrap=�$%��Open file(if one was generated)��
������ $	��127��$��14(�$|�False��r� $��1��$
��Left=�$	��100��$��
104,29,0,0q�$	��Top=�$	��100���� $��Task 2��.��� ���	#FFE5E5E5 �� $��* ��� $��* ��� $��* �.+�� $��0�� �� $��8* ��� $
��Auto ��� $	��80* �.+��� $��Source Directory��$��14(�$��	ExtraBold"�$��0��$��Center=�$��Center=�
������ �� -   $��lbSourceFiles��$��2��$
��5,10q�� $��1�� �� $��8* ��� $
��Auto ��� $	��80* �.+��� $��0��$��Destination Directory��$��14(�$��	ExtraBold"�$��Center=�$��Center=�
������ �� -   $��lblDestination��$�� ��$��1��$��14(�$��Center=�$��Center=��� -   $��lbDestinationFiles��$��2��$
��5,10q��� $��2��$��	5,25,5,15q� ��%�   '��       �� " ��.��� 	 � ��$
 60���� 	 � ��$

 2,20q��� 	 � ��$
 14(��� 	 � ��$
 
ExtraLight"��� 	 � ��

 �   �.+��� -   $��btnChangeSource��$��Change Source Directory���� -   $��btnChangeDestination��$"��Change Destination Directory���� -   $��cbGenerateAnalysis��$��Generate analysis file?��$��Center=�$��14(�$��Medium"��� -   $��btnTransferFiles��$,��&Transfer original files to destination���� $��List of files from source��$��14(�$��0q� ��%�   '	�       �� " 	�.��� 	 � ��$
 14(��� 	 � ��$	
 5,4q��� 	 � ��$
 DemiBold"� P�  �@J�IsMouseOver$
 True��. ��� 	 � z�
 �� $	 1.1Q�$	 1.1Q�.���� $��Center=�.+�	� -   $ 
rbOpenFile��$��Double-click opens file��$
 TrueY�	� -   $ rbDeleteFile��$,��&Double-click removes file from copying��