   M S B A M L   `   `   `  ����O  KMN_CalculadoraRaices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MN_CalculadoraRaicesMN_CalculadoraRaices  5   	   )    #MN_CalculadoraRaices.Newton_Raphson   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MN_CalculadoraRaices     5   	     � Title$  Newton_Raphson��5   	   $	��800��6    $	��800��6-   .��5	      � $	��800��6   $	��800��6   $	��800��6*   $	��800��69    � ColumnDefinitions 5
   
   �� 5      $	��61* �6   �� 5      $	��99* �6   .+�5   
   �� $��44,59,44,486q�6   $��/newton.png��6&   $
��Fill=�6;   $��2��6J   �� 5   
   $��Newton-Raphson��6   $
��Left=�6)   $��80��6D   $	��Top=�6P   $	��540��6h   ���	#FF312C40$��48(�6�   $��Segoe Print)�6�   $��Center=�6�   $��2��6�   $��	130,0,0,0q�6�   �� 5   
   -   5         ��Name$
 coeA��5      $
��Left=�6    $��175,333,0,0q�6;    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��450��6|   $��36��6�   ���	#FF312C40���	#FF312C40$��Lucida Calligraphy)�6�   $��Center=�6�   $��Center=�6  $��16(�6@  $��2��6N  ��6�   Z� 6N  �� 5   
   -   5        $
 coeB��5      $
��Left=�6    $
 Wrap=�6;   $��Center=�6O   $	��450��6j   $��36��6v   ���	#FF312C40���	#FF312C40$��Lucida Calligraphy)�6�   $��Center=�6�   $��Center=�6  $��16(�6-  $��2��6;  $��	175,0,0,0q�6O  ��6�   Z� 6O  �� 5   
   -   5        $
 coeC��5      $
��Left=�6    $��175,433,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $	��450��6|   $��36��6�   ���	#FF312C40���	#FF312C40$��Lucida Calligraphy)�6�   $��Center=�6�   $��Center=�6  $��16(�6@  $��2��6N  ��6�   Z� 6N  �� 5   
   -   5        $
 coeD��5      $
��Left=�6    $��175,483,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $	��450��6|   $��36��6�   ���	#FF312C40���	#FF312C40$��Lucida Calligraphy)�6�   $��Center=�6�   $��Center=�6  $��16(�6@  $��2��6N  ��6�   Z� 6N  �� 5   
   $��Raíces��6   $
��Left=�6!   $��25��6<   $��138,619,0,0q�6H   $	��Top=�6]   $��78��6u   ���	#FF312C40$��Center=�6�   $��Center=�6�   $��Cooper Black)�6�   $��16(�6�    J� RenderTransformOrigin$ -1.286,-0.798&�6  �� 5   
   $��Iteraciones��6   $
��Left=�6&   $��25��6A   $��
16,619,0,0q�6M   $	��Top=�6a   $	��115��6y   ���	#FF312C40$��Center=�6�   $��Center=�6�   $��Cooper Black)�6�   $��16(�6�   $��1��6
  �� 5   
   -   5         ��Name$ btnCalcular��5      $��Calcular��6&   $
��Left=�69   $��45��6T   $��	3,544,0,0q�6`   $	��Top=�6s   $	��184��6�   ���	#FF312C40
�������$��Elephant)�6�   $��20(�6�   $��1��6  ��6�   Z� 6  �� 5   
   -   5        $ raices��5      $
��Left=�6"   $��80��6=   $��114,652,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��126��6�   
���   �$��Comic Sans MS)�6�   ��6�   Z� 6�   �� 5   
   -   5        $ itera��5      $
��Left=�6!   $��80��6<   $��
16,652,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��379��6�   $��Comic Sans MS)�6�   ���	#FF312C40���	#FF312C40$��1��6�   ��6�   Z� 6�   5      5      