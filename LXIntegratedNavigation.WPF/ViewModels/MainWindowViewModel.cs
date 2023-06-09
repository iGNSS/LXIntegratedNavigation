﻿using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace LXIntegratedNavigation.WPF.ViewModels;

internal partial class MainWindowViewModel : WindowViewModel
{
    #region Public Constructors    

    public MainWindowViewModel(Window window) : base(window) { }

    #endregion Public Constructors


}
