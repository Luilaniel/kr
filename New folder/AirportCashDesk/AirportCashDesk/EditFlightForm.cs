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
    public partial class EditFlightForm : Form
    {
        private Flight flight;

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

        private Dictionary<DayOfWeek, string> reverseDaysMap;
        public EditFlightForm(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            reverseDaysMap = daysMap.ToDictionary(pair => pair.Value, pair => pair.Key);

            bindSrcFlights();
        }

        private void bindSrcFlights()
        {
            txtFlightNumber.Text = flight.FlightNumber.ToString();
            txtRoute.Text = flight.Route;
            txtStops.Text = string.Join(", ", flight.StopPoints);
            dtpDepartureTime.Value = flight.DepartureTime;
            nudAvailableSeats.Value = flight.AvailableSeats;

            // Позначаємо вибрані дні тижня
            foreach (var day in flight.FlightDays)
            {
                int index = clbDays.Items.IndexOf(reverseDaysMap[day]);
                if (index >= 0)
                {
                    clbDays.SetItemChecked(index, true);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Оновлення даних рейсу
                flight.FlightNumber = int.Parse(txtFlightNumber.Text);
                flight.Route = txtRoute.Text;
                flight.StopPoints = txtStops.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(stop => stop.Trim())
                                                  .ToList();
                flight.DepartureTime = dtpDepartureTime.Value;

                // Оновлення днів польотів
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
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditFlightForm_Load(object sender, EventArgs e)
        {

        }
    }
}
