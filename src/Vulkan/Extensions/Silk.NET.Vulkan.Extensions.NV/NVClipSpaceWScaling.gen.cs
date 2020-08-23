// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_clip_space_w_scaling")]
    public unsafe partial class NVClipSpaceWScaling : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_clip_space_w_scaling";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingNV")]
        public unsafe partial void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ViewportWScalingNV* pViewportWScalings);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportWScalingNV")]
        public partial void CmdSetViewportWScaling([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] in ViewportWScalingNV pViewportWScalings);

        public NVClipSpaceWScaling(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

