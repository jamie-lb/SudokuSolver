using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuSolverCSharp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void TextEntry_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox currentCell = (TextBox)sender;
            currentCell.SelectAll();
        }

        private void TextEntry_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentCell = (TextBox)sender;
            TextBox targetCell = new TextBox();
            int currentIndex = (int)currentCell.Tag;
            int targetIndex = -10;
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                SolvePuzzleButton.Command.Execute(null);
                ClearGrid.Focus();
            }
            if (e.Key == Key.Up)
            {
                e.Handled = true;
                targetIndex = currentIndex - 9;
            }
            if (e.Key == Key.Down)
            {
                e.Handled = true;
                targetIndex = currentIndex + 9;
            }
            if (e.Key == Key.Left)
            {
                e.Handled = true;
                targetIndex = currentIndex - 1;
            }
            if (e.Key == Key.Right)
            {
                e.Handled = true;
                targetIndex = currentIndex + 1;
            }
            if (targetIndex != -10)
            {
                if (targetIndex < 1) { targetIndex += 81;}
                if (targetIndex > 81) { targetIndex -= 81;}
                targetCell = (from control in MainGrid.Children.OfType<TextBox>() where control.GetType().Name.Equals(typeof(System.Windows.Controls.TextBox).Name) && ((int)control.Tag).Equals(targetIndex) select control).FirstOrDefault();
                if (targetCell != null) { targetCell.Focus(); }
            }
        }

        private void TextEntry_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            TextBox currentCell = (TextBox)sender;
            currentCell.FontSize = currentCell.ActualHeight / 1.8333333333333328;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.TextEntry1.Focus();
        }
    }
}
