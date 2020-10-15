using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbhayTradingCompanyApi.Models
{
    [FirestoreData]
    public class Material
    {


        public string id { get; set; }

        [FirestoreProperty]
        public string material { get; set; }

    }
}
