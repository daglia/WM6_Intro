using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonServislerineBaglanma
{
    public class FourFactory
    {
        public const string clientID = "ORDPWFCUCZKOUYVSUOLJAHH0UVL45WWIK3SBURYK2WO01YIA";
        public const string clientSecret = "SHDQVXI0MCSNA4QKWUN0AKR1BDBIZOOHPO411KFTNU31EDKK";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "56aa371be4b08b9a8d5734c1";
        public int radius = 2000;
        public string latitude = "41.0446062";
        public string longitude = "29.0063537";

        string queryUrl = string.Empty;
        public string jsonString = string.Empty;

        public FourFactory()
        {
            queryUrl = apiUrl; //query string (=, & ve $ işaretlerine dikkat!)
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + $"{DateTime.Now:yyyyMMdd}";
            queryUrl += $"&ll={latitude},{longitude}";
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + categoryCode;
            GetVenues(queryUrl);
        }

        private async void GetVenues(string query)
        {
            HttpClient client = new HttpClient(); //GET ve POST metodlarını kullanmak için
            try
            {
                jsonString = await client.GetStringAsync(query); //ya da
                //jsonString = client.GetStringAsync(query).Result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Four.Venue> Firmalar { get => FirmalariDoldur(); }

        private List<Four.Venue> FirmalariDoldur()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(jsonString);
            return sonuc.response.venues.ToList();
        }
    }
}
