using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CompanyInformationJSON
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het btw nummer in dat u wilt opzoeken:");
            string btwnr = Console.ReadLine();
            //string btwnr = "0866.039.061";
            var url = $"https://robofin.be/fiche/api.enterprise.php?a=EnterpriseData&VAT={btwnr}";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            httpRequest.Accept = "application/json";

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var bedrijfsData = JsonConvert.DeserializeObject<BedrijfsData>(result);
                List<Kpi> kpilijst = new List<Kpi>();
               // var first = bedrijfsData.Kpis.yFirst();

                foreach (object i in bedrijfsData.Kpis)
                {
                    kpilijst.Add(((Kpi)i));
                }
                int counter = 0;
                foreach(Kpi kpi in kpilijst)
                {
                    if(counter == 0)
                    {
                        //Console.WriteLine("Profit/loss" + kpi.Years["2020-12-31"].Amount.ToString());
                        counter++;
                    }
                    else  if (counter == 1)
                    {
                    //    Console.WriteLine(kpi.Years["2020-12-31"].Amount.ToString());
                    }
                  // Console.WriteLine(kpi.Years["2020-12-31"].Amount.ToString());
                }
            
                Console.WriteLine(bedrijfsData.Denomination.DenominationDenomination);
                Console.WriteLine(result);
            }

            Console.WriteLine(httpResponse.StatusCode);
        }
    }
}
