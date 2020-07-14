using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class StorekeeperViewModel: ViewModelBase
    {
        StorekeeperView storekeeperView;
        Service service = new Service();

       
        #region Constructor
        public StorekeeperViewModel(StorekeeperView view)
        {
            storekeeperView = view;
            ProductList = service.GetAllProducts().ToList();
        }
        #endregion

        #region Properties
        private List<tblProduct> productList;
        public List<tblProduct> ProductList
        {
            get { return productList; }
            set
            {
                productList = value;
                OnPropertyChanged("ProductList");
            }
        }

        private tblProduct product;
        public tblProduct Product
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }

        private Visibility productView = Visibility.Visible;
        public Visibility ProductView
        {
            get
            {
                return productView;
            }
            set
            {
                productView = value;
                OnPropertyChanged("ProductView");
            }
        }
        #endregion

        #region Commands
        
        private ICommand storeProduct;
        /// <summary>
        /// Store product command
        /// </summary>
        public ICommand StoreProduct
        {
            get
            {
                if (storeProduct == null)
                {
                    storeProduct = new RelayCommand(param => StoreProductExecute(), param => CanStoreProductExecute());
                }
                return storeProduct;
            }
        }

        /// <summary>
        /// Store product execute
        /// </summary>
        public void StoreProductExecute()
        {
            Delegate del = new Delegate();
            try
            {
                if (Product != null)
                {
                    int productId = Product.ID;
                    if (Product.Quantity > 100)
                    {
                       del.WarehouseFull(); //If the quantity is greater than 100 it cannot be stored

                    }
                    
                    else
                    {
                        del.ProductStored(); //If the quantity is less than 100 it can be stored
                    }
                    ProductList = service.GetAllProducts().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Can store product
        /// </summary>
        /// <returns></returns>

        public bool CanStoreProductExecute()
        {
            if (Product == null)
                return false;
            else
                return true;
        }



        #endregion

        class Delegate
        {
            public delegate void Notification();

            public event Notification OnNotification;

            /// <summary>
            /// Notice that the warehouse is full
            /// </summary>
            public void WarehouseFull()
            {
                OnNotification += () =>
                {
                    MessageBox.Show("There is no space in the warehouse.");
                };
                OnNotification.Invoke();
            }
            /// <summary>
            /// Notification that the product is stored
            /// </summary>
            public void ProductStored()
            {
                OnNotification += () =>
                {
                    MessageBox.Show("Product is stored in the warehouse.");
                };
                OnNotification.Invoke();
            }
        }
    }
}