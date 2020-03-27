/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using ICheck.Services;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Xamarin.Forms.Internals;
using ICheck.Interfaces.IServices;

namespace ICheck.ViewModels
{
    class ViewModelLocator
    {
        [Preserve]
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<AboutViewModel>();
            SimpleIoc.Default.Register<AlertsViewModel>();
            SimpleIoc.Default.Register<OrdersViewModel>();
            SimpleIoc.Default.Register<HistoryViewModel>();
            SimpleIoc.Default.Register<ContactsViewModel>();
            SimpleIoc.Default.Register<ProductsViewModel>();

            SimpleIoc.Default.Register<INavigationService, NavigationService>();
        }

        public HomeViewModel Home
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HomeViewModel>();
            }
        }

        public AboutViewModel About
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AboutViewModel>();
            }
        }

        public AlertsViewModel Alerts
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AlertsViewModel>();
            }
        }

        public OrdersViewModel Orders
        {
            get
            {
                return ServiceLocator.Current.GetInstance<OrdersViewModel>();
            }
        }
        
        public HistoryViewModel History
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HistoryViewModel>();
            }
        }
        
        public ContactsViewModel Contacts
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ContactsViewModel>();
            }
        }
        
        public ProductsViewModel Products
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProductsViewModel>();
            }
        }
    }
}
