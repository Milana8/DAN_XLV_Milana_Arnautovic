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
    class AddProductViewModel:ViewModelBase
    {
        AddProductView addView;
        Service service = new Service();

        #region Constructor
        
        public AddProductViewModel(AddProductView addOpen)
        {
            addView = addOpen;
            Product = new tblProduct();
            ProductList = service.GetAllProducts().ToList();
        }

        public AddProductViewModel(AddProductView addOpen, tblProduct editProduct)
        {
            addView = addOpen;
            Product = editProduct;
            ProductList = service.GetAllProducts().ToList();
        }
        #endregion

        #region Properties
        private tblProduct product;
        public tblProduct Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }

        private List<tblProduct> productList;
        public List<tblProduct> ProductList
        {
            get
            {
                return productList;
            }
            set
            {
                productList = value;
                OnPropertyChanged("ProductList");
            }
        }

       
        private bool isUpdateProduct;
        public bool IsUpdateProduct
        {
            get
            {
                return isUpdateProduct;
            }
            set
            {
                isUpdateProduct = value;
            }
        }
        #endregion

        #region Commands

        private ICommand save;
        /// <summary>
        /// Save command
        /// </summary>
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        /// <summary>
        /// Save execute
        /// </summary>
        private void SaveExecute()
        {
            try
            {
                if (Product.Quantity <= 0 || Product.Price <= 0)
                {
                    MessageBox.Show("Invalid data input. Please try again.");
                }
                else
                {
                    tblProduct product = service.AddProduct(Product);
                    if (product != null)
                    {
                        if (Service.action == "added")
                        {
                             MessageBox.Show("Product has been added");
                        }
                        else if (Service.action == "updated")
                        {
                           
                            MessageBox.Show("Product has been updated");
                        }
                        isUpdateProduct = true;
                        addView.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Can save
        /// </summary>
        /// <returns></returns>
        private bool CanSaveExecute()
        {
            if (String.IsNullOrEmpty(product.ProductKey) ||
                String.IsNullOrEmpty(product.ProductName) ||
                String.IsNullOrEmpty(product.Quantity.ToString()) ||
                String.IsNullOrEmpty(product.Price.ToString())
                )
            {
                return false;
            }
            else
                return true;
        }

        private ICommand cancel;
        /// <summary>
        ///Cancel command 
        /// </summary>
        public ICommand Cancel
        {
            get
            {
                if (cancel == null)
                {
                    cancel = new RelayCommand(param => CancelExecute(), param => CanCancelExecute());
                }
                return cancel;
            }
        }

        /// <summary>
        /// Cancel execute
        /// </summary>
        private void CancelExecute()
        {
            try
            {
                addView.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        private bool CanCancelExecute()
        {
            return true;
        }
        #endregion
    }
}