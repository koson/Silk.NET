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
    [NativeName("Name", "__AnonymousRecord_d3d12_L3963_C9")]
    public unsafe partial struct AnonymousRecordD3d12L3963C9
    {
        public AnonymousRecordD3d12L3963C9
        (
            uint rootParameterIndex = default
        )
        {
            RootParameterIndex = rootParameterIndex;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RootParameterIndex")]
        public uint RootParameterIndex;
    }
}