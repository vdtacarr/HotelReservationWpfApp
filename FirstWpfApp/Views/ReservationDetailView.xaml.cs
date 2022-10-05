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

namespace FirstWpfApp.Views
{
    /// <summary>
    /// Interaction logic for ReservationDetailView.xaml
    /// </summary>
    public partial class ReservationDetailView : UserControl
    {
        public ReservationDetailView()
        {
            InitializeComponent();
        }

        private void RedRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(RedRectangle, RedRectangle, DragDropEffects.Move);
            }
        }
        private void Canvas_Drop(object sender, DragEventArgs e)
        {
            Point dropPosition = e.GetPosition(canvas);
            Canvas.SetLeft(RedRectangle, dropPosition.X);
            Canvas.SetTop(RedRectangle, dropPosition.Y);

        }
        private void Canvas_DragOver(object sender, DragEventArgs e)
        {
            Point dropPosition = e.GetPosition(canvas);
            Canvas.SetLeft(RedRectangle, dropPosition.X);
            Canvas.SetTop(RedRectangle, dropPosition.Y);

        }
    }
}
