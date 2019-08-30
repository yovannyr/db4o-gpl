// -----------------------------------------------------------------------
// <copyright file="NetCoreCLi.cs" company="Arvato eCommerce Verwaltungsgesellschaft mbH">
//     (c) 2019 Arvato eCommerce Verwaltungsgesellschaft mbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
using System.IO;
using System.Runtime.InteropServices;

namespace Db4o.Internal.CLI
{
  internal class NetCoreCli : CLIBase
  {
    [System.Security.SecuritySafeCritical]
    public override void Flush(FileStream stream)
    {
      stream.Flush(true);
    }
  }
}

