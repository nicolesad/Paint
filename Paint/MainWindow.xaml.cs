using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace Paint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Checked(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void btnErase_Checked(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.EraseByStroke;

        }

        private void btnSelect_Checked(object sender, RoutedEventArgs e)
        {
            Canvas.EditingMode = InkCanvasEditingMode.Select;

        }
        private void SetBrushSize(object sender)
        {
            string text = ((ComboBox)sender).Text;
            if(text !="")
            {
                int.TryParse(text, out int size);

                BrushAtt.Width = size;
                BrushAtt.Height = size;
            }
        }

        private void cboBrushSize_SelectionChanged(object sender, EventArgs e)
        {
            SetBrushSize(sender);
        }
        private void cboBrushSize_DropDownClosed(object sender, EventArgs e)
        {
            SetBrushSize(sender);
        }
        private void Color_SelectedColorChanged(object sender, EventArgs e)
        {
            ColorPicker colorPicker = (ColorPicker)sender;
            if(colorPicker != null)
            {
                BrushAtt.Color = (Color)colorPicker.SelectedColor;
            }
        }
    }
}
