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
    [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS")]
    public unsafe partial struct RenderPassEndingAccessResolveSubresourceParameters
    {
        public RenderPassEndingAccessResolveSubresourceParameters
        (
            uint srcSubresource = default,
            uint dstSubresource = default,
            uint dstX = default,
            uint dstY = default,
            Silk.NET.Core.Runtime.Windows.TagRect srcRect = default
        )
        {
            SrcSubresource = srcSubresource;
            DstSubresource = dstSubresource;
            DstX = dstX;
            DstY = dstY;
            SrcRect = srcRect;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SrcSubresource")]
        public uint SrcSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DstSubresource")]
        public uint DstSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DstX")]
        public uint DstX;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DstY")]
        public uint DstY;

        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "SrcRect")]
        public Silk.NET.Core.Runtime.Windows.TagRect SrcRect;
    }
}