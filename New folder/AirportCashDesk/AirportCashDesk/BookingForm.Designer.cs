namespace AirportCashDesk
{
    partial class BookingForm
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
            txtTickets = new TextBox();
            chkExtraLuggage = new CheckBox();
            cmbClass = new ComboBox();
            rbtnCreditCard = new RadioButton();
            rbtnCash = new RadioButton();
            lblTickets = new Label();
            btnConfirm = new Button();
            btnCancelBooking = new Button();
            txtBuyerName = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // txtTickets
            // 
            txtTickets.Location = new Point(17, 118);
            txtTickets.Name = "txtTickets";
            txtTickets.Size = new Size(262, 27);
            txtTickets.TabIndex = 0;
            // 
            // chkExtraLuggage
            // 
            chkExtraLuggage.AutoSize = true;
            chkExtraLuggage.Location = new Point(17, 164);
            chkExtraLuggage.Name = "chkExtraLuggage";
            chkExtraLuggage.Size = new Size(160, 24);
            chkExtraLuggage.TabIndex = 1;
            chkExtraLuggage.Text = "Додатковий багаж";
            chkExtraLuggage.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "\"Економ\"", "\"Бізнес\"", "\"Перший\"" });
            cmbClass.Location = new Point(17, 206);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(262, 28);
            cmbClass.TabIndex = 2;
            // 
            // rbtnCreditCard
            // 
            rbtnCreditCard.AutoSize = true;
            rbtnCreditCard.Location = new Point(17, 249);
            rbtnCreditCard.Name = "rbtnCreditCard";
            rbtnCreditCard.Size = new Size(145, 24);
            rbtnCreditCard.TabIndex = 3;
            rbtnCreditCard.TabStop = true;
            rbtnCreditCard.Text = "Кредитна картка";
            rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(17, 280);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(79, 24);
            rbtnCash.TabIndex = 4;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Готівка";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(17, 95);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(126, 20);
            lblTickets.TabIndex = 5;
            lblTickets.Text = "Кількість квитків:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(17, 324);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 29);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Підтвердити";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Location = new Point(157, 324);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(122, 29);
            btnCancelBooking.TabIndex = 7;
            btnCancelBooking.Text = "Скасувати";
            btnCancelBooking.UseVisualStyleBackColor = true;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // txtBuyerName
            // 
            txtBuyerName.Location = new Point(17, 48);
            txtBuyerName.Name = "txtBuyerName";
            txtBuyerName.Size = new Size(262, 27);
            txtBuyerName.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(187, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Прізвище та ім'я покупця";
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 373);
            Controls.Add(lblName);
            Controls.Add(txtBuyerName);
            Controls.Add(btnCancelBooking);
            Controls.Add(btnConfirm);
            Controls.Add(lblTickets);
            Controls.Add(rbtnCash);
            Controls.Add(rbtnCreditCard);
            Controls.Add(cmbClass);
            Controls.Add(chkExtraLuggage);
            Controls.Add(txtTickets);
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформлення квитків";
            Load += BookingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTickets;
        private CheckBox chkExtraLuggage;
        private ComboBox cmbClass;
        private RadioButton rbtnCreditCard;
        private RadioButton rbtnCash;
        private Label lblTickets;
        private Button btnConfirm;
        private Button btnCancelBooking;
        private TextBox txtBuyerName;
        private Label lblName;
    }
}