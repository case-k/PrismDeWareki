using Foundation;
using PrismDeWareki.iOS.Services;
using PrismDeWareki.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceInfoServiceImplementation))]

namespace PrismDeWareki.iOS.Services
{
    public class DeviceInfoServiceImplementation : IDeviceInfoService
    {
        public string ConvertToDeviceLongDateFormat(DateTime inputDateTime)
        {
            var timeInEpoch = Helper.ConvertDateTimeToUnixTime(inputDateTime);

            if (timeInEpoch == null)
            {
                return string.Empty;
            }

            using (var dateInNsDate = NSDate.FromTimeIntervalSince1970((double)timeInEpoch))
            {
                using (var formatter = new NSDateFormatter
                {
                    TimeStyle = NSDateFormatterStyle.None,
                    DateStyle = NSDateFormatterStyle.Long,
                    Locale = NSLocale.CurrentLocale
                })
                {
                    return formatter.ToString(dateInNsDate);
                }
            }
        }

        public string ConvertToDeviceShortDateFormat(DateTime inputDateTime)
        {
            var timeInEpoch = Helper.ConvertDateTimeToUnixTime(inputDateTime);

            if (timeInEpoch == null)
            {
                return string.Empty;
            }

            using (var dateInNsDate = NSDate.FromTimeIntervalSince1970((double)timeInEpoch))
            {
                using (var formatter = new NSDateFormatter
                {
                    TimeStyle = NSDateFormatterStyle.None,
                    DateStyle = NSDateFormatterStyle.Short,
                    Locale = NSLocale.CurrentLocale
                })
                {
                    return formatter.ToString(dateInNsDate);
                }
            }
        }

        public string ConvertToDeviceTimeFormat(DateTime inputDateTime)
        {
            var timeInEpoch = Helper.ConvertDateTimeToUnixTime(inputDateTime);

            if (timeInEpoch == null)
            {
                return string.Empty;
            }

            using (var dateInNsDate = NSDate.FromTimeIntervalSince1970((double)timeInEpoch))
            {
                using (var formatter = new NSDateFormatter
                {
                    TimeStyle = NSDateFormatterStyle.Short,
                    DateStyle = NSDateFormatterStyle.None,
                    Locale = NSLocale.CurrentLocale
                })
                {
                    return formatter.ToString(dateInNsDate);
                }
            }
        }
    }
}