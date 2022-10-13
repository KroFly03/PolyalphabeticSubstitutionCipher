namespace PolyalphabeticSubstitutionCipher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlphabetGrid = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CipherLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CipherInput = new System.Windows.Forms.TextBox();
            this.KeyInput = new System.Windows.Forms.TextBox();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AlphabetGrid)).BeginInit();
            this.Header.SuspendLayout();
            this.Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlphabetGrid
            // 
            this.AlphabetGrid.AllowUserToAddRows = false;
            this.AlphabetGrid.AllowUserToDeleteRows = false;
            this.AlphabetGrid.AllowUserToResizeColumns = false;
            this.AlphabetGrid.AllowUserToResizeRows = false;
            this.AlphabetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlphabetGrid.Location = new System.Drawing.Point(554, 49);
            this.AlphabetGrid.Name = "AlphabetGrid";
            this.AlphabetGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AlphabetGrid.Size = new System.Drawing.Size(885, 765);
            this.AlphabetGrid.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.ResetButton);
            this.Header.Controls.Add(this.CipherLabel);
            this.Header.Controls.Add(this.KeyLabel);
            this.Header.Controls.Add(this.TextLabel);
            this.Header.Controls.Add(this.CipherInput);
            this.Header.Controls.Add(this.KeyInput);
            this.Header.Controls.Add(this.TextInput);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1924, 100);
            this.Header.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(1161, 28);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(113, 39);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CipherLabel
            // 
            this.CipherLabel.AutoSize = true;
            this.CipherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherLabel.Location = new System.Drawing.Point(781, 72);
            this.CipherLabel.Name = "CipherLabel";
            this.CipherLabel.Size = new System.Drawing.Size(55, 20);
            this.CipherLabel.TabIndex = 5;
            this.CipherLabel.Text = "Шифр";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(781, 40);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(50, 20);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Ключ";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(781, 8);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(52, 20);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "Текст";
            // 
            // CipherInput
            // 
            this.CipherInput.Enabled = false;
            this.CipherInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherInput.Location = new System.Drawing.Point(854, 66);
            this.CipherInput.Name = "CipherInput";
            this.CipherInput.Size = new System.Drawing.Size(272, 26);
            this.CipherInput.TabIndex = 2;
            // 
            // KeyInput
            // 
            this.KeyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyInput.Location = new System.Drawing.Point(854, 34);
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(272, 26);
            this.KeyInput.TabIndex = 1;
            this.KeyInput.TextChanged += new System.EventHandler(this.KeyInput_TextChanged);
            // 
            // TextInput
            // 
            this.TextInput.Enabled = false;
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInput.Location = new System.Drawing.Point(854, 2);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(272, 26);
            this.TextInput.TabIndex = 0;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.AlphabetGrid);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 100);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(1924, 941);
            this.Body.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Header);
            this.Name = "MainForm";
            this.Text = "Шифр многоалфавитной замены";
            ((System.ComponentModel.ISupportInitialize)(this.AlphabetGrid)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AlphabetGrid;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Label CipherLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox CipherInput;
        private System.Windows.Forms.TextBox KeyInput;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button ResetButton;
    }
}

