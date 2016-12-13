using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDeWareki.Services
{
    public interface IDeviceInfoService
    {
        string ConvertToDeviceShortDateFormat(DateTime inputDateTime);
        string ConvertToDeviceLongDateFormat(DateTime inputDateTime);
        string ConvertToDeviceTimeFormat(DateTime inputDateTime);
    }
}
