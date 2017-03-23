﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Aggregator;
using Telegram.Api.Helpers;
using Telegram.Api.Services;
using Telegram.Api.Services.Cache;
using Telegram.Api.Services.FileManager;
using Telegram.Api.TL;
using Template10.Utils;
using Unigram.Core.Dependency;
using Unigram.Services;
using Windows.UI.Xaml.Navigation;

namespace Unigram.ViewModels.Settings
{
    public class SettingsStickersFeaturedViewModel : UnigramViewModelBase
    {
        private readonly IStickersService _stickersService;

        public SettingsStickersFeaturedViewModel(IMTProtoService protoService, ICacheService cacheService, ITelegramEventAggregator aggregator, IStickersService stickersService)
            : base(protoService, cacheService, aggregator)
        {
            _stickersService = stickersService;
            _stickersService.FeaturedStickersDidLoaded += OnFeaturedStickersDidLoaded;

            Items = new ObservableCollection<TLStickerSetCoveredBase>();
        }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (mode == NavigationMode.New)
            {
                Execute.BeginOnThreadPool(() =>
                {
                    _stickersService.CheckFeaturedStickers();
                });
            }

            return Task.CompletedTask;
        }

        private void OnFeaturedStickersDidLoaded(object sender, FeaturedStickersDidLoadedEventArgs e)
        {
            ProcessStickerSets();
        }

        private void ProcessStickerSets()
        {
            var stickers = _stickersService.GetFeaturedStickerSets();
            Execute.BeginOnUIThread(() =>
            {
                Items.AddRange(stickers, true);
            });
        }

        public ObservableCollection<TLStickerSetCoveredBase> Items { get; private set; }
    }
}
