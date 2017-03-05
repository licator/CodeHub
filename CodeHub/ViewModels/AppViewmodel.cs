﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Octokit;
using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using CodeHub.Services;
using JetBrains.Annotations;

namespace CodeHub.ViewModels
{
    public class AppViewmodel : ViewModelBase
    {
        public bool _hasInternet;
        public bool HasInternet
        {
            get
            {
                return _hasInternet;
            }
            set
            {
                Set(() => HasInternet, ref _hasInternet, value);
            }
        }

        public bool _isLoggedin;
        public bool isLoggedin
        {
            get
            {
                return _isLoggedin;
            }
            set
            {
                Set(() => isLoggedin, ref _isLoggedin, value);
            }
        }

        public bool _isLoading;
        public bool isLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                Set(() => isLoading, ref _isLoading, value);
            }
        }

        public User _user;
        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                Set(() => User, ref _user, value);
            }
        }

        public void Navigate(Type pageType, string pageTitle)
        {
            SimpleIoc.Default.GetInstance<Services.IAsyncNavigationService>().NavigateAsync(pageType, pageTitle, User);
        }
        public void GoBack()
        {
            SimpleIoc.Default.GetInstance<Services.IAsyncNavigationService>().GoBackAsync();
        }
    }
}
