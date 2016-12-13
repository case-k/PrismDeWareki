using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDeWareki.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDeWareki.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _deviceDate;
        public string DeviceDate
        {
            get { return _deviceDate; }
            set { SetProperty(ref _deviceDate, value); }
        }

        private string _deviceTime;
        public string DeviceTime
        {
            get { return _deviceTime; }
            set { SetProperty(ref _deviceTime, value); }
        }


        public MainPageViewModel(IDeviceInfoService DeviceInfoService)
        {
            DeviceDate = DeviceInfoService.ConvertToDeviceLongDateFormat(DateTime.Now);
            DeviceTime = DeviceInfoService.ConvertToDeviceTimeFormat(DateTime.Now);
        }
    }
}
