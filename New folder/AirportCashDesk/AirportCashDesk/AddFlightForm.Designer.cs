namespace AirportCashDesk
{
    partial class AddFlightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFlightNumber = new Label();
            lblRoute = new Label();
            lblStops = new Label();
            label1 = new Label();
            lblDays = new Label();
            lblAvailableSeats = new Label();
            txtStops = new TextBox();
            txtFlightNumber = new TextBox();
            txtRoute = new TextBox();
            dtpDepartureTime = new DateTimePicker();
            clbDays = new CheckedListBox();
            nudAvailableSeats = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            txtTicketPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudAvailableSeats).BeginInit();
            SuspendLayout();
            // 
            // lblFlightNumber
            // 
            lblFlightNumber.AutoSize = true;
            lblFlightNumber.Location = new Point(22, 21);
            lblFlightNumber.Name = "lblFlightNumber";
            lblFlightNumber.Size = new Size(117, 23);
            lblFlightNumber.TabIndex = 0;
            lblFlightNumber.Text = "Номер рейсу:";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(22, 102);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(87, 23);
            lblRoute.TabIndex = 1;
            lblRoute.Text = "Маршрут:";
            // 
            // lblStops
            // 
            lblStops.AutoSize = true;
            lblStops.Location = new Point(22, 196);
            lblStops.Name = "lblStops";
            lblStops.Size = new Size(226, 23);
            lblStops.TabIndex = 2;
            lblStops.Text = "Пункти проміжної посадки:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 299);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 3;
            label1.Text = "Час відправлення:";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(22, 407);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(108, 23);
            lblDays.TabIndex = 4;
            lblDays.Text = "Дні польоту:";
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.AutoSize = true;
            lblAvailableSeats.Location = new Point(22, 771);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(194, 23);
            lblAvailableSeats.TabIndex = 5;
            lblAvailableSeats.Text = "Кількість вільних місць:";
            // 
            // txtStops
            // 
            txtStops.Location = new Point(22, 240);
            txtStops.Name = "txtStops";
            txtStops.Size = new Size(260, 30);
            txtStops.TabIndex = 6;
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(22, 56);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(260, 30);
            txtFlightNumber.TabIndex = 7;
            // 
            // txtRoute
            // 
            txtRoute.Location = new Point(22, 140);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(260, 30);
            txtRoute.TabIndex = 8;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDepartureTime.Format = DateTimePickerFormat.Custom;
            dtpDepartureTime.Location = new Point(22, 347);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(260, 30);
            dtpDepartureTime.TabIndex = 9;
            // 
            // clbDays
            // 
            clbDays.FormattingEnabled = true;
            clbDays.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            clbDays.Location = new Point(22, 457);
            clbDays.Name = "clbDays";
            clbDays.Size = new Size(260, 179);
            clbDays.TabIndex = 10;
            // 
            // nudAvailableSeats
            // 
            nudAvailableSeats.Location = new Point(22, 814);
            nudAvailableSeats.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudAvailableSeats.Name = "nudAvailableSeats";
            nudAvailableSeats.Size = new Size(260, 30);
            nudAvailableSeats.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 869);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(165, 869);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 665);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 14;
            label2.Text = "Ціна квитка:";
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(22, 710);
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.Size = new Size(260, 30);
            txtTicketPrice.TabIndex = 15;
            // 
            // AddFlightForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 929);
            Controls.Add(txtTicketPrice);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nudAvailableSeats);
            Controls.Add(clbDays);
            Controls.Add(dtpDepartureTime);
            Controls.Add(txtRoute);
            Controls.Add(txtFlightNumber);
            Controls.Add(txtStops);
            Controls.Add(lblAvailableSeats);
            Controls.Add(lblDays);
            Controls.Add(label1);
            Controls.Add(lblStops);
            Controls.Add(lblRoute);
            Controls.Add(lblFlightNumber);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddFlightForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання рейсу";
            Load += AddFlightForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAvailableSeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFlightNumber;
        private Label lblRoute;
        private Label lblStops;
        private Label label1;
        private Label lblDays;
        private Label lblAvailableSeats;
        private TextBox txtStops;
        private TextBox txtFlightNumber;
        private TextBox txtRoute;
        private DateTimePicker dtpDepartureTime;
        private CheckedListBox clbDays;
        private NumericUpDown nudAvailableSeats;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private TextBox txtTicketPrice;
    }
}