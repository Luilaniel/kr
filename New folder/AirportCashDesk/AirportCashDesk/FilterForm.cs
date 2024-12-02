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
    public partial class FilterForm : Form
    {
        public event EventHandler<FilterEventArgs> FilterApplied; // Подія для передачі фільтру

        public FilterForm()
        {
            InitializeComponent();
            // Припускаємо, що Places - це ComboBox
            Places.Items.AddRange(new string[]
            {
            "Львів", "Харків", "Київ", "Івано-Франківськ", "Ужгород", "Чернівці",
            "Луцьк", "Черкаси", "Суми", "Житомир", "Хмельницький", "Вінниця", "Донецьк"
            });
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            // Можна додатково ініціалізувати форму, якщо потрібно
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з комбобоксу Places
            string destination = Places.Text.Trim();

            // Перевіряємо, чи вибрано пункт призначення
            if (string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Будь ласка, виберіть пункт призначення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створюємо об'єкт для передачі фільтраційних даних
            FilterEventArgs args = new FilterEventArgs(destination);

            // Викликаємо подію для фільтрації
            FilterApplied?.Invoke(this, args);

            // Закриваємо форму після застосування фільтру
            this.Close();
        }

        // Кнопка для скасування фільтру
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Просто закриваємо форму
        }
    }
}
