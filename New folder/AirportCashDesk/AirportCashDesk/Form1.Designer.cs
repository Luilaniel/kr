namespace AirportCashDesk
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip = new ToolStrip();
            btnAddFlight = new ToolStripButton();
            btnEditFlight = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDeleteFlight = new ToolStripButton();
            btnClearFlights = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnSaveText = new ToolStripButton();
            btnSaveBinary = new ToolStripButton();
            btnSaveXml = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnLoadText = new ToolStripButton();
            btnLoadBinary = new ToolStripButton();
            btnLoadXml = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnBookTickets = new ToolStripButton();
            btnFilter = new ToolStripButton();
            btnExit = new ToolStripButton();
            btnCheckAvailability = new ToolStripButton();
            dgvFlights = new DataGridView();
            bindSrcFlights = new BindingSource(components);
            comboBoxDays = new ComboBox();
            btnSortByPrice = new Button();
            btnSortByCity = new Button();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindSrcFlights).BeginInit();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnAddFlight, btnEditFlight, toolStripSeparator1, btnDeleteFlight, btnClearFlights, toolStripSeparator2, btnSaveText, btnSaveBinary, btnSaveXml, toolStripSeparator3, btnLoadText, btnLoadBinary, btnLoadXml, toolStripSeparator4, btnBookTickets, btnFilter, btnExit, btnCheckAvailability });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1323, 27);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip1";
            // 
            // btnAddFlight
            // 
            btnAddFlight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddFlight.Image = (Image)resources.GetObject("btnAddFlight.Image");
            btnAddFlight.ImageTransparentColor = Color.Magenta;
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(29, 24);
            btnAddFlight.Text = "Додати рейс";
            btnAddFlight.ToolTipText = "Додати новий рейс до таблиці\r\n";
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // btnEditFlight
            // 
            btnEditFlight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditFlight.Image = (Image)resources.GetObject("btnEditFlight.Image");
            btnEditFlight.ImageTransparentColor = Color.Magenta;
            btnEditFlight.Name = "btnEditFlight";
            btnEditFlight.Size = new Size(29, 24);
            btnEditFlight.Text = "Редагувати рейс";
            btnEditFlight.ToolTipText = "Редагувати вибраний рейс";
            btnEditFlight.Click += btnEditFlight_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnDeleteFlight
            // 
            btnDeleteFlight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteFlight.Image = (Image)resources.GetObject("btnDeleteFlight.Image");
            btnDeleteFlight.ImageTransparentColor = Color.Magenta;
            btnDeleteFlight.Name = "btnDeleteFlight";
            btnDeleteFlight.Size = new Size(29, 24);
            btnDeleteFlight.Text = "Видалити рейс";
            btnDeleteFlight.ToolTipText = "Видалити вибраний рейс";
            btnDeleteFlight.Click += btnDeleteFlight_Click;
            // 
            // btnClearFlights
            // 
            btnClearFlights.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClearFlights.Image = (Image)resources.GetObject("btnClearFlights.Image");
            btnClearFlights.ImageTransparentColor = Color.Magenta;
            btnClearFlights.Name = "btnClearFlights";
            btnClearFlights.Size = new Size(29, 24);
            btnClearFlights.Text = "Очистити таблицю";
            btnClearFlights.ToolTipText = "Видалити всі рейси з таблиці";
            btnClearFlights.Click += btnClearFlights_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnSaveText
            // 
            btnSaveText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveText.Image = (Image)resources.GetObject("btnSaveText.Image");
            btnSaveText.ImageTransparentColor = Color.Magenta;
            btnSaveText.Name = "btnSaveText";
            btnSaveText.Size = new Size(29, 24);
            btnSaveText.Text = "Зберегти як текст";
            btnSaveText.ToolTipText = "Зберегти дані таблиці у текстовому форматі\n";
            btnSaveText.Click += btnSaveText_Click;
            // 
            // btnSaveBinary
            // 
            btnSaveBinary.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveBinary.Image = (Image)resources.GetObject("btnSaveBinary.Image");
            btnSaveBinary.ImageTransparentColor = Color.Magenta;
            btnSaveBinary.Name = "btnSaveBinary";
            btnSaveBinary.Size = new Size(29, 24);
            btnSaveBinary.Text = "Зберегти як бінарний";
            btnSaveBinary.ToolTipText = "Зберегти дані таблиці у бінарному форматі";
            btnSaveBinary.Click += btnSaveBinary_Click;
            // 
            // btnSaveXml
            // 
            btnSaveXml.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSaveXml.Image = (Image)resources.GetObject("btnSaveXml.Image");
            btnSaveXml.ImageTransparentColor = Color.Magenta;
            btnSaveXml.Name = "btnSaveXml";
            btnSaveXml.Size = new Size(29, 24);
            btnSaveXml.Text = "Зберегти як XML";
            btnSaveXml.ToolTipText = "Зберегти дані таблиці у форматі XML";
            btnSaveXml.Click += btnSaveXml_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // btnLoadText
            // 
            btnLoadText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLoadText.Image = (Image)resources.GetObject("btnLoadText.Image");
            btnLoadText.ImageTransparentColor = Color.Magenta;
            btnLoadText.Name = "btnLoadText";
            btnLoadText.Size = new Size(29, 24);
            btnLoadText.Text = "Відкрити текстовий файл";
            btnLoadText.ToolTipText = "Завантажити дані таблиці з текстового файлу";
            btnLoadText.Click += btnLoadText_Click;
            // 
            // btnLoadBinary
            // 
            btnLoadBinary.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLoadBinary.Image = (Image)resources.GetObject("btnLoadBinary.Image");
            btnLoadBinary.ImageTransparentColor = Color.Magenta;
            btnLoadBinary.Name = "btnLoadBinary";
            btnLoadBinary.Size = new Size(29, 24);
            btnLoadBinary.Text = "Відкрити бінарний файл";
            btnLoadBinary.ToolTipText = "Завантажити дані таблиці з бінарного файлу";
            btnLoadBinary.Click += btnLoadBinary_Click;
            // 
            // btnLoadXml
            // 
            btnLoadXml.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLoadXml.Image = (Image)resources.GetObject("btnLoadXml.Image");
            btnLoadXml.ImageTransparentColor = Color.Magenta;
            btnLoadXml.Name = "btnLoadXml";
            btnLoadXml.Size = new Size(29, 24);
            btnLoadXml.Text = "Відкрити XML файл";
            btnLoadXml.ToolTipText = "Завантажити дані таблиці з XML файлу";
            btnLoadXml.Click += btnLoadXml_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // btnBookTickets
            // 
            btnBookTickets.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBookTickets.Image = (Image)resources.GetObject("btnBookTickets.Image");
            btnBookTickets.ImageTransparentColor = Color.Magenta;
            btnBookTickets.Name = "btnBookTickets";
            btnBookTickets.Size = new Size(29, 24);
            btnBookTickets.Text = "Оформити квитки";
            btnBookTickets.ToolTipText = "Відкрити форму для оформлення квитків";
            btnBookTickets.Click += btnBookTickets_Click;
            // 
            // btnFilter
            // 
            btnFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.ImageTransparentColor = Color.Magenta;
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(29, 24);
            btnFilter.Text = "Пошук найближчого рейсу";
            btnFilter.Click += btnFilter_Click;
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 24);
            btnExit.Text = "Вихід";
            btnExit.ToolTipText = "Закрити програму";
            btnExit.Click += btnExit_Click;
            // 
            // btnCheckAvailability
            // 
            btnCheckAvailability.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCheckAvailability.Image = (Image)resources.GetObject("btnCheckAvailability.Image");
            btnCheckAvailability.ImageTransparentColor = Color.Magenta;
            btnCheckAvailability.Name = "btnCheckAvailability";
            btnCheckAvailability.Size = new Size(29, 24);
            btnCheckAvailability.Text = "Перевірка доступності рейсу";
            btnCheckAvailability.Click += btnCheckAvailability_Click_1;
            // 
            // dgvFlights
            // 
            dgvFlights.AllowUserToAddRows = false;
            dgvFlights.AllowUserToDeleteRows = false;
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Dock = DockStyle.Left;
            dgvFlights.Location = new Point(0, 27);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.ReadOnly = true;
            dgvFlights.RowHeadersWidth = 51;
            dgvFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFlights.Size = new Size(1093, 609);
            dgvFlights.TabIndex = 1;
            // 
            // comboBoxDays
            // 
            comboBoxDays.FormattingEnabled = true;
            comboBoxDays.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота ", "Неділя" });
            comboBoxDays.Location = new Point(1111, 27);
            comboBoxDays.Name = "comboBoxDays";
            comboBoxDays.Size = new Size(200, 31);
            comboBoxDays.TabIndex = 2;
            // 
            // btnSortByPrice
            // 
            btnSortByPrice.Location = new Point(1111, 79);
            btnSortByPrice.Name = "btnSortByPrice";
            btnSortByPrice.Size = new Size(200, 57);
            btnSortByPrice.TabIndex = 3;
            btnSortByPrice.Text = "Сортувати за ціною";
            btnSortByPrice.UseVisualStyleBackColor = true;
            btnSortByPrice.Click += btnSortByPrice_Click;
            // 
            // btnSortByCity
            // 
            btnSortByCity.Location = new Point(1111, 153);
            btnSortByCity.Name = "btnSortByCity";
            btnSortByCity.Size = new Size(200, 57);
            btnSortByCity.TabIndex = 4;
            btnSortByCity.Text = "Сортувати за найближчим містом";
            btnSortByCity.UseVisualStyleBackColor = true;
            btnSortByCity.Click += btnSortByCity_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1323, 636);
            Controls.Add(btnSortByCity);
            Controls.Add(btnSortByPrice);
            Controls.Add(comboBoxDays);
            Controls.Add(dgvFlights);
            Controls.Add(toolStrip);
            Font = new Font("Segoe UI", 10F);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каса аеропорту";
            Load += MainForm_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindSrcFlights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private DataGridView dgvFlights;
        private ToolStripButton btnAddFlight;
        private ToolStripButton btnEditFlight;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDeleteFlight;
        private ToolStripButton btnClearFlights;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnSaveText;
        private ToolStripButton btnSaveBinary;
        private ToolStripButton btnSaveXml;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnLoadText;
        private ToolStripButton btnLoadBinary;
        private ToolStripButton btnLoadXml;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnExit;
        private ToolStripButton btnBookTickets;
        private BindingSource bindSrcFlights;
        private ToolStripButton btnFilter;
        private ToolStripButton btnCheckAvailability;
        private ComboBox comboBoxDays;
        private Button btnSortByPrice;
        private Button btnSortByCity;
    }
}
