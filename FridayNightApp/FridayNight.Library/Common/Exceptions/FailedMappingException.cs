using FridayNight.Library.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FridayNight.Library.Common.Exceptions
{
    public class FailedMappingException : LibraryExceptionBase
    {
        public FailedMappingException(object fromObj, Type toType) 
            : base($"Unable to proceed mapping of object {fromObj} to type {toType.Name}.") { }

        public FailedMappingException(object fromObj, Type fromType, Type toType)
            : base($"Unable to proceed mapping object {fromObj} of type {fromType.Name} to type {toType.Name}.") { }

        public FailedMappingException(IEnumerable<dynamic> fromObj, Type toType)
            : base($"Unable to proceed mapping of collection of objects {fromObj} to type {toType.Name}.") { }
    }
}
