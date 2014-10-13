﻿using System;
using System.Windows.Input;

namespace MarkdownEdit
{
    public partial class MainWindow
    {
        public static RoutedCommand UpdatePreviewCommand = new RoutedUICommand();
        public static RoutedCommand WordWrapCommand = new RoutedUICommand();
        public static RoutedCommand ToggleHelpCommand = new RoutedUICommand();
        public static RoutedCommand ScrollPreviewCommand = new RoutedUICommand();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExecuteUpdatePreview(object sender, ExecutedRoutedEventArgs ea)
        {
            ea.Handled = true;
            Preview.UpdatePreview(ea.Parameter as string);
        }

        private void ExecuteOpenFile(object sender, ExecutedRoutedEventArgs ea)
        {
            ea.Handled = true;
            Editor.OpenFileHandler();
        }

        public void ExecuteWordWrap(object sender, ExecutedRoutedEventArgs ea)
        {
            ea.Handled = true;
            Editor.WordWrapHandler();
        }

        public void ExecuteToggleHelp(object sender, ExecutedRoutedEventArgs ea)
        {
            ea.Handled = true;
            Editor.ToggleHelp();
        }

        public void ExecuteScrollPreview(object sender, ExecutedRoutedEventArgs ea)
        {
            ea.Handled = true;
            Preview.SetScrollOffset(Convert.ToInt32(ea.Parameter));
        }
    }
}