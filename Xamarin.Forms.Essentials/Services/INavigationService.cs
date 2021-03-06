﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Pages;

namespace FormsUtils.Services
{
    public interface INavigationService
    {
        Task PresentAsync<TPage>() where TPage : Page;

        Task PresentAsync<TPage, TArgs>(TArgs args) where TPage : Page;

        Task PresentModalAsync<TPage>(bool addToNavigationPage = false) where TPage : Page;

        Task PresentModalAsync<TPage, TArgs>(TArgs args, bool addToNavigationPage = false) where TPage : Page;

        Task DismissAsync();

        Task DismissModalAsync();

        Task PresentPopupAsync<TPage>() where TPage : PopupPage;

        Task PresentPopupAsync<TPage, TArgs>(TArgs args) where TPage : PopupPage;

        Task DismissPopupAsync();
    }
}
