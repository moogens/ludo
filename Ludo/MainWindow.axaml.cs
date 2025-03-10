using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Ludo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        for (int i = 0; i < 15; i++)
        {
            MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        }

        for (int row = 0; row < 15; row++) // 15 * 15 grid til brættet
        {
            for (int column = 0; column < 15; column++)
            {
                var tile = new Border // Border rundt om hver tile i brættet
                {
                    BorderBrush = Brushes.Black,
                    BorderThickness = new Thickness(1),
                };
                Grid.SetRow(tile, row);
                Grid.SetColumn(tile, column);
                MainGrid.Children.Add(tile);
            }
        }
        CreateColorTiles(0,6,0,6, new SolidColorBrush(Colors.Green));
        CreateColorTiles(0,6,9,6, new SolidColorBrush(Colors.Yellow));
        CreateColorTiles(9,6,0,6, new SolidColorBrush(Colors.Red));
        CreateColorTiles(9,6,9,6, new SolidColorBrush(Colors.Blue));
        CreateColorTiles(1,4,1,4, new SolidColorBrush(Colors.LightGray));
        CreateColorTiles(1,4,10,4, new SolidColorBrush(Colors.LightGray));
        CreateColorTiles(10,4,1,4, new SolidColorBrush(Colors.LightGray));
        CreateColorTiles(10,4,10,4, new SolidColorBrush(Colors.LightGray));
    }

    private void CreateColorTiles(int row, int rowspan, int col, int colspan, Brush color)
    {
        var border = new Border
        {
            Background = color,
        };
        Grid.SetRow(border, row);
        Grid.SetRowSpan(border, rowspan);
        Grid.SetColumn(border, col);
        Grid.SetColumnSpan(border, colspan);
        MainGrid.Children.Add(border);
    }
    
}