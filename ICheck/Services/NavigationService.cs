/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using ICheck.Views;
using ICheck.Models;
using System.Threading.Tasks;
using ICheck.Interfaces.IServices;

namespace ICheck.Services
{
    public class NavigationService : INavigationService
    {
        public async Task GoBack()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task NavigateTo(PageKeys pageKey)
        {
            switch (pageKey)
            {
                case PageKeys.PRODUCTS:
                    await App.Current.MainPage.Navigation.PushAsync(new ProductsView());
                    break;
                case PageKeys.ORDERS:
                    await App.Current.MainPage.Navigation.PushAsync(new OrdersView());
                    break;
                case PageKeys.HISTORY:
                    await App.Current.MainPage.Navigation.PushAsync(new HistoryView());
                    break;
                case PageKeys.ALERTS:
                    await App.Current.MainPage.Navigation.PushAsync(new AlertsView());
                    break;
                case PageKeys.CONTACTS:
                    await App.Current.MainPage.Navigation.PushAsync(new ContactsView());
                    break;
                case PageKeys.ABOUT:
                    await App.Current.MainPage.Navigation.PushAsync(new AboutView());
                    break;
                default:
                    break;
            }
        }

        public async Task NavigateTo(PageKeys pageKey, object parameter)
        {
            switch (pageKey)
            {
                case PageKeys.PRODUCTS:
                    await App.Current.MainPage.Navigation.PushAsync(new ProductsView());
                    break;
                case PageKeys.ORDERS:
                    await App.Current.MainPage.Navigation.PushAsync(new OrdersView());
                    break;
                case PageKeys.HISTORY:
                    await App.Current.MainPage.Navigation.PushAsync(new HistoryView());
                    break;
                case PageKeys.ALERTS:
                    await App.Current.MainPage.Navigation.PushAsync(new AlertsView());
                    break;
                case PageKeys.CONTACTS:
                    await App.Current.MainPage.Navigation.PushAsync(new ContactsView());
                    break;
                case PageKeys.ABOUT:
                    await App.Current.MainPage.Navigation.PushAsync(new AboutView());
                    break;
                default:                    
                    break;
            }
        }
    }
}
