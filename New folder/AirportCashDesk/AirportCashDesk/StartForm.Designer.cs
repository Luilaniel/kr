namespace AirportCashDesk
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            btnOpen = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(86, 191);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(193, 29);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Відкрити програму";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(87, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Вийти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 492);
            Controls.Add(btnExit);
            Controls.Add(btnOpen);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Початкове вікно";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnExit;
    }
}