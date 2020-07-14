﻿using System;
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
    class MainWindowViewModel : ViewModelBase
    {
        MainWindow main;
        Service service = new Service();

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

        private Visibility viewProduct = Visibility.Visible;
        public Visibility ViewProduct
        {
            get
            {
                return viewProduct;
            }
            set
            {
                viewProduct = value;
                OnPropertyChanged("ViewProduct");
            }
        }
        #endregion

        #region Constructors


        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
            using (DAN_XLVEntities context = new DAN_XLVEntities())
            {
                ProductList = context.tblProducts.ToList();
            }
        }
        #endregion

        #region Commands

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(param => AddCommandExecute(), param => CanAddCommandExecute());
                }
                return addCommand;
            }
        }

        
        private void AddCommandExecute()
        {
            try
            {
                AddProductView addView = new AddProductView();
                addView.ShowDialog();
                if ((addView.DataContext as AddProductViewModel).IsUpdateProduct == true)
                {
                    ProductList = service.GetAllProducts().ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private bool CanAddCommandExecute()
        {
            return true;
        }

        
        private ICommand editCommand;
        public ICommand EditCommand
        {
            get
            {
                if (editCommand == null)
                {
                    editCommand = new RelayCommand(param => EditCommandExecute(), param => CanEditCommandExecute());
                }
                return editCommand;
            }
        }

       
        public void EditCommandExecute()
        {
            try
            {
                if (Product != null)
                {
                    AddProductView editProduct = new AddProductView();
                    editProduct.ShowDialog();

                    if ((editProduct.DataContext as AddProductViewModel).IsUpdateProduct == true)
                    {
                        ProductList = service.GetAllProducts().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        public bool CanEditCommandExecute()
        {
            if (Product == null)
                return false;
            else
                return true;
        }


        private ICommand deleteProduct;
        public ICommand DeleteProduct
        {
            get
            {
                if (deleteProduct == null)
                {
                    deleteProduct = new RelayCommand(param => DeleteProductExecute(), param => CanDeleteProductExecute());
                }
                return deleteProduct;
            }
        }


        private void DeleteProductExecute()
        {
            var result = MessageBox.Show("Are you sure you want to delete the product?", "Confirmation",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    if (Product != null)
                    {

                        int productId = Product.ID;
                        if (Product.Stored == true)
                        {
                            MessageBox.Show("Product is stored and cannot be deleted from database.");
                            
                        }
                        else
                        {

                            service.DeleteProduct(productId);
                            MessageBox.Show("Product " + Product.ProductName + " with code:" + Product.ProductKey + " deleted from database.");
                            
                        }
                        using (DAN_XLVEntities context = new DAN_XLVEntities())
                        {
                            ProductList = context.tblProducts.ToList();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                return;
            }
        }

       
        private bool CanDeleteProductExecute()
        {
            if (Product == null)
                return false;
            else
                return true;
        }


        #endregion
    }
}


