using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace AbhayTradingCompanyApi.Models
{
    [FirestoreData]
    public class Millname
    {


      
        public string id { get; set; }
        [FirestoreProperty]
        public string millname { get; set; }

    }
}
