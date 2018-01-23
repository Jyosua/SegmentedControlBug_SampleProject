using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp2
{
	public partial class MainPage : ContentPage
	{
        private ObservableCollection<Attendee> _attendees;

		public MainPage()
		{
			InitializeComponent();
            _attendees = new ObservableCollection<Attendee>() { new Attendee(0), new Attendee(1), new Attendee(2) };
            AttendeeList.ItemsSource = _attendees;
        }

        public void OnClick(object sender, EventArgs e)
        {
            foreach (var item in _attendees)
                item.Status = item.Status == 2 ? 0 : 2;
        }
    }
}
