/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using ICheck.Models;
using System.Threading.Tasks;

namespace ICheck.Interfaces.IServices
{
    public interface INavigationService
    {
        Task GoBack();
        Task NavigateTo(PageKeys pageKey);
        Task NavigateTo(PageKeys pageKey, object parameter);
    }
}
