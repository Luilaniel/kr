using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.ComponentModel;

namespace AirportCashDesk
{
    public partial class MainForm : Form
    {
        private List<Flight> flights = new List<Flight>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                comboBoxDays.Items.Add(day);
            }

            dgvFlights.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FlightNumber";
            column.Name = "Flight Number";
            column.HeaderText = "Номер рейсу";
            dgvFlights.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Route";
            column.Name = "Route";
            column.HeaderText = "Маршрут";
            dgvFlights.Columns.Add(column);

            DataGridViewTextBoxColumn stopPointsColumn = new DataGridViewTextBoxColumn();
            stopPointsColumn.DataPropertyName = "StopPointsString";
            stopPointsColumn.HeaderText = "Зупинки";
            dgvFlights.Columns.Add(stopPointsColumn);

            DataGridViewTextBoxColumn flightDaysColumn = new DataGridViewTextBoxColumn();
            flightDaysColumn.DataPropertyName = "FlightDaysString";
            flightDaysColumn.HeaderText = "Дні відправлення";
            dgvFlights.Columns.Add(flightDaysColumn);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DepartureTime";
            column.Name = "Departure Time";
            column.HeaderText = "Час відправлення";
            dgvFlights.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "AvailableSeats";
            column.Name = "Available Seats";
            column.HeaderText = "Вільні місця";
            dgvFlights.Columns.Add(column);

            dgvFlights.DataSource = bindSrcFlights;

            bindSrcFlights.Add(new Flight(101, "Київ - Львів", new List<string> { "Київ", "Львів" }, DateTime.Now, new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday }, 50, 1200.50));
            bindSrcFlights.Add(new Flight(102, "Одеса - Харків", new List<string> { "Одеса", "Харків" }, DateTime.Now.AddHours(3), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Thursday }, 60, 1500.00));
            bindSrcFlights.Add(new Flight(103, "Дніпро - Львів", new List<string> { "Дніпро", "Львів" }, DateTime.Now.AddDays(1), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }, 55, 1100.75));
            bindSrcFlights.Add(new Flight(104, "Запоріжжя - Київ", new List<string> { "Запоріжжя", "Київ" }, DateTime.Now.AddHours(5), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Sunday }, 70, 1100.75));
            bindSrcFlights.Add(new Flight(105, "Херсон - Івано-Франківськ", new List<string> { "Херсон", "Івано-Франківськ" }, DateTime.Now.AddHours(8), new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Sunday }, 65, 1100.75));
            bindSrcFlights.Add(new Flight(106, "Вінниця - Ужгород", new List<string> { "Вінниця", "Ужгород" }, DateTime.Now.AddDays(2), new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 80, 1100.75));
            bindSrcFlights.Add(new Flight(107, "Полтава - Чернівці", new List<string> { "Полтава", "Чернівці" }, DateTime.Now.AddHours(6), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }, 45, 1100.75));
            bindSrcFlights.Add(new Flight(108, "Рівне - Луцьк", new List<string> { "Рівне", "Луцьк" }, DateTime.Now.AddHours(4), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }, 30, 1100.75));
            bindSrcFlights.Add(new Flight(109, "Кривий Ріг - Черкаси", new List<string> { "Кривий Ріг", "Черкаси" }, DateTime.Now.AddHours(7), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Thursday }, 50, 1100.75));
            bindSrcFlights.Add(new Flight(110, "Миколаїв - Суми", new List<string> { "Миколаїв", "Суми" }, DateTime.Now.AddDays(1).AddHours(2), new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Sunday }, 75, 1100.75));
            bindSrcFlights.Add(new Flight(111, "Тернопіль - Житомир", new List<string> { "Тернопіль", "Житомир" }, DateTime.Now.AddHours(9), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Saturday }, 40, 1100.75));
            bindSrcFlights.Add(new Flight(112, "Чернігів - Хмельницький", new List<string> { "Чернігів", "Хмельницький" }, DateTime.Now.AddDays(2).AddHours(3), new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Sunday }, 65, 1100.75));
            bindSrcFlights.Add(new Flight(113, "Луцьк - Івано-Франківськ", new List<string> { "Луцьк", "Івано-Франківськ" }, DateTime.Now.AddHours(3), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Saturday }, 55, 1100.75));
            bindSrcFlights.Add(new Flight(114, "Одеса - Вінниця", new List<string> { "Одеса", "Вінниця" }, DateTime.Now.AddDays(1), new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday }, 60, 1100.75));
            bindSrcFlights.Add(new Flight(115, "Львів - Черкаси", new List<string> { "Львів", "Черкаси" }, DateTime.Now.AddHours(5), new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Thursday }, 70, 1100.75));
            bindSrcFlights.Add(new Flight(116, "Харків - Донецьк", new List<string> { "Харків", "Донецьк" }, DateTime.Now.AddDays(3), new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Sunday }, 80, 1100.75));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight(0, "", new List<string>(), DateTime.Now, new List<DayOfWeek>(), 0, 0.0);

            // Відкриваємо форму для додавання рейсу
            AddFlightForm ft = new AddFlightForm(flight);

            // Якщо користувач натиснув OK, додаємо рейс до джерела даних
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcFlights.Add(flight);
            }
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            Flight selectedFlight = (Flight)bindSrcFlights.List[bindSrcFlights.Position];
            EditFlightForm editForm = new EditFlightForm(selectedFlight);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                bindSrcFlights.List[bindSrcFlights.Position] = selectedFlight;
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити обраний рейс?", "Видалити рейс", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcFlights.RemoveCurrent();
            }
        }

        private void btnClearFlights_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви дійсно хочете очистити таблицю? Усі дані будуть втрачені!",
                                  "Підтвердження очищення",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bindSrcFlights.Clear();
                    dgvFlights.DataSource = bindSrcFlights;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при очищенні таблиці: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*",
                Title = "Зберегти дані у текстовий файл",
                InitialDirectory = Application.StartupPath
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Flight flight in bindSrcFlights.List)
                        {
                            string stopPoints = string.Join(",", flight.StopPoints);
                            string flightDays = string.Join(",", flight.FlightDays);

                            sw.WriteLine($"{flight.FlightNumber}|{flight.Route}|{stopPoints}|{flight.DepartureTime:yyyy-MM-dd HH:mm}|{flightDays}|{flight.AvailableSeats}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час збереження: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSaveBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Бінарні файли (*.bin)|*.bin|Усі файли (*.*)|*.*",
                Title = "Зберегти дані у бінарному форматі",
                InitialDirectory = Application.StartupPath
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BinaryWriter bw = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                    {
                        foreach (Flight flight in bindSrcFlights.List)
                        {
                            // Записуємо основні властивості рейсу
                            bw.Write(flight.FlightNumber);
                            bw.Write(flight.Route);

                            // Записуємо зупинки
                            bw.Write(flight.StopPoints.Count); // Кількість зупинок
                            foreach (var stop in flight.StopPoints)
                            {
                                bw.Write(stop); // Кожна зупинка
                            }

                            // Записуємо дату та час відправлення
                            bw.Write(flight.DepartureTime.ToBinary());

                            // Записуємо дні польотів
                            bw.Write(flight.FlightDays.Count); // Кількість днів
                            foreach (var day in flight.FlightDays)
                            {
                                bw.Write((int)day); // Кожен день
                            }

                            // Записуємо кількість доступних місць
                            bw.Write(flight.AvailableSeats);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час збереження файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML файли (*.xml)|*.xml|Усі файли (*.*)|*.*",
                Title = "Зберегти дані у форматі XML",
                InitialDirectory = Application.StartupPath
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XmlWriter writer = XmlWriter.Create(saveFileDialog.FileName, new XmlWriterSettings { Indent = true }))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Flights"); // Кореневий елемент

                        foreach (Flight flight in bindSrcFlights.List)
                        {
                            writer.WriteStartElement("Flight");

                            writer.WriteElementString("FlightNumber", flight.FlightNumber.ToString());
                            writer.WriteElementString("Route", flight.Route);
                            writer.WriteElementString("StopPoints", string.Join(",", flight.StopPoints));
                            writer.WriteElementString("DepartureTime", flight.DepartureTime.ToString("o")); // ISO формат
                            writer.WriteElementString("FlightDays", string.Join(",", flight.FlightDays));
                            writer.WriteElementString("AvailableSeats", flight.AvailableSeats.ToString());

                            writer.WriteEndElement(); // Закриваємо Flight
                        }

                        writer.WriteEndElement(); // Закриваємо Flights
                        writer.WriteEndDocument();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час збереження файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*",
                Title = "Відкрити текстовий файл",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        bindSrcFlights.Clear();

                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            string[] parts = line.Split('|');
                            if (parts.Length != 7) // Очікуємо 7 полів
                                throw new Exception("Формат файлу некоректний.");

                            int flightNumber = int.Parse(parts[0]);
                            string route = parts[1];
                            List<string> stopPoints = parts[2].Split(',').Select(p => p.Trim()).ToList();
                            DateTime departureTime = DateTime.Parse(parts[3]);
                            List<DayOfWeek> flightDays = parts[4].Split(',')
                                                                .Select(day => (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day))
                                                                .ToList();
                            int availableSeats = int.Parse(parts[5]);
                            double ticketPrice = double.Parse(parts[6]); // Додаємо ціну квитка

                            Flight flight = new Flight(flightNumber, route, stopPoints, departureTime, flightDays, availableSeats, ticketPrice);
                            bindSrcFlights.Add(flight);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час відкриття файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Бінарні файли (*.bin)|*.bin|Усі файли (*.*)|*.*",
                Title = "Відкрити бінарний файл",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BinaryReader br = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open)))
                    {
                        bindSrcFlights.Clear();

                        while (br.BaseStream.Position != br.BaseStream.Length)
                        {
                            int flightNumber = br.ReadInt32();
                            string route = br.ReadString();

                            // Читаємо кількість зупинок і самі зупинки
                            int stopCount = br.ReadInt32();
                            List<string> stopPoints = new List<string>();
                            for (int i = 0; i < stopCount; i++)
                            {
                                stopPoints.Add(br.ReadString());
                            }

                            // Читаємо час відправлення
                            DateTime departureTime = DateTime.FromBinary(br.ReadInt64());

                            // Читаємо дні відправлення
                            int daysCount = br.ReadInt32();
                            List<DayOfWeek> flightDays = new List<DayOfWeek>();
                            for (int i = 0; i < daysCount; i++)
                            {
                                flightDays.Add((DayOfWeek)br.ReadInt32());
                            }

                            // Читаємо кількість доступних місць
                            int availableSeats = br.ReadInt32();

                            // Читаємо ціну квитка
                            double ticketPrice = br.ReadDouble();

                            // Створюємо об'єкт Flight
                            Flight flight = new Flight(flightNumber, route, stopPoints, departureTime, flightDays, availableSeats, ticketPrice);
                            bindSrcFlights.Add(flight);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час відкриття файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML файли (*.xml)|*.xml|Усі файли (*.*)|*.*",
                Title = "Відкрити файл XML",
                InitialDirectory = Application.StartupPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var flights = new List<Flight>();

                    using (XmlReader reader = XmlReader.Create(openFileDialog.FileName))
                    {
                        Flight flight = null;

                        while (reader.Read())
                        {
                            if (reader.IsStartElement())
                            {
                                switch (reader.Name)
                                {
                                    case "Flight":
                                        flight = new Flight(0, "", new List<string>(), DateTime.Now, new List<DayOfWeek>(), 0, 0.0);
                                        break;
                                    case "FlightNumber":
                                        flight.FlightNumber = reader.ReadElementContentAsInt();
                                        break;
                                    case "Route":
                                        flight.Route = reader.ReadElementContentAsString();
                                        break;
                                    case "StopPoints":
                                        flight.StopPoints = reader.ReadElementContentAsString()
                                            .Split(',')
                                            .Select(s => s.Trim())
                                            .ToList();
                                        break;
                                    case "DepartureTime":
                                        flight.DepartureTime = DateTime.Parse(reader.ReadElementContentAsString());
                                        break;
                                    case "FlightDays":
                                        flight.FlightDays = reader.ReadElementContentAsString()
                                            .Split(',')
                                            .Select(day => Enum.TryParse(day, out DayOfWeek parsedDay) ? parsedDay : (DayOfWeek?)null)
                                            .Where(d => d.HasValue)
                                            .Select(d => d.Value)
                                            .ToList();
                                        break;
                                    case "AvailableSeats":
                                        flight.AvailableSeats = reader.ReadElementContentAsInt();
                                        break;
                                    case "TicketPrice":
                                        flight.TicketPrice = reader.ReadElementContentAsDouble();
                                        break;
                                }
                            }
                            else if (reader.Name == "Flight" && reader.NodeType == XmlNodeType.EndElement && flight != null)
                            {
                                flights.Add(flight);
                                flight = null;
                            }
                        }
                    }

                    bindSrcFlights.Clear();
                    foreach (var flight in flights)
                    {
                        bindSrcFlights.Add(flight);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час відкриття файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
               "Ви дійсно хочете вийти з програми?",
               "Вихід з програми",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBookTickets_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();

            if (dgvFlights.CurrentRow != null)
            {
                Flight selectedFlight = (Flight)dgvFlights.CurrentRow.DataBoundItem;
                bookingForm.SetFlightDetails(selectedFlight);
            }

            bookingForm.ShowDialog();
        }

        public void UpdateFlightList()
        {
            bindSrcFlights.ResetBindings(false);
            dgvFlights.Refresh();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            filterForm.FilterApplied += FilterForm_FilterApplied;
            filterForm.ShowDialog();
        }

        private void FilterForm_FilterApplied(object sender, FilterEventArgs e)
        {
            if (bindSrcFlights is List<Flight>)
            {
                List<Flight> filteredFlights = new List<Flight>();

                foreach (Flight flight in bindSrcFlights)
                {
                    if (flight.Route != null && flight.Route.Contains(e.Destination) &&
                        flight.DepartureTime.Date == e.Date.Date)
                    {
                        filteredFlights.Add(flight);
                    }
                }

                dgvFlights.DataSource = new BindingList<Flight>(filteredFlights);
            }
            else
            {
                MessageBox.Show("Невірний тип даних для списку рейсів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FilterApplied_Handler(object sender, FilterEventArgs e)
        {
            string destination = e.Destination;

            // Знайти найближчий рейс на обране місто з комбобоксу
            var filteredFlights = flights.Where(f => f.Route.Contains(destination) && f.AvailableSeats > 0)
                                         .OrderBy(f => f.DepartureTime)
                                         .ToList();

            if (filteredFlights.Any())
            {
                var closestFlight = filteredFlights.First();
                MessageBox.Show($"Найближчий рейс: {closestFlight.FlightNumber}, {closestFlight.Route}, {closestFlight.DepartureTime}", "Рейс знайдений");
            }
            else
            {
                MessageBox.Show("Немає доступних рейсів для обраного міста", "Помилка");
            }
        }

        private void btnCheckAvailability_Click_1(object sender, EventArgs e)
        {
            if (comboBoxDays.SelectedItem != null)
            {
                // Вибір дня з ComboBox (рядок, наприклад "Понеділок")
                string selectedDayString = comboBoxDays.SelectedItem.ToString();

                // Спробуємо перетворити рядок на відповідний день з DayOfWeek
                DayOfWeek selectedDay;

                // Переведення українських назв днів на англійські відповідники
                Dictionary<string, DayOfWeek> dayMappings = new Dictionary<string, DayOfWeek>
        {
            { "Понеділок", DayOfWeek.Monday },
            { "Вівторок", DayOfWeek.Tuesday },
            { "Середа", DayOfWeek.Wednesday },
            { "Четвер", DayOfWeek.Thursday },
            { "П'ятниця", DayOfWeek.Friday },
            { "Субота", DayOfWeek.Saturday },
            { "Неділя", DayOfWeek.Sunday }
        };

                if (dayMappings.TryGetValue(selectedDayString, out selectedDay))
                {
                    // Створення екземпляра рейсу
                    Flight flight = new Flight(
                        101,                             // Номер рейсу
                        "Київ - Львів",                  // Маршрут
                        new List<string> { "Київ", "Львів" },  // Зупинки
                        DateTime.Now,                    // Час відправлення
                        new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday }, // Дні рейсу
                        50, 1234                               // Кількість вільних місць
                    );

                    // Перевірка, чи рейс доступний в обраний день
                    bool isAvailable = flight.IsFlightAvailableOnDay(selectedDay);

                    // Виведення результату в MessageBox
                    MessageBox.Show(isAvailable ? "Рейс доступний на цей день." : "Рейс не доступний на цей день.");
                }
                else
                {
                    MessageBox.Show("Некоректний день. Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть день.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            DomesticFlight defaultFlight = new DomesticFlight();

            // Створення внутрішнього рейсу з параметрами
            DomesticFlight specificFlight = new DomesticFlight(
                101,
                "Київ - Львів",
                new List<string> { "Київ", "Львів" },
                DateTime.Now,
                new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday },
                50,
                1200.50,
                "Україна"
            );

            // Відображення інформації про обидва рейси
            defaultFlight.DisplayInfo();
            specificFlight.DisplayInfo();
        }

        private void btnSortByCity_Click(object sender, EventArgs e)
        {
            ICustomFlightInfo flightInfo = new Flight(
            1234, // Номер рейсу
            "Kyiv -> Lviv", // Маршрут
            new List<string> { "Kyiv", "Lviv" }, // Зупинки
            DateTime.Now, // Час відправлення
            new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday }, // Дні рейсу
            100, // Доступні місця
            500 // Ціна квитка
        );

            // Виклик методу GetDetailedInfo для виведення інформації
            MessageBox.Show(flightInfo.GetDetailedInfo(), "Детальна інформація про рейс");
        }
    }
}
                 