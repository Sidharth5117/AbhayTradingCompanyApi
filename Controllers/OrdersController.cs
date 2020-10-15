using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbhayTradingCompanyApi.Models;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AbhayTradingCompanyApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET: api/<OrdersController>
        [HttpGet]
        [Route("orders")]
        public async Task<IList<Order>> GetOrders()
        {
            IList<Order> items = new List<Order>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            Query d = db.Collection("orders");
            QuerySnapshot s = await d.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in s.Documents)
            {
                Order b = docsnap.ConvertTo<Order>();
                b.id = docsnap.Id;
                items.Add(b);
            }
            return items;
        }



        [HttpGet]
        [Route("millnames")]
        public async Task<IList<Millname>> GetMillNames()
        {
            IList<Millname> items = new List<Millname>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            Query d = db.Collection("mills");
            QuerySnapshot s = await d.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in s.Documents)
            {
                Millname b = docsnap.ConvertTo<Millname>();
                b.id = docsnap.Id;
                items.Add(b);
            }
            return items;
        }



        [HttpGet]
        [Route("customers")]
        public async Task<IList<Customer>> GetCustomers()
        {
            IList<Customer> items = new List<Customer>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            Query d = db.Collection("customers");
            QuerySnapshot s = await d.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in s.Documents)
            {
                Customer b = docsnap.ConvertTo<Customer>();
                b.id = docsnap.Id;
                items.Add(b);
            }
            return items;
        }




        [HttpGet]
        [Route("materials")]
        public async Task<IList<Material>> GetMaterials()
        {
            IList<Material> items = new List<Material>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            Query d = db.Collection("materials");
            QuerySnapshot s = await d.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in s.Documents)
            {
                Material b = docsnap.ConvertTo<Material>();
                b.id = docsnap.Id;
                items.Add(b);
            }
            return items;
        }








        [HttpGet]
        [Route("brokers")]
        public async Task<IList<Broker>> GetBrokers()
        {
            IList<Broker> items = new List<Broker>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            Query d = db.Collection("brokers");
            QuerySnapshot s = await d.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in s.Documents)
            {
                Broker b = docsnap.ConvertTo<Broker>();
                b.id = docsnap.Id;
                items.Add(b);
            }
            return items;
        }


        [HttpGet]
        [Route("shipto")]
        public async Task<IList<Shipto>> GetShipto()
        {
            IList<Shipto> items = new List<Shipto>();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            Query d = db.Collection("shipto");
            QuerySnapshot s = await d.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in s.Documents)
            {
                Shipto b = docsnap.ConvertTo<Shipto>();
                b.id = docsnap.Id;
                items.Add(b);
            }
            return items;
        }







        // GET api/<OrdersController>/5
        [HttpGet]
        [Route("orders/{id}")]
        public async Task<ActionResult<Order>> GetOrder(string id)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            DocumentReference d = db.Collection("orders").Document(id);
            DocumentSnapshot s = await d.GetSnapshotAsync();


            if (s.Exists)
            {
                Order b = s.ConvertTo<Order>();
                b.id = s.Id;
                return b;
            }
            else
            {
                return NotFound();
            }


        }

        // POST api/<OrdersController>
        [HttpPost]
        [Route("orders")]
        public async Task<ActionResult<Order>> Post(Order master)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");


            DocumentReference d1 = db.Collection("nextid").Document("1");
            DocumentSnapshot s1 = await d1.GetSnapshotAsync();

            Nextid n = s1.ConvertTo<Nextid>();
           



            DocumentReference c = db.Collection("orders").Document(n.nextorderid.ToString());




            /*

            Query cr2 = db.Collection("brokers").WhereEqualTo("broker", master.broker.ToUpper());
            QuerySnapshot q2 = await cr2.GetSnapshotAsync();
            int x2 = 0;

            foreach (DocumentSnapshot docsnap in q2.Documents)
            {
                if (docsnap.Exists)
                {
                    x2= 1;
                }
                else
                {

                }

            }

            if (x2 == 0)
            {

                Dictionary<string, object> d2 = new Dictionary<string, object>()
            {
                {"broker",master.broker.ToUpper() }


            };
                DocumentReference c2 = db.Collection("brokers").Document(n.nextbrokerid.ToString());
                c2.SetAsync(d2);





                n.nextbrokerid++;
            }

            else
            {





            }



            */

            /*

            Query cr3 = db.Collection("shipto").WhereEqualTo("shipto", master.shipto.ToUpper());
            QuerySnapshot q3 = await cr3.GetSnapshotAsync();
            int x3 = 0;

            foreach (DocumentSnapshot docsnap in q3.Documents)
            {
                if (docsnap.Exists)
                {
                    x3 = 1;
                }
                else
                {

                }

            }

            if (x3 == 0)
            {

                Dictionary<string, object> d3 = new Dictionary<string, object>()
            {
                {"shipto",master.shipto.ToUpper() }


            };
                DocumentReference c3 = db.Collection("shipto").Document(n.nextshiptoid.ToString());
                c3.SetAsync(d3);





                n.nextshiptoid++;
            }

            else
            {





            }



            */






            Query cr = db.Collection("customers").WhereEqualTo("customer",master.customer.ToUpper());
            QuerySnapshot q = await cr.GetSnapshotAsync();
            int x = 0;
            foreach (DocumentSnapshot docsnap in q.Documents)
            {
                if(docsnap.Exists)
                {
                    x = 1;
                }
                else
                {

                }
                
            }

            if(x==0)
            {

                Dictionary<string, object> d4 = new Dictionary<string, object>()
            {
                {"customer",master.customer.ToUpper() }
              

            };
                DocumentReference c4 = db.Collection("customers").Document(n.nextcustomerid.ToString());
                c4.SetAsync(d4);





                n.nextcustomerid++;
            }

            else
            {





            }


            Dictionary<string, object> d = new Dictionary<string, object>()
            {
                {"timestamp",Timestamp.GetCurrentTimestamp() },
                { "billrate",master.billrate },
                {"broker",master.broker.ToUpper() },
                {"customer",master.customer.ToUpper() },
                {"entryby",master.entryby.ToUpper() },
                { "material",master.material.ToUpper()},
                {"millname",master.millname.ToUpper() },
                {"quantity",master.quantity },
                {"remarks",master.remarks.ToUpper() },
                {"saudarate",master.saudarate },
                {"shipto",master.shipto.ToUpper() }

            };
            c.SetAsync(d);


            DocumentReference cityRef = db.Collection("nextid").Document("1");


            Dictionary<string, object> updates = new Dictionary<string, object>
{

                    {"nextorderid",n.nextorderid+1},
                   {"nextcustomerid",n.nextcustomerid }
                   
                      

};

            await cityRef.UpdateAsync(updates);


            return master;

        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Order>> PutMaster(string id, Order master)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");

            DocumentReference cityRef = db.Collection("orders").Document(id);
            Dictionary<string, object> updates = new Dictionary<string, object>
{
                {"billrate",master.billrate },
                {"broker",master.broker.ToUpper() },
                {"customer",master.customer.ToUpper() },
                {"entryby",master.entryby.ToUpper() },
                { "material",master.material.ToUpper()},
                {"millname",master.millname.ToUpper() },
                {"quantity",master.quantity },
                {"remarks",master.remarks.ToUpper() },
                {"saudarate",master.saudarate },
                {"shipto",master.shipto.ToUpper() }
};
            await cityRef.UpdateAsync(updates);

            return master;

        }

        // DELETE api/<OrdersController>/5
        [HttpDelete]
        [Route("orders/{id}")]
        public async Task<ActionResult<Order>> Delete(string id)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"atcauth.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("abhaytradingcompany-2fe1f");
            DocumentReference d = db.Collection("orders").Document(id);

            DocumentSnapshot s = await d.GetSnapshotAsync();
            Order b = s.ConvertTo<Order>();

            await d.DeleteAsync();

            return b;


        }
    }
}
