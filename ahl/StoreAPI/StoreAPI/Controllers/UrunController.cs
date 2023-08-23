using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreAPI.Model;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace StoreAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        //[HttpGet]
        //public string get()
        //{
        //    return "hede";
        //}
        public static List<Urun> urunler = new List<Urun>
            {
                new Urun{Id=3,ad="hp printer",kategori="elektronik",stokadet=4},
                new Urun{Id=7,ad="laptop",kategori="bilgisayar",stokadet=5},
                new Urun{Id=8,ad="air fryer",kategori="mutfak",stokadet=6},
            };


        [HttpGet]
        public List<Urun> get()
        { 
            return urunler;
        }

        [HttpGet("{id}")]
        public Urun getbyId(string id)
        {
            if (id != null)
            {
                if (id == "7")
                {
                    //mail gönder
                }
                return urunler.SingleOrDefault(x => x.Id == Convert.ToInt32(id));

            }
            else
                return null;

        }
        [HttpPost]
        public Urun Post (Urun yeniUrun)
        {
            if (yeniUrun!=null)
            {
                urunler.Add(yeniUrun);
               
            }
           
            {
                return yeniUrun;
            }
            //crud 
            //    create Httpppost
            //    read httpget
            //    update httpput
            //    delete httpdelete
        }

        [HttpDelete]
        public Urun delete(int id)
        {
            Urun silinecek
                = urunler.SingleOrDefault(u => u.Id == id);
            urunler.Remove(silinecek);
            return silinecek;
        }
        
        [HttpPut]
        public Urun Put(Urun guncel)
        {
            Urun guncellenecekurun
                = urunler.Single(u => u.Id == guncel.Id);
            guncellenecekurun.ad = guncel.ad;
            guncellenecekurun.kategori = guncel.kategori;
            guncellenecekurun.stokadet= guncel.stokadet;

            return guncel;



        }

    }
}
