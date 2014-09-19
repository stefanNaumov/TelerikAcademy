using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Web.Services;
using System.Web.Services.Description;

namespace StringComparer
{
    [ServiceContract]
    public interface IStringComparer
    {
        [OperationContract]
        int NumberOfOccurences(string first, string second);
    }
}
