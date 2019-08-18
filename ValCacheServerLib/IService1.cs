using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace ValCacheServerLib
{
    [ServiceContract]
    public interface IFileServer
    {
        [OperationContract]
        Stream GetFile(string filename);

        [OperationContract]
        string[] GetAvailableFiles();
    }
}
