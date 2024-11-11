using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace G24W11WPFCounter;

public class CounterViewModel : INotifyPropertyChanged
{
    private CounterModel _model;

    public CounterViewModel() {
        _model = new CounterModel();
    }

    public int Value
    {
        get => _model.Count;
        set
        {
            _model.Count = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
