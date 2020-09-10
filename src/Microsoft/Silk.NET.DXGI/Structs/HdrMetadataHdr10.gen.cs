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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_HDR_METADATA_HDR10")]
    public unsafe partial struct HdrMetadataHdr10
    {
        public HdrMetadataHdr10
        (
            uint maxMasteringLuminance = default,
            uint minMasteringLuminance = default,
            ushort maxContentLightLevel = default,
            ushort maxFrameAverageLightLevel = default
        )
        {
            MaxMasteringLuminance = maxMasteringLuminance;
            MinMasteringLuminance = minMasteringLuminance;
            MaxContentLightLevel = maxContentLightLevel;
            MaxFrameAverageLightLevel = maxFrameAverageLightLevel;
        }

        [NativeName("Type", "UINT16 [2]")]
        [NativeName("Type.Name", "UINT16 [2]")]
        [NativeName("Name", "RedPrimary")]
        public fixed ushort RedPrimary[2];
        [NativeName("Type", "UINT16 [2]")]
        [NativeName("Type.Name", "UINT16 [2]")]
        [NativeName("Name", "GreenPrimary")]
        public fixed ushort GreenPrimary[2];
        [NativeName("Type", "UINT16 [2]")]
        [NativeName("Type.Name", "UINT16 [2]")]
        [NativeName("Name", "BluePrimary")]
        public fixed ushort BluePrimary[2];
        [NativeName("Type", "UINT16 [2]")]
        [NativeName("Type.Name", "UINT16 [2]")]
        [NativeName("Name", "WhitePoint")]
        public fixed ushort WhitePoint[2];

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxMasteringLuminance")]
        public uint MaxMasteringLuminance;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MinMasteringLuminance")]
        public uint MinMasteringLuminance;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "MaxContentLightLevel")]
        public ushort MaxContentLightLevel;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "MaxFrameAverageLightLevel")]
        public ushort MaxFrameAverageLightLevel;
    }
}