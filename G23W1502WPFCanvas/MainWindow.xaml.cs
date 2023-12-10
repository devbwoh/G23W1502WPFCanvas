using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace G23W1502WPFCanvas; 
public partial class MainWindow : Window {
    CanvasViewModel viewModel = new CanvasViewModel();

    private Boolean IsMoving = false;
    private Image? MovingImage = null;
    private Point Diff = new Point(0, 0);

    public MainWindow() {
        InitializeComponent();

        DataContext = viewModel;
    }

    private void OnMouseDown(object sender, MouseButtonEventArgs e) {
        MovingImage = (Image)sender;
        Diff = e.GetPosition(MovingImage);
        IsMoving = true;
    }
    private void OnMouseUp(object sender, MouseButtonEventArgs e) {
        MovingImage = null;
        IsMoving = false;
    }

    private void OnMouseMove(object sender, MouseEventArgs e) {
        if (!IsMoving)
            return;

        Point p = new Point(
                e.GetPosition(this).X + Center.RADIUS - Diff.X,
                e.GetPosition(this).Y + Center.RADIUS - Diff.Y);

        switch (MovingImage?.Name) {
            case "Zudah":
                viewModel.Zudah = p;
                break;
            case "Kampfer":
                viewModel.Kampfer = p;
                break;
            default:
                break;
        }
    }
}