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
    [NativeName("Name", "CD3D11_TEXTURE3D_DESC1")]
    public unsafe partial struct CD3D11Texture3DDesc1
    {
        public CD3D11Texture3DDesc1
        (
            uint width = default,
            uint height = default,
            uint depth = default,
            uint mipLevels = default,
            Silk.NET.DXGI.Format format = default,
            Usage usage = default,
            uint bindFlags = default,
            uint cPUAccessFlags = default,
            uint miscFlags = default,
            TextureLayout textureLayout = default
        )
        {
            Width = width;
            Height = height;
            Depth = depth;
            MipLevels = mipLevels;
            Format = format;
            Usage = usage;
            BindFlags = bindFlags;
            CPUAccessFlags = cPUAccessFlags;
            MiscFlags = miscFlags;
            TextureLayout = textureLayout;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Depth")]
        public uint Depth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D11_USAGE")]
        [NativeName("Type.Name", "D3D11_USAGE")]
        [NativeName("Name", "Usage")]
        public Usage Usage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindFlags")]
        public uint BindFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CPUAccessFlags")]
        public uint CPUAccessFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;

        [NativeName("Type", "D3D11_TEXTURE_LAYOUT")]
        [NativeName("Type.Name", "D3D11_TEXTURE_LAYOUT")]
        [NativeName("Name", "TextureLayout")]
        public TextureLayout TextureLayout;
    }
}