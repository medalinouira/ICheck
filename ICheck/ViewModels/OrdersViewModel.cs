/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;
using ICheck.Models;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using System.Collections.Generic;
using ICheck.Interfaces.IServices;
using System.Collections.ObjectModel;

namespace ICheck.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<OrderModel> _orders;
        #endregion

        #region Properties
        public ObservableCollection<OrderModel> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged(nameof(Orders));
            }
        }
        #endregion

        #region Commands
        public ICommand OnOrderTapCommand { get; set; }
        #endregion

        #region Constructor
        [Preserve]
        public OrdersViewModel(INavigationService _iNavigationService)
        {
            this._iNavigationService = _iNavigationService;

            OnOrderTapCommand = new Command<OrderModel>(async (order) => await OnProductTap(order));

            GetOrders();
        }
        #endregion

        #region Methods
        private void GetOrders()
        {
            var orders = new ObservableCollection<OrderModel>()
            {
                new OrderModel (){ Id = 0, Label = "Pour ma mère", Date = DateTime.Now.AddDays(-1), Products = new List<KeyValuePair<int, ProductModel>>{
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 0.2}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 3}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 6})
                }},
                new OrderModel (){ Id = 0, Label = "Fête de l'aaide", Date = DateTime.Now.AddDays(-6), Products = new List<KeyValuePair<int, ProductModel>>{
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 0.4}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 1}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 3})
                }},
                new OrderModel (){ Id = 0, Label = "Anniversaire de Lyne", Date = DateTime.Now.AddDays(-10), Products = new List<KeyValuePair<int, ProductModel>>{
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 0.6}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 3}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 12})
                }},
                new OrderModel (){ Id = 0, Label = "Course de la semaine", Date = DateTime.Now.AddDays(-15), Products = new List<KeyValuePair<int, ProductModel>>{
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 0.8}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 5}),
                    new KeyValuePair<int, ProductModel>(key: 3, new ProductModel(){Id = 0, Price = 9})
                }},
            };

            Orders = new ObservableCollection<OrderModel>(orders);
        }

        private async Task OnProductTap(OrderModel order)
        {
            await _iNavigationService.NavigateTo(PageKeys.ORDERS);
        }
        #endregion
    }
}
