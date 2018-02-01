using ChessViewer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChessViewer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        public Board Board { get; set; }
        public readonly int SQUARE_SIZE = (int)Application.Current.MainPage.Width / 8;
        public readonly double BOARD_SIZE = (int)Application.Current.MainPage.Width;

        public GamePage()
        {
            InitializeComponent();
            DrawBoard();
        }

        public void DrawBoard()
        {
            var grid = new Grid()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                RowSpacing = 0,
                ColumnSpacing = 0
            };

            for (int i = 0; i < 8; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            }

            for (int i = 0; i < 8; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }

            for (int i=0; i<8; i++)
            {
                for (int j=0; j<8; j++)
                {
                    BoxView square = new BoxView()
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    };
                    if (i % 2 == j % 2)
                        square.BackgroundColor = Color.Sienna; //black
                    else
                        square.BackgroundColor = Color.Beige;  //white
                    grid.Children.Add(square, i, j);
                }
            }
            gridContainer.Children.Add(grid);
        }
    }

}