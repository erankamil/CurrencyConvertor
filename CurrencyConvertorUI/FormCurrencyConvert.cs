using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyConvertorUI
{
    public partial class FormCurrencyConvert : Form
    {
        public CurrencyConvertorLogic.ConverterManger CurrencyConvertor { get; set; }

        public FormCurrencyConvert()
        {
            CurrencyConvertor = new CurrencyConvertorLogic.ConverterManger();
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            List<string> currencies = CurrencyConvertor.GetAllCurrencies();

            foreach(string currency in currencies)
            {
                this.comboBoxFrom.Items.Add(currency);
                this.comboBoxTo.Items.Add(currency);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (checkValidCurrencyInput(this.comboBoxFrom.Text) && checkValidCurrencyInput(this.comboBoxTo.Text))
            {
                float amountNumeric;
                if (checkValidAmount(this.textBoxAmount.Text, out amountNumeric))
                { 
                    try
                    {
                        string total = CurrencyConvertor.Convert(this.comboBoxFrom.SelectedItem.ToString(),
                            this.comboBoxTo.SelectedItem.ToString(), amountNumeric);

                        this.textBoxResult.Enabled = true;
                        this.textBoxResult.Text = total;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private bool checkValidAmount(string i_AmountStr, out float o_AmountNumeric)
        {
            bool isValid = true;
            o_AmountNumeric = 0;
            if (string.IsNullOrEmpty(this.textBoxAmount.Text))
            {
                isValid = false;
                MessageBox.Show("Amount field is empty", "Invalid Input");
            }
            else if (!float.TryParse(this.textBoxAmount.Text, out o_AmountNumeric))
            {
                isValid = false;
                MessageBox.Show("Please choose numric amount!", "Invalid Input");
            }

            return isValid;
        }

        private bool checkValidCurrencyInput(string i_CurrencyName)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(i_CurrencyName))
            {
                isValid = false;
                MessageBox.Show("Currency field is empty", "Invalid Input");
            }
            else if (!CurrencyConvertor.IsCurrencySupported(i_CurrencyName))
            {
                isValid = false;
                MessageBox.Show($"Currency '{i_CurrencyName}' doesn't supported", "Invalid Input");
            }

            return isValid;
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.comboBoxFrom.Text) && !string.IsNullOrEmpty(this.comboBoxTo.Text))
            {
                string currencyFrom = this.comboBoxFrom.SelectedItem.ToString();
                string currencyTo = this.comboBoxTo.SelectedItem.ToString();
                this.comboBoxFrom.Text = currencyTo;
                this.comboBoxTo.Text = currencyFrom;
            }
        }
    }
}
