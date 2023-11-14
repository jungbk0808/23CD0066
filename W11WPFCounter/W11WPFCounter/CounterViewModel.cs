using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace W11WPFCounter
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private CounterModel _model;

        public CounterViewModel()
        { 
            _model = new CounterModel();
        }

        public int Value
        {
            get => _model.Count;
            set {
                _model.Count = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
