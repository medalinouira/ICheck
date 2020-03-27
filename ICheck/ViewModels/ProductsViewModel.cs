/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using ICheck.Models;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using ICheck.Interfaces.IServices;
using System.Collections.ObjectModel;

namespace ICheck.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<ProductModel> _products;
        #endregion

        #region Properties
        public ObservableCollection<ProductModel> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }
        #endregion

        #region Commands
        public ICommand OnProductTapCommand { get; set; }
        #endregion

        #region Constructor
        [Preserve]
        public ProductsViewModel(INavigationService _iNavigationService)
        {
            this._iNavigationService = _iNavigationService;

            OnProductTapCommand = new Command<ProductModel>(async (productModel) => await OnProductTap(productModel));

            GetProducts();
        }
        #endregion

        #region Methods
        private void GetProducts()
        {
            var products = new ObservableCollection<ProductModel>()
            {
                new ProductModel (){ Id = 0, Name = "Tomate", Price = 1.5, Unit = "Dinars"},
                new ProductModel (){ Id = 0, Name = "Tomate", Price = 1.5, Unit = "Dinars"},
                new ProductModel (){ Id = 0, Name = "Tomate", Price = 1.5, Unit = "Dinars"},
                new ProductModel (){ Id = 0, Name = "Tomate", Price = 1.5, Unit = "Dinars"},
            };

            Products = new ObservableCollection<ProductModel>(products);
        }

        private async Task OnProductTap(ProductModel ProductModel)
        {
            await _iNavigationService.NavigateTo(PageKeys.PRODUCTS);
        }
        #endregion
    }
}
