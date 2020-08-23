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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrGetDisplayProperties2Overloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayModeProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] Span<DisplayModeProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties2(physicalDevice, display, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayModeProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayModeProperties2KHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties2(physicalDevice, display, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayModeProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] Span<DisplayModeProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetDisplayModeProperties2(physicalDevice, display, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayPlaneCapabilities2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DisplayPlaneInfo2KHR* pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DisplayPlaneCapabilities2KHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities2(physicalDevice, pDisplayPlaneInfo, out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayPlaneCapabilities2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayPlaneInfo2KHR> pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayPlaneCapabilities2KHR* pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities2(physicalDevice, in pDisplayPlaneInfo.GetPinnableReference(), pCapabilities);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayPlaneCapabilities2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<DisplayPlaneInfo2KHR> pDisplayPlaneInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DisplayPlaneCapabilities2KHR> pCapabilities)
        {
            // SpanOverloader
            return thisApi.GetDisplayPlaneCapabilities2(physicalDevice, in pDisplayPlaneInfo.GetPinnableReference(), out pCapabilities.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] Span<DisplayPlaneProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPlaneProperties2KHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayPlaneProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] Span<DisplayPlaneProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayPlaneProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] Span<DisplayProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties2(physicalDevice, pPropertyCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayProperties2KHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPhysicalDeviceDisplayProperties2(this KhrGetDisplayProperties2 thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] Span<DisplayProperties2KHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceDisplayProperties2(physicalDevice, ref pPropertyCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

    }
}

