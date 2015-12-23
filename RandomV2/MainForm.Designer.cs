namespace RandomStringGeneratorNamespace {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.LengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.OutputValue = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Items.AddRange(new object[] {
            "Десятичный",
            "Двоичный",
            "Шестнадцатеричный(низ)",
            "Шестнадцатеричный(вер)",
            "Буквенный(низ)",
            "Буквенный(вер)",
            "Буквенный",
            "Цифровой, буквенный(низ)",
            "Цифровой, буквенный(вер)",
            "Цифровой, буквенный"});
            this.TypeCombo.Location = new System.Drawing.Point(12, 12);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(174, 21);
            this.TypeCombo.TabIndex = 1;
            // 
            // LengthNumeric
            // 
            this.LengthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthNumeric.Location = new System.Drawing.Point(192, 12);
            this.LengthNumeric.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.LengthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LengthNumeric.Name = "LengthNumeric";
            this.LengthNumeric.Size = new System.Drawing.Size(46, 21);
            this.LengthNumeric.TabIndex = 3;
            this.LengthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OutputValue
            // 
            this.OutputValue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputValue.Location = new System.Drawing.Point(12, 39);
            this.OutputValue.MaxLength = 200;
            this.OutputValue.Multiline = true;
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.ReadOnly = true;
            this.OutputValue.Size = new System.Drawing.Size(226, 124);
            this.OutputValue.TabIndex = 2;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(128, 166);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(110, 36);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Enabled = false;
            this.CopyButton.Location = new System.Drawing.Point(12, 169);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(110, 36);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Скопировать";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 214);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputValue);
            this.Controls.Add(this.LengthNumeric);
            this.Controls.Add(this.TypeCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Генератор случайных строк";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LengthNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Random random = new System.Random((int)System.DateTime.Now.Ticks & 0x0000FFFF);

        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.TextBox OutputValue;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.NumericUpDown LengthNumeric;
    }
}