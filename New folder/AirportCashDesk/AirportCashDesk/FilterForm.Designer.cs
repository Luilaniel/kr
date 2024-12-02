namespace AirportCashDesk
{
    partial class FilterForm
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
            label1 = new Label();
            btnApplyFilter = new Button();
            btnCancel = new Button();
            Places = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть пункт призначення:";
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(27, 126);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(202, 29);
            btnApplyFilter.TabIndex = 3;
            btnApplyFilter.Text = "Зберегти";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(27, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(202, 29);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Places
            // 
            Places.FormattingEnabled = true;
            Places.Items.AddRange(new object[] { "Львів", "Харків", "Київ", "Івано-Франківськ", "Ужгород", "Чернівці", "Луцьк", "Черкаси", "Суми", "Житомир", "Хмельницький", "Вінниця", "Донецьк" });
            Places.Location = new Point(27, 72);
            Places.Name = "Places";
            Places.Size = new Size(202, 28);
            Places.TabIndex = 5;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 256);
            Controls.Add(Places);
            Controls.Add(btnCancel);
            Controls.Add(btnApplyFilter);
            Controls.Add(label1);
            Name = "FilterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пошук рейсу";
            Load += FilterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnApplyFilter;
        private Button btnCancel;
        private ComboBox Places;
    }
}