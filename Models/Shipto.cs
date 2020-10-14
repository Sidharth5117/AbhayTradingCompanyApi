using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbhayTradingCompanyApi.Models
{
    [Google.Cloud.Firestore.FirestoreData]
    public class Shipto
    {
        public string id { get; set; }

        [Google.Cloud.Firestore.FirestoreProperty]
        public string shipto { get; set; }
    }
}
