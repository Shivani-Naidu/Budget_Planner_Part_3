   M S B A M L   `   `   `  ����Y  UST10084788_PROG6221_POE_PART_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:ST10084788_PROG6221_POE_PART_3ST10084788_PROG6221_POE_PART_3  5      0    *ST10084788_PROG6221_POE_PART_3.SavingsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:ST10084788_PROG6221_POE_PART_3     5        N� Title$  SavingsPage��5	       N� 
Background
 �iii�$	��730��60   $	��811��5
      .��5      � 
���   �$	��730��6   $	��811��5   	   .+�5   
   �� 
����d�$��14(�60   $
��Left=�6>   $��
83,111,0,0q�6Y   $
��Wrap=�6m   $y��sFill In The Details Below And We Will Calculate How Much You Should Be Saving Monthly To Reach Your Desired Amount.��6�   $	��Top=�6�   $	��330��6  �� 5   
   
����d�$��14(�60   $
��Left=�6?   $��
83,226,0,0q�6Z   $
��Wrap=�6n   $��Amount To Save:��6�   $	��Top=�6�   �� 5   
   
����d�$��14(�60   $
��Left=�6>   $��
83,301,0,0q�6Y   $
��Wrap=�6m   $��Number Of Years To Save:��6�   $	��Top=�6�    J� RenderTransformOrigin$ -0.247,-5.222&�6�   �� 5   
   
����d�$��14(�60   $
��Left=�6>   $��
83,373,0,0q�6Y   $
��Wrap=�6m   $��Interest Rate:��6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ TextBox1��5      $
��Left=�6$   $��322,227,0,0q�6?    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6T   �� *SavingsAmountSTR+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $ TextBox2��5      $
��Left=�6$   $��322,302,0,0q�6?   $
 Wrap=�6~   $	��Top=�6�   $	��150��6�   ��6T   �� *	YearSTR+$ TwoWay=�6�   �� 5   
   -   5        $ TextBox3��5      $
��Left=�6$   $��322,374,0,0q�6?   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6T   �� *SavingInterestSTR+$ TwoWay=�6�   �� 5   
   -   5        $
��Save��5      
���iii�$��14(�65   $
��Left=�6C   $��322,469,0,0q�6^   $	��Top=�6s   $	��141��6�   $��36��6�   6�   �� 5   
   -   5         ��Name$ Notify1��5   (   $y�Hidden=�6   $
��Left=�69   $��322,245,0,0q�6T   $
��Wrap=�6i   $��	TextBlock��6}   $	��Top=�6�   $	��244��6�   $��37��6�   �� 5    
   -   5        $ Notify2��5    )   $y�Hidden=�6   $
��Left=�6:   $��322,320,0,0q�6U   $
��Wrap=�6j   $��	TextBlock��6~   $	��Top=�6�   $	��244��6�   $��41��6�   �� 5!   
   -   5        $ Notify3��5!   )   $y�Hidden=�6   $
��Left=�6:   $��322,392,0,0q�6U   $
��Wrap=�6j   $��	TextBlock��6~   $	��Top=�6�   $	��236��6�   $��42��6�   �� 5"   
   -   5        $ Savings��5"   6   $y�Hidden=�6   $��14(�6(   
����d�$
��Left=�6e   $��322,536,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��264��6�   $	��107��6�   �� 5&   
   
���   �$��52,38,515,625q�6(   .+�5'      �� $��Icons/Savings.jpeg��6   $
��Fill=�5(      $��68��6#   $	��239��6/   $ 0.5,0.5&�6;   5*      5+      �� 5.   
   -	   5         ��Name$ ClearButton��5.   %   $y�Hidden=�6   $��14(�6:   
���iii�$��Clear��6]   $
��Left=�6m   $��
52,668,0,0q�6�   $	��Top=�6�   $	��112��6�   $��36��6�   6�   50      51      