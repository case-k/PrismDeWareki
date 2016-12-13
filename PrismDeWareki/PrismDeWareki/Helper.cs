using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDeWareki
{
    public class Helper
    {

        private static readonly DateTime EpochDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long? ConvertDateTimeToUnixTime(DateTime? date, bool isDatarequiredInMilliSeconds = false, DateTimeKind dateTimeKind = DateTimeKind.Local) => date.HasValue == false
                    ? (long?)null
                    : Convert.ToInt64((DateTime.SpecifyKind(date.Value, dateTimeKind).ToUniversalTime() - EpochDateTime).TotalSeconds) * (isDatarequiredInMilliSeconds ? 1000 : 1);

    }
}
