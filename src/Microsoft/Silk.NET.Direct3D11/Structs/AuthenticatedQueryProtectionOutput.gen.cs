// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryProtectionOutput
    {
        public AuthenticatedQueryProtectionOutput
        (
            AuthenticatedQueryOutput output = default,
            AuthenticatedProtectionFlags protectionFlags = default
        )
        {
            Output = output;
            ProtectionFlags = protectionFlags;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "D3D11_AUTHENTICATED_PROTECTION_FLAGS")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_PROTECTION_FLAGS")]
        [NativeName("Name", "ProtectionFlags")]
        public AuthenticatedProtectionFlags ProtectionFlags;
    }
}