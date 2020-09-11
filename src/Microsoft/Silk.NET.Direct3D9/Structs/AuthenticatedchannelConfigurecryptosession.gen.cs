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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION")]
    public unsafe partial struct AuthenticatedchannelConfigurecryptosession
    {
        public AuthenticatedchannelConfigurecryptosession
        (
            AuthenticatedchannelConfigureInput parameters = default,
            void* dXVA2DecodeHandle = default,
            void* cryptoSessionHandle = default,
            void* deviceHandle = default
        )
        {
            Parameters = parameters;
            DXVA2DecodeHandle = dXVA2DecodeHandle;
            CryptoSessionHandle = cryptoSessionHandle;
            DeviceHandle = deviceHandle;
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedchannelConfigureInput Parameters;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DXVA2DecodeHandle")]
        public void* DXVA2DecodeHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "CryptoSessionHandle")]
        public void* CryptoSessionHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DeviceHandle")]
        public void* DeviceHandle;
    }
}