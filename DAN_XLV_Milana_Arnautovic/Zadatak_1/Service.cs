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
        public static string action;


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

        public tblProduct AddProduct(tblProduct product)
        {
            try
            {
                using (DAN_XLVEntities context = new DAN_XLVEntities())
                {
                    if (product.ID == 0)
                    {
                        tblProduct newProduct = new tblProduct();
                        newProduct.ProductName = product.ProductName;
                        newProduct.ProductKey = product.ProductKey;
                        newProduct.Quantity = product.Quantity;
                        newProduct.Price = product.Price;
                        newProduct.Stored = false;
                        context.tblProducts.Add(newProduct);
                        context.SaveChanges();
                        product.ID = newProduct.ID;
                        action = "added";
                        return product;
                    }
                    else
                    {
                        tblProduct productForEdit = (from x in context.tblProducts where x.ID == product.ID select x).FirstOrDefault();
                        productForEdit.ProductName = product.ProductName;
                        productForEdit.ProductKey = product.ProductKey;
                        productForEdit.Quantity = product.Quantity;
                        productForEdit.Price = product.Price;
                        context.SaveChanges();
                        action = "edited";
                        return product;
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception: " + ex.Message.ToString());
                return null;
            }
        }


        public void StoredQuantity()

        {
            int sum = 0;
            try
            {
                using (DAN_XLVEntities context = new DAN_XLVEntities())
                {
                    List<tblProduct> products = new List<tblProduct>();
                    products = context.tblProducts.ToList();


                    foreach (var product in products)
                    {
                        if ((bool)product.Stored)
                        {
                            sum += (int)product.Quantity;
                        }
                    }

                }


            }



            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }
        public void StoreProduct(int id)
        {
            try
            {
                using (DAN_XLVEntities context = new DAN_XLVEntities())
                {
                    tblProduct productToStore = (from r in context.tblProducts where r.ID == id select r).First();
                    productToStore.Stored = true;
                    context.SaveChanges();

                    StoredQuantity();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
