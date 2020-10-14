using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbhayTradingCompanyApi.Models
{
    [FirestoreData]
    public class Order
    {

      
        public string id { get; set; }


        [FirestoreProperty]
        public DateTime timestamp { get; set; }

        [FirestoreProperty]
        public string customer { get; set; }

        [FirestoreProperty]
        public string shipto { get; set; }

        [FirestoreProperty]
        public string broker { get; set; }

        [FirestoreProperty]
        public string millname { get; set; }

        [FirestoreProperty]
        public string material { get; set; }

        [FirestoreProperty]
        public int quantity { get; set; }

        [FirestoreProperty]
        public int saudarate { get; set; }

        [FirestoreProperty]
        public int billrate { get; set; }

        [FirestoreProperty]
        public string entryby { get; set; }

        [FirestoreProperty]
        public string remarks { get; set; }







    }
}
