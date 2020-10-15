using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbhayTradingCompanyApi.Models
{
 [Google.Cloud.Firestore.FirestoreData]   
        public class Nextid
    {

        [Google.Cloud.Firestore.FirestoreProperty]
        public int nextorderid { get; set; }

        [Google.Cloud.Firestore.FirestoreProperty]
        public int nextcustomerid { get; set; }


       




    }
}
