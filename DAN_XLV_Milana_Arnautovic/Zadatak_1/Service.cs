using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1
{
   public class Service
    {
        public static List<tblProduct> products = new List<tblProduct>();
        public static tblProduct currentProduct = new tblProduct();

        public List<tblProduct> GetAllProducts()
        {
            try
            {
                using (DAN_XLVEntities context = new DAN_XLVEntities())
                {
                    List<tblProduct> products = new List<tblProduct>();
                    products = context.tblProducts.ToList();
                    return products;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }

        public void DeleteProduct(int ProductID)
        {
            try
            {
                using (DAN_XLVEntities context = new DAN_XLVEntities())
                {
                    tblProduct productToDelete = (from r in context.tblProducts where r.ID == ProductID select r).First();
                    context.tblProducts.Remove(productToDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }


    }
}
