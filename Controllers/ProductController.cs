using ProductCatlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCatlog.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<product> P = getproduct();
            return View(P);
        }

        private List<product> getproduct()
        {
            List<product> P = new List<product>();

            product P1 = new product
            {
                id = 1,
                name = "product1",
                description = "this is best product",
                price = 5000,
                imgurl = "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcQdspu-TVowI8apqDD2BnT-q5JUXXpqxAz0GRZ94SF1m6fLnvcsLlah_my8bpcq2sNSGddvA8Sc4aVGoiTUAgwAkH5YrMeVVRWP8vgsgAm5kAerPKErbiR-BU8",
            };

            product P2 = new product
            {
                id = 2,
                name = "product2",
                description = "this is best product",
                price = 5000,
                imgurl = "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcQdspu-TVowI8apqDD2BnT-q5JUXXpqxAz0GRZ94SF1m6fLnvcsLlah_my8bpcq2sNSGddvA8Sc4aVGoiTUAgwAkH5YrMeVVRWP8vgsgAm5kAerPKErbiR-BU8",
            };

            P.Add(P1);
            P.Add(P2);


            return P;

        }

        public ActionResult Detail(int id)
        {
            List<product> P = getproduct();
            product P1 = new product();
            P1 = P.FirstOrDefault(H  => H.id == id);

            return View(P1);
        }
    }
}