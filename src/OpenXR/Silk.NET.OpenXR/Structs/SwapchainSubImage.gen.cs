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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSwapchainSubImage")]
    public unsafe partial struct SwapchainSubImage
    {
        public SwapchainSubImage
        (
            Swapchain swapchain = default,
            Rect2Di imageRect = default,
            uint imageArrayIndex = default
        )
        {
            Swapchain = swapchain;
            ImageRect = imageRect;
            ImageArrayIndex = imageArrayIndex;
        }

/// <summary></summary>
        [NativeName("Type", "XrSwapchain")]
        [NativeName("Type.Name", "XrSwapchain")]
        [NativeName("Name", "swapchain")]
        public Swapchain Swapchain;
/// <summary></summary>
        [NativeName("Type", "XrRect2Di")]
        [NativeName("Type.Name", "XrRect2Di")]
        [NativeName("Name", "imageRect")]
        public Rect2Di ImageRect;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageArrayIndex")]
        public uint ImageArrayIndex;
    }
}
