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
using ICheck.Interfaces.IServices;

namespace ICheck.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Fields
        private string _copyRightsText;
        #endregion

        #region Properties
        public string CopyRightsText
        {
            get { return _copyRightsText; }
            set
            {
                _copyRightsText = value;
                OnPropertyChanged(nameof(CopyRightsText));
            }
        }
        #endregion

        #region Commands
        public ICommand OnGridTapCommand { get; set; }
        #endregion

        #region Constructor
        [Preserve]
        public HomeViewModel(INavigationService _iNavigationService)
        {
            this._iNavigationService = _iNavigationService;

            CopyRightsText = "Copyright © All rights reserved." + Environment.NewLine + "Abdeljelil MAROUANI | Mohamed Ali NOUIRA.";

            OnGridTapCommand = new Command<string>(async (pageKey) => await OnGridTap(pageKey));
        }
        #endregion

        #region Methods
        private async Task OnGridTap(string pageKey)
        {
            await _iNavigationService.NavigateTo((PageKeys)int.Parse(pageKey));
        }
        #endregion
    }
}
