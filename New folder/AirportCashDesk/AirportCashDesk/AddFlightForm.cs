using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportCashDesk
{
    public partial class AddFlightForm : Form
    {
        private Flight flight;

        public AddFlightForm()
        {
            InitializeComponent();
        }

        public AddFlightForm(Flight flight)
        {
            InitializeComponent();  // Ініціалізація компонентів форми
            this.flight = flight;
            bindSrcFlights();
        }

        private void bindSrcFlights()
        {
            txtFlightNumber.Text = flight.FlightNumber.ToString();
            txtRoute.Text = flight.Route;
            txtStops.Text = string.Join(",", flight.StopPoints);
            dtpDepartureTime.Value = flight.DepartureTime;
            nudAvailableSeats.Value = flight.AvailableSeats;

            foreach (DayOfWeek day in flight.FlightDays)
            {
                clbDays.SetItemChecked((int)day, true);
            }
        }

        private Dictionary<string, DayOfWeek> daysMap = new Dictionary<string, DayOfWeek>
    {
        { "Понеділок", DayOfWeek.Monday },
        { "Вівторок", DayOfWeek.Tuesday },
        { "Середа", DayOfWeek.Wednesday },
        { "Четвер", DayOfWeek.Thursday },
        { "П'ятниця", DayOfWeek.Friday },
        { "Субота", DayOfWeek.Saturday },
        { "Неділя", DayOfWeek.Sunday }
    };

        private void btnSave_Click(object sender, EventArgs e)
        {
            flight.FlightNumber = int.Parse(txtFlightNumber.Text);
            flight.Route = txtRoute.Text;
            flight.StopPoints = new List<string>(txtStops.Text.Split(','));
            flight.DepartureTime = dtpDepartureTime.Value;

            flight.FlightDays.Clear();
            foreach (var item in clbDays.CheckedItems)
            {
                string dayName = item.ToString();
                if (daysMap.ContainsKey(dayName))
                {
                    flight.FlightDays.Add(daysMap[dayName]);
                }
            }

            flight.AvailableSeats = (int)nudAvailableSeats.Value;

            this.DialogResult = DialogResult.OK;
        }

        private void AddFlightForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
