using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CurrencyConvertorUI
{
    class Program
    {

        public static void Main()
        {
            Application.EnableVisualStyles();
            FormCurrencyConvert form = new FormCurrencyConvert();
            form.ShowDialog();
        }
    }
}
