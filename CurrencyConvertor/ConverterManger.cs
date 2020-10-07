using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CurrencyConvertorLogic
{
    public class ConverterManger
    {
        private const string k_ApiKey = "K57E5GlNa6wJhU1BHW2C";
        private const string k_ApiUrl = "https://marketdata.tradermade.com/api/v1/";

        public Dictionary<string, string> CurrencyPairs { get; set; } = new Dictionary<string, string>();

        public List<string> GetAllCurrencies()
        {
            string url = $"{k_ApiUrl}live_currencies_list?api_key={k_ApiKey}";
            string jsonString = webResponse(url);
            IList<JToken> tokens = JObject.Parse(jsonString)["available_currencies"].Children().ToList();

            foreach(JToken token in tokens)
            {
                string currencySymbol = getCurrencySymbol(token.ToString());
                CurrencyPairs.Add(token.First.ToString(), currencySymbol);
            }

            return tokens.Select(item => item.First.ToObject<string>()).ToList();
        }

        private string getCurrencySymbol(string currencyToken)
        {
            StringBuilder st = new StringBuilder();
            int maxCount = 3, count = 0;
            for(int i = 0; i < currencyToken.Length; i++)
            { 
                if(char.IsUpper(currencyToken[i]))
                {
                    st.Append(currencyToken[i]);
                    count++;
                    if(count == maxCount)
                    {
                        break;
                    }
                }
            }

            return st.ToString();
        }

        private string webResponse(string i_Url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(i_Url);
        }

        public string Convert(string i_From, string i_To, float amount)
        {
            string currencyNameFrom, currencyNameTo;
            if (CurrencyPairs.TryGetValue(i_From, out currencyNameFrom))
            {
                if (CurrencyPairs.TryGetValue(i_To, out currencyNameTo))
                {
                    try
                    {
                        string url = $"{k_ApiUrl}convert?api_key={k_ApiKey}&from={currencyNameFrom}&to={currencyNameTo}&amount={amount.ToString()}";
                        string jsonString = webResponse(url);
                        return JObject.Parse(jsonString)["total"].ToString();
                    }
                    catch( Exception ex)
                    {
                        throw new Exception(@"Sorry, Could not convert those currencies,
try other currencies to convert please.");
                    }
                }
                else
                {
                    throw new Exception("Curreny 'To' not available");
                }
            }
            else
            {
                throw new Exception("Curreny 'From' not available");
            }
        }

        //https://marketdata.tradermade.com/api/v1/hour_historical?api_key=api_key&date=2019-10-09-13:00&currency=EURUSD   

        public List<string> GetHourHistoricalRates(string i_CurrencyName)
        {
            string currencySymbol;
            if (CurrencyPairs.TryGetValue(i_CurrencyName, out currencySymbol))
            {
                string url = $"{k_ApiUrl}hour_historical?api_key={k_ApiKey}&date=2019-10-10-13:00&currency={currencySymbol}";
                string jsonString = webResponse(url);
            }
            return null;
        }

        public bool IsCurrencySupported(string i_CurrencyName)
        {
            string result;
            return CurrencyPairs.TryGetValue(i_CurrencyName, out result);
        }
    }
}
