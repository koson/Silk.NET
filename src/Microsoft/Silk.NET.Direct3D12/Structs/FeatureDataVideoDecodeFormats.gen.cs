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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS")]
    public unsafe partial struct FeatureDataVideoDecodeFormats
    {
        public FeatureDataVideoDecodeFormats
        (
            uint nodeIndex = default,
            VideoDecodeConfiguration configuration = default,
            uint formatCount = default,
            Silk.NET.DXGI.Format* pOutputFormats = default
        )
        {
            NodeIndex = nodeIndex;
            Configuration = configuration;
            FormatCount = formatCount;
            POutputFormats = pOutputFormats;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_CONFIGURATION")]
        [NativeName("Name", "Configuration")]
        public VideoDecodeConfiguration Configuration;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FormatCount")]
        public uint FormatCount;

        [NativeName("Type", "DXGI_FORMAT *")]
        [NativeName("Type.Name", "DXGI_FORMAT *")]
        [NativeName("Name", "pOutputFormats")]
        public Silk.NET.DXGI.Format* POutputFormats;
    }
}