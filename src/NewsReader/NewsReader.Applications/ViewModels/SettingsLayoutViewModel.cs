﻿using Jbe.NewsReader.Applications.Views;
using System.Composition;
using System.Waf.Applications;

namespace Jbe.NewsReader.Applications.ViewModels
{
    [Export, Shared]
    public class SettingsLayoutViewModel : ViewModel<ISettingsLayoutView>
    {
        [ImportingConstructor]
        public SettingsLayoutViewModel(ISettingsLayoutView view) : base(view)
        {
        }
    }
}
