using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace SampleApp2
{
    public class Attendee : INotifyPropertyChanged
    {
        public Attendee(int status)
        {
            Status = status;
        }

        private int _status;
        public int Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(StatusColor));
            }
        }

        public Color StatusColor
        {
            get
            {
                switch (Status)
                {
                    case 0:
                        return Color.Gray;
                    case 1:
                        return Color.Yellow;
                    case 2:
                        return Color.Green;
                    default:
                        return Color.Gray;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
