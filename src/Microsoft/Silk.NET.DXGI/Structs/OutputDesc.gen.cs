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
    [NativeName("Name", "DXGI_OUTPUT_DESC")]
    public unsafe partial struct OutputDesc
    {
        public OutputDesc
        (
            Silk.NET.Core.Runtime.Windows.TagRect desktopCoordinates = default,
            int attachedToDesktop = default,
            ModeRotation rotation = default,
            IntPtr monitor = default
        )
        {
            DesktopCoordinates = desktopCoordinates;
            AttachedToDesktop = attachedToDesktop;
            Rotation = rotation;
            Monitor = monitor;
        }

        [NativeName("Type", "WCHAR [32]")]
        [NativeName("Type.Name", "WCHAR [32]")]
        [NativeName("Name", "DeviceName")]
        public fixed char DeviceName[32];

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DesktopCoordinates")]
        public Silk.NET.Core.Runtime.Windows.TagRect DesktopCoordinates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AttachedToDesktop")]
        public int AttachedToDesktop;

        [NativeName("Type", "DXGI_MODE_ROTATION")]
        [NativeName("Type.Name", "DXGI_MODE_ROTATION")]
        [NativeName("Name", "Rotation")]
        public ModeRotation Rotation;

        [NativeName("Type", "HMONITOR")]
        [NativeName("Type.Name", "HMONITOR")]
        [NativeName("Name", "Monitor")]
        public IntPtr Monitor;
    }
}