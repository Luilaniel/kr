namespace AirportCashDesk
{
    partial class TicketInfoForm
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
            lblTicketInfo = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTicketInfo
            // 
            lblTicketInfo.AutoSize = true;
            lblTicketInfo.Location = new Point(35, 25);
            lblTicketInfo.Name = "lblTicketInfo";
            lblTicketInfo.Size = new Size(0, 20);
            lblTicketInfo.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 215);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Зберегти квиток";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // TicketInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 284);
            Controls.Add(btnSave);
            Controls.Add(lblTicketInfo);
            Name = "TicketInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Квиток";
            Load += TicketInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketInfo;
        private Button btnSave;
    }
}