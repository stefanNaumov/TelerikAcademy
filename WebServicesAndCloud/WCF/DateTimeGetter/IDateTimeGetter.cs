using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DateTimeGetter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDateTimeGetter" in both code and config file together.
    [ServiceContract]
    public interface IDateTimeGetter
    {
        [OperationContract]
        string GetDateGetDayOfWeek(DateTime date);
    }
}
