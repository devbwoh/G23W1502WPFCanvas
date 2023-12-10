using System.ComponentModel;
using System.Windows;

namespace G23W1502WPFCanvas;
class CanvasViewModel : INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    private Point _zudah;
    public Point Zudah {
        get => _zudah;
        set {
            _zudah = value;
            OnPropertyChanged(nameof(Zudah));
        }
    }

    private Point _kampfer;
    public Point Kampfer {
        get => _kampfer;
        set {
            _kampfer= value;
            OnPropertyChanged(nameof(Kampfer));
        }
    }

    public CanvasViewModel() {
        _zudah = new Point(400, 200);
        _kampfer = new Point(100, 200);
    }

    //public void SetPos(Point p) {
    //    _zudah = p;
    //    OnPropertyChanged(nameof(Zudah));
    //}

    private void OnPropertyChanged(string name) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
