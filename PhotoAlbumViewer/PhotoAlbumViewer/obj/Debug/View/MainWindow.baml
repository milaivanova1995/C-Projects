   M S B A M L   `   `   `  ����H  DShowImageTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PhotoAlbumViewerPhotoAlbumViewer  5      !    PhotoAlbumViewer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;PhotoAlbumViewerclr-namespace:PhotoAlbumViewer     5        � Title$  
MainWindow��5       � WindowStartupLocation$ CenterScreen=�5   	   ��5   
   �� *&$SystemParameters.PrimaryScreenHeight+��5   	   �� *%#SystemParameters.PrimaryScreenWidth+ � 	Resources 5	      $   PhotoAlbumViewer.MainViewModel   MainViewModel��%   &	          5
   
   6)   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Photo Album Viewer��6    .��5      �� -   5         ��Name$ _image��5      $��Uniform=�6$   $��0,0,-2,0q�6S   ��66   �� *	ImagePath+6S   5      �� 5   
   $��50��6   $��1��6   $��Choose Photo��6*   $��300,0q�6f   ��6A   �� *LoadImageCommand+6f   �� 5   
   -   5         ��Name$ btnNext��5      $��0q�6"   #��[" �66   $��Right=�6q   $��Center=�6�   $��60��6�   $��50��6�   $��	0,0,180,0q�6�   $��1��6�    � ToolTip$ 
Next Photo��6  ��6�   �� *LoadNextImageCommand+.��5      �� $ ��/Resources/right_arrow.png��6   $
��Left=�68   $��35��6S   $%��-17.667,-17.667,-17.333,-17.333q�6_   $	��Top=�6�   $��35��6�   5      �� 5   
   -   5        $ btnPrevious��5      $��0q�6&   #��[" �6:   $
��Left=�6u   $��Center=�6�   $��60��6�   $��50��6�   $��	180,0,0,0q�6�   $��1��6  $ Previous Photo��6  ��6�   �� *LoadPreviousImageCommand+.��5      �� $��/Resources/left_arrow.png��6   $
��Left=�67   $��35��6R   $%��-17.667,-17.667,-17.333,-17.333q�6^   $	��Top=�6�   $��35��6�   5      5      5      