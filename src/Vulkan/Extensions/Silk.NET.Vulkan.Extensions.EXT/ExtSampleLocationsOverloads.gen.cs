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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtSampleLocationsOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void CmdSetSampleLocation(this ExtSampleLocations thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SampleLocationsInfoEXT> pSampleLocationsInfo)
        {
            // SpanOverloader
            thisApi.CmdSetSampleLocation(commandBuffer, in pSampleLocationsInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void GetPhysicalDeviceMultisampleProperties(this ExtSampleLocations thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MultisamplePropertiesEXT> pMultisampleProperties)
        {
            // SpanOverloader
            thisApi.GetPhysicalDeviceMultisampleProperties(physicalDevice, samples, out pMultisampleProperties.GetPinnableReference());
        }

    }
}

