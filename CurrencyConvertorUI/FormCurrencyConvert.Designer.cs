namespace CurrencyConvertorUI
{
    partial class FormCurrencyConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrencyConvert));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
            this.labelCurrencyName = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.buttonHistoryRateSync = new System.Windows.Forms.Button();
            this.listBoxHistoryRate = new System.Windows.Forms.ListBox();
            this.buttonHistoryRateAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(69, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(209, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Currency Convertor";
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(12, 44);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(329, 18);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "Please choose the convertion you want to make:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(71, 92);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(81, 142);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 13);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "To:";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(119, 89);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 4;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(119, 139);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 5;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(68, 183);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Amount:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(120, 180);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(120, 20);
            this.textBoxAmount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 8;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConvert.Location = new System.Drawing.Point(119, 218);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(120, 33);
            this.buttonConvert.TabIndex = 9;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(71, 268);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(222, 37);
            this.textBoxResult.TabIndex = 10;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.Lavender;
            this.buttonSwitch.Location = new System.Drawing.Point(156, 113);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(50, 23);
            this.buttonSwitch.TabIndex = 11;
            this.buttonSwitch.Text = "Switch";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.FormattingEnabled = true;
            this.comboBoxCurrencies.Location = new System.Drawing.Point(533, 41);
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurrencies.TabIndex = 12;
            // 
            // labelCurrencyName
            // 
            this.labelCurrencyName.AutoSize = true;
            this.labelCurrencyName.Location = new System.Drawing.Point(475, 44);
            this.labelCurrencyName.Name = "labelCurrencyName";
            this.labelCurrencyName.Size = new System.Drawing.Size(52, 13);
            this.labelCurrencyName.TabIndex = 13;
            this.labelCurrencyName.Text = "Currency:";
            this.labelCurrencyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.Location = new System.Drawing.Point(475, 9);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(202, 18);
            this.labelOptions.TabIndex = 14;
            this.labelOptions.Text = "Currency Historical Rates";
            // 
            // buttonHistoryRateSync
            // 
            this.buttonHistoryRateSync.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHistoryRateSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoryRateSync.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHistoryRateSync.Location = new System.Drawing.Point(391, 72);
            this.buttonHistoryRateSync.Name = "buttonHistoryRateSync";
            this.buttonHistoryRateSync.Size = new System.Drawing.Size(173, 33);
            this.buttonHistoryRateSync.TabIndex = 15;
            this.buttonHistoryRateSync.Text = "Get Hisoty Rate Sync";
            this.buttonHistoryRateSync.UseVisualStyleBackColor = false;
            this.buttonHistoryRateSync.Click += new System.EventHandler(this.buttonHistoryRateSync_Click);
            // 
            // listBoxHistoryRate
            // 
            this.listBoxHistoryRate.FormattingEnabled = true;
            this.listBoxHistoryRate.Location = new System.Drawing.Point(391, 113);
            this.listBoxHistoryRate.Name = "listBoxHistoryRate";
            this.listBoxHistoryRate.Size = new System.Drawing.Size(370, 199);
            this.listBoxHistoryRate.TabIndex = 16;
            // 
            // buttonHistoryRateAsync
            // 
            this.buttonHistoryRateAsync.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHistoryRateAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoryRateAsync.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHistoryRateAsync.Location = new System.Drawing.Point(588, 72);
            this.buttonHistoryRateAsync.Name = "buttonHistoryRateAsync";
            this.buttonHistoryRateAsync.Size = new System.Drawing.Size(173, 33);
            this.buttonHistoryRateAsync.TabIndex = 17;
            this.buttonHistoryRateAsync.Text = "Get Hisoty Rate Async";
            this.buttonHistoryRateAsync.UseVisualStyleBackColor = false;
            // 
            // FormCurrencyConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(783, 329);
            this.Controls.Add(this.buttonHistoryRateAsync);
            this.Controls.Add(this.listBoxHistoryRate);
            this.Controls.Add(this.buttonHistoryRateSync);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.labelCurrencyName);
            this.Controls.Add(this.comboBoxCurrencies);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCurrencyConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.ComboBox comboBoxCurrencies;
        private System.Windows.Forms.Label labelCurrencyName;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Button buttonHistoryRateSync;
        private System.Windows.Forms.ListBox listBoxHistoryRate;
        private System.Windows.Forms.Button buttonHistoryRateAsync;
    }
}