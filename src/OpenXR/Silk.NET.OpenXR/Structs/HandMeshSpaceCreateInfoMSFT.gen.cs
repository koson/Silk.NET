// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandMeshSpaceCreateInfoMSFT")]
    public unsafe partial struct HandMeshSpaceCreateInfoMSFT
    {
        public HandMeshSpaceCreateInfoMSFT
        (
            StructureType type = StructureType.TypeHandMeshSpaceCreateInfoMsft,
            void* next = default,
            HandPoseTypeMSFT handPoseType = default,
            Posef poseInHandMeshSpace = default
        )
        {
            Type = type;
            Next = next;
            HandPoseType = handPoseType;
            PoseInHandMeshSpace = poseInHandMeshSpace;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrHandPoseTypeMSFT")]
        [NativeName("Type.Name", "XrHandPoseTypeMSFT")]
        [NativeName("Name", "handPoseType")]
        public HandPoseTypeMSFT HandPoseType;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInHandMeshSpace")]
        public Posef PoseInHandMeshSpace;
    }
}