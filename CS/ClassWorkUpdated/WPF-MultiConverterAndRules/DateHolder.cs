using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MultiConverterAndRules
{
    public class DateHolder : INotifyPropertyChanged
    {
        private short _day;
        private short _month;
        private short _year;
        public short Day
        {
            get => _day;
            set
            {
                if (value < 0) { throw new ArgumentException("Negative value"); }
                SetProperty(ref _day, value, nameof(Day));
            }
        }
        public short Month
        {
            get => _month;
            set
            {
                if (value < 0) { throw new ArgumentException("Negative value"); }
                SetProperty(ref _month, value, nameof(Month));
            }
        }
        public short Year
        {
            get => _year;
            set
            {
                if (value < 0) { throw new ArgumentException("Negative value"); }
                SetProperty(ref _year, value, nameof(Year));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void SetProperty<T>(ref T field, T value, string name)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
        public DateHolder()
        {
            DateTime today = DateTime.Today;
            _day = (short)today.Day;
            _month = (short)today.Month;
            _year = (short)today.Year;
        }
    }
}
