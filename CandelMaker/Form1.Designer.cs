namespace CandelMaker
{
    partial class CandelMaker
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
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCandelType = new System.Windows.Forms.ComboBox();
            this.tbSettings = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSelectFileRead = new System.Windows.Forms.TextBox();
            this.tbSelectFileSave = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNameCandel = new System.Windows.Forms.TextBox();
            this.tbValueCandel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(260, 186);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Make";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип свечи:";
            // 
            // cBCandelType
            // 
            this.cBCandelType.DisplayMember = "Volume";
            this.cBCandelType.FormattingEnabled = true;
            this.cBCandelType.Items.AddRange(new object[] {
            "Range",
            "Volume",
            "RangeMove"});
            this.cBCandelType.Location = new System.Drawing.Point(172, 52);
            this.cBCandelType.Name = "cBCandelType";
            this.cBCandelType.Size = new System.Drawing.Size(121, 21);
            this.cBCandelType.TabIndex = 2;
            this.cBCandelType.SelectedIndexChanged += new System.EventHandler(this.cBCandelType_SelectedIndexChanged);
            // 
            // tbSettings
            // 
            this.tbSettings.Location = new System.Drawing.Point(369, 52);
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Size = new System.Drawing.Size(100, 20);
            this.tbSettings.TabIndex = 3;
            this.tbSettings.TextChanged += new System.EventHandler(this.tbSettings_TextChanged);
            this.tbSettings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSettings_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(27, 90);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 5;
            this.btOpen.Text = "Open file";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(27, 136);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save file";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Размер:";
            // 
            // tbSelectFileRead
            // 
            this.tbSelectFileRead.Location = new System.Drawing.Point(108, 92);
            this.tbSelectFileRead.Name = "tbSelectFileRead";
            this.tbSelectFileRead.Size = new System.Drawing.Size(451, 20);
            this.tbSelectFileRead.TabIndex = 8;
            // 
            // tbSelectFileSave
            // 
            this.tbSelectFileSave.Location = new System.Drawing.Point(108, 139);
            this.tbSelectFileSave.Name = "tbSelectFileSave";
            this.tbSelectFileSave.ReadOnly = true;
            this.tbSelectFileSave.Size = new System.Drawing.Size(185, 20);
            this.tbSelectFileSave.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "\\";
            // 
            // tbNameCandel
            // 
            this.tbNameCandel.Location = new System.Drawing.Point(317, 138);
            this.tbNameCandel.Name = "tbNameCandel";
            this.tbNameCandel.ReadOnly = true;
            this.tbNameCandel.Size = new System.Drawing.Size(68, 20);
            this.tbNameCandel.TabIndex = 11;
            // 
            // tbValueCandel
            // 
            this.tbValueCandel.Location = new System.Drawing.Point(410, 138);
            this.tbValueCandel.Name = "tbValueCandel";
            this.tbValueCandel.ReadOnly = true;
            this.tbValueCandel.Size = new System.Drawing.Size(100, 20);
            this.tbValueCandel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            // 
            // tbFile
            // 
            this.tbFile.Enabled = false;
            this.tbFile.Location = new System.Drawing.Point(532, 138);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(27, 20);
            this.tbFile.TabIndex = 15;
            this.tbFile.Text = "csv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = ".";
            // 
            // CandelMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 235);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbValueCandel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameCandel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSelectFileSave);
            this.Controls.Add(this.tbSelectFileRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbSettings);
            this.Controls.Add(this.cBCandelType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.Name = "CandelMaker";
            this.Text = "Candel maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCandelType;
        private System.Windows.Forms.TextBox tbSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSelectFileRead;
        private System.Windows.Forms.TextBox tbSelectFileSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNameCandel;
        private System.Windows.Forms.TextBox tbValueCandel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btOk;
    }
}

