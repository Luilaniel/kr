namespace AirportCashDesk
{
    partial class EditFlightForm
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
            btnCancel = new Button();
            btnSave = new Button();
            nudAvailableSeats = new NumericUpDown();
            clbDays = new CheckedListBox();
            dtpDepartureTime = new DateTimePicker();
            txtRoute = new TextBox();
            txtFlightNumber = new TextBox();
            txtStops = new TextBox();
            lblAvailableSeats = new Label();
            lblDays = new Label();
            label1 = new Label();
            lblStops = new Label();
            lblRoute = new Label();
            lblFlightNumber = new Label();
            txtTicketPrice = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAvailableSeats).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(166, 837);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 837);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudAvailableSeats
            // 
            nudAvailableSeats.Location = new Point(23, 782);
            nudAvailableSeats.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudAvailableSeats.Name = "nudAvailableSeats";
            nudAvailableSeats.Size = new Size(260, 30);
            nudAvailableSeats.TabIndex = 25;
            // 
            // clbDays
            // 
            clbDays.FormattingEnabled = true;
            clbDays.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            clbDays.Location = new Point(23, 457);
            clbDays.Name = "clbDays";
            clbDays.Size = new Size(260, 179);
            clbDays.TabIndex = 24;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDepartureTime.Format = DateTimePickerFormat.Custom;
            dtpDepartureTime.Location = new Point(23, 347);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(260, 30);
            dtpDepartureTime.TabIndex = 23;
            // 
            // txtRoute
            // 
            txtRoute.Location = new Point(23, 140);
            txtRoute.Name = "txtRoute";
            txtRoute.Size = new Size(260, 30);
            txtRoute.TabIndex = 22;
            // 
            // txtFlightNumber
            // 
            txtFlightNumber.Location = new Point(23, 56);
            txtFlightNumber.Name = "txtFlightNumber";
            txtFlightNumber.Size = new Size(260, 30);
            txtFlightNumber.TabIndex = 21;
            // 
            // txtStops
            // 
            txtStops.Location = new Point(23, 240);
            txtStops.Name = "txtStops";
            txtStops.Size = new Size(260, 30);
            txtStops.TabIndex = 20;
            // 
            // lblAvailableSeats
            // 
            lblAvailableSeats.AutoSize = true;
            lblAvailableSeats.Location = new Point(23, 739);
            lblAvailableSeats.Name = "lblAvailableSeats";
            lblAvailableSeats.Size = new Size(194, 23);
            lblAvailableSeats.TabIndex = 19;
            lblAvailableSeats.Text = "Кількість вільних місць:";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(23, 407);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(108, 23);
            lblDays.TabIndex = 18;
            lblDays.Text = "Дні польоту:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 299);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 17;
            label1.Text = "Час відправлення:";
            // 
            // lblStops
            // 
            lblStops.AutoSize = true;
            lblStops.Location = new Point(23, 196);
            lblStops.Name = "lblStops";
            lblStops.Size = new Size(226, 23);
            lblStops.TabIndex = 16;
            lblStops.Text = "Пункти проміжної посадки:";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(23, 102);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(87, 23);
            lblRoute.TabIndex = 15;
            lblRoute.Text = "Маршрут:";
            // 
            // lblFlightNumber
            // 
            lblFlightNumber.AutoSize = true;
            lblFlightNumber.Location = new Point(23, 21);
            lblFlightNumber.Name = "lblFlightNumber";
            lblFlightNumber.Size = new Size(117, 23);
            lblFlightNumber.TabIndex = 14;
            lblFlightNumber.Text = "Номер рейсу:";
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(23, 691);
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.Size = new Size(260, 30);
            txtTicketPrice.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 651);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 28;
            label2.Text = "Ціна квитка:";
            // 
            // EditFlightForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 878);
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
            Name = "EditFlightForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редагування рейсу";
            Load += EditFlightForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAvailableSeats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown nudAvailableSeats;
        private CheckedListBox clbDays;
        private DateTimePicker dtpDepartureTime;
        private TextBox txtRoute;
        private TextBox txtFlightNumber;
        private TextBox txtStops;
        private Label lblAvailableSeats;
        private Label lblDays;
        private Label label1;
        private Label lblStops;
        private Label lblRoute;
        private Label lblFlightNumber;
        private TextBox txtTicketPrice;
        private Label label2;
    }
}