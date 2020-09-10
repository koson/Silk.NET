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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_COORDINATE")]
    public unsafe partial struct ResourceCoordinate
    {
        public ResourceCoordinate
        (
            ulong x = default,
            uint y = default,
            uint z = default,
            uint subresourceIndex = default
        )
        {
            X = x;
            Y = y;
            Z = z;
            SubresourceIndex = subresourceIndex;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "X")]
        public ulong X;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Y")]
        public uint Y;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Z")]
        public uint Z;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubresourceIndex")]
        public uint SubresourceIndex;
    }
}