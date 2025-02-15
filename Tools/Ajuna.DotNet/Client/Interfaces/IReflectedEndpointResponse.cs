﻿using System.Collections.Generic;

namespace Ajuna.DotNet.Client.Interfaces
{
   /// <summary>
   /// Interface that represents a REST Service controller method response.
   /// </summary>
   internal interface IReflectedEndpointResponse
   {
      /// <summary>
      /// Dictionary that holds HTTP status codes and its response type.
      /// </summary>
      Dictionary<int, IReflectedEndpointType> GetReturnTypesByStatusCode();
   }
}
