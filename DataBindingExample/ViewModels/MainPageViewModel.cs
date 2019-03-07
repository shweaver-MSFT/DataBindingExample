using DataBindingExample.Common;
using DataBindingExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DataBindingExample.ViewModels
{
    public class MainPageViewModel : PropertyChangedNotifier
    {
        public ICommand CarouselDataItemTappedCommand { get; set; }

        private ObservableCollection<CarouselDataModel> _carousels;
        public ObservableCollection<CarouselDataModel> Carousels
        {
            get => _carousels;
            set => Set(ref _carousels, value);
        }

        public MainPageViewModel()
        {
            CarouselDataItemTappedCommand = new DelegateCommand<CarouselDataItemModel>(CarouselDataItemTapped);

            Carousels = new ObservableCollection<CarouselDataModel>()
            {
                new CarouselDataModel()
                {
                    CLabel = "CLabel goes here",
                    CItems = new List<CarouselDataItemModel>()
                    {
                        new CarouselDataItemModel("Item 1", new Uri("ms-appx:///Assets/StoreLogo.png")),
                        new CarouselDataItemModel("Item 2", new Uri("ms-appx:///Assets/StoreLogo.png")),
                        new CarouselDataItemModel("Item 3", new Uri("ms-appx:///Assets/StoreLogo.png"))
                    }
                }
            };
        }

        private void CarouselDataItemTapped(CarouselDataItemModel dataItem)
        {
            System.Diagnostics.Debug.WriteLine($"CarouselDataItem Tapped: {dataItem.Id}");
        }
    }
}
