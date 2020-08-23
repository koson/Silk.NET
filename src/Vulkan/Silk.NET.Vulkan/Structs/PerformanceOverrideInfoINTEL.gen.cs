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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceOverrideInfoINTEL")]
    public unsafe partial struct PerformanceOverrideInfoINTEL
    {
        public PerformanceOverrideInfoINTEL
        (
            StructureType sType = StructureType.PerformanceOverrideInfoIntel,
            void* pNext = default,
            PerformanceOverrideTypeINTEL type = default,
            Bool32 enable = default,
            ulong parameter = default
        )
        {
            SType = sType;
            PNext = pNext;
            Type = type;
            Enable = enable;
            Parameter = parameter;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPerformanceOverrideTypeINTEL")]
        [NativeName("Type.Name", "VkPerformanceOverrideTypeINTEL")]
        [NativeName("Name", "type")]
        public PerformanceOverrideTypeINTEL Type;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "enable")]
        public Bool32 Enable;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "parameter")]
        public ulong Parameter;
    }
}
