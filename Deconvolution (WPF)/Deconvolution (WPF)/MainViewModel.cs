using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DeconvolutionWPF
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        #region переменные сигнала
        private double _amp1Signal, _amp2Signal, _amp3Signal;
        private int _center1Signal, _center2Signal, _center3Signal;
        private double _disp1Signal, _disp2Signal, _disp3Signal;
        #endregion

        #region переменные импульсной характеристики
        private double _ampImpulse;
        private double _dispImpulse;
        #endregion

        #region прочие переменные
        private int _amount;

        #endregion

        #region свойства сигнала

        #region амплитуды
        public double Amplitude1Signal
        {
            get => _amp1Signal;
            set
            {
                _amp1Signal = value;
                OnPropertyChanged(nameof(Amplitude1Signal));
            }
        }
        public double Amplitude2Signal
        {
            get => _amp2Signal;
            set
            {
                _amp2Signal = value;
                OnPropertyChanged(nameof(Amplitude2Signal));
            }
        }

        public double Amplitude3Signal
        {
            get => _amp3Signal;
            set
            {
                _amp3Signal = value;
                OnPropertyChanged(nameof(Amplitude3Signal));
            }
        }
        #endregion

        #region центры
        public int Center1Signal
        {
            get => _center1Signal;
            set
            {
                _center1Signal = value;
                OnPropertyChanged(nameof(Center1Signal));
            }
        }
        public int Center2Signal
        {
            get => _center2Signal;
            set
            {
                _center2Signal = value;
                OnPropertyChanged(nameof(Center2Signal));
            }
        }
        public int Center3Signal
        {
            get => _center3Signal;
            set
            {
                _center3Signal = value;
                OnPropertyChanged(nameof(Center3Signal));
            }
        }
        #endregion

        #region дисперсии
        public double Disp1Signal
        {
            get => _disp1Signal;
            set
            {
                _disp1Signal = value;
                OnPropertyChanged(nameof(Disp1Signal));
            }
        }

        public double Disp2Signal
        {
            get => _disp2Signal;
            set
            {
                _disp2Signal = value;
                OnPropertyChanged(nameof(Disp1Signal));
            }
        }

        public double Disp3Signal
        {
            get => _disp3Signal;
            set
            {
                _disp3Signal = value;
                OnPropertyChanged(nameof(Disp3Signal));
            }
        }
        #endregion

        #endregion

        #region свойства импульсной характеристики
        public double AmplitudeImpulse
        {
            get => _ampImpulse;
            set
            {
                _ampImpulse = value;
                OnPropertyChanged(nameof(AmplitudeImpulse));
            }
        }
        public double DispImpulse
        {
            get => _dispImpulse;
            set
            {
                _dispImpulse = value;
                OnPropertyChanged(nameof(DispImpulse));
            }
        }
        #endregion
    }
}
