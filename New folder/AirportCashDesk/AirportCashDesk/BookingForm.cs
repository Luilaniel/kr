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
    public partial class BookingForm : Form
    {
        private Flight currentFlight;

        public BookingForm() 
        {
            InitializeComponent();
        }

        public BookingForm(Flight flight)
        {
            InitializeComponent();
            this.currentFlight = flight;
        }

        public void SetFlightDetails(Flight flight)
        {
            currentFlight = flight;
        }
        public bool ExtraLuggage
        {
            get { return chkExtraLuggage.Checked; }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtTickets.Text.Trim(), out int ticketsCount) && ticketsCount > 0)
                {
                    string buyerName = txtBuyerName.Text.Trim();

                    if (string.IsNullOrEmpty(buyerName))
                    {
                        MessageBox.Show("Введіть ім'я покупця.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (ticketsCount <= currentFlight.AvailableSeats)
                    {
                        string classSelected = cmbClass.SelectedItem?.ToString() ?? "Не вибрано";
                        bool extraLuggage = chkExtraLuggage.Checked;
                        string paymentMethod = rbtnCreditCard.Checked ? "Кредитна картка" : "Готівка";

                        MessageBox.Show($"Бронювання підтверджено!\n" +
                                         $"Ім'я покупця: {buyerName}\n" +
                                         $"Кількість квитків: {ticketsCount}\n" +
                                         $"Клас: {classSelected}\n" +
                                         $"Додатковий багаж: {(extraLuggage ? "Так" : "Ні")}\n" +
                                         $"Спосіб оплати: {paymentMethod}\n", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        currentFlight.AvailableSeats -= ticketsCount;

                        MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                        if (mainForm != null)
                        {
                            mainForm.UpdateFlightList();  
                        }

                        TicketInfoForm ticketInfoForm = new TicketInfoForm(currentFlight, buyerName, ticketsCount, classSelected, extraLuggage, paymentMethod);
                        ticketInfoForm.ShowDialog();  

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Немає достатньо місць для бронювання.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введіть правильну кількість квитків.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час бронювання: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Бронювання скасовано. Кількість доступних місць: {currentFlight.AvailableSeats}",
                                "Скасування бронювання", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час скасування бронювання: {ex.Message}",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
