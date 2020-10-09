// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Contains all window properties, used for window creation.
    /// </summary>
    public struct WindowOptions : IWindowProperties
    {
        /// <summary>
        /// Creates an instance of WindowOptions from an existing ViewOptions struct.
        /// </summary>
        /// <param name="opts">The view options to copy where applicable.</param>
        public WindowOptions(ViewOptions opts)
        {
            IsVisible = true;
            Position = new Point(50, 50);
            Size = new Size(1280, 720);
            FramesPerSecond = opts.FramesPerSecond;
            UpdatesPerSecond = opts.UpdatesPerSecond;
            API = opts.API;
            Title = Assembly.GetEntryAssembly()?.GetName().Name ?? "Silk.NET Window";
            WindowState = WindowState.Normal;
            WindowBorder = WindowBorder.Resizable;
            ShouldSwapAutomatically = opts.ShouldSwapAutomatically;
            VideoMode = opts.VideoMode;
            PreferredDepthBufferBits = opts.PreferredDepthBufferBits;
            TransparentFramebuffer = false;
            IsEventDriven = opts.IsEventDriven;
            VSync = opts.VSync;
        }

        /// <inheritdoc />
        public bool IsVisible { get; set; }

        /// <inheritdoc />
        public bool ShouldSwapAutomatically { get; set; }

        /// <inheritdoc />
        public bool IsEventDriven { get; set; }

        /// <inheritdoc />
        public VideoMode VideoMode { get; set; }

        /// <inheritdoc />
        public int? PreferredDepthBufferBits { get; set; }

        /// <inheritdoc />
        public Point Position { get; set; }

        /// <inheritdoc cref="IWindowProperties" />
        public Size Size { get; set; }

        /// <inheritdoc />
        public double FramesPerSecond { get; set; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }

        /// <inheritdoc />
        public GraphicsAPI API { get; set; }

        /// <inheritdoc />
        public bool VSync { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }

        /// <inheritdoc />
        public WindowState WindowState { get; set; }

        /// <inheritdoc />
        public WindowBorder WindowBorder { get; set; }

        /// <inheritdoc />
        public bool TransparentFramebuffer { get; set; }

        /// <summary>
        /// Creates a new WindowOptions struct.
        /// </summary>
        public WindowOptions
        (
            bool isVisible,
            Point position,
            Size size,
            double framesPerSecond,
            double updatesPerSecond,
            GraphicsAPI api,
            string title,
            WindowState windowState,
            WindowBorder windowBorder,
            bool isVSync,
            bool shouldSwapAutomatically,
            VideoMode videoMode,
            int? preferredDepthBufferBits = null,
            bool transparentFramebuffer = false,
            bool isEventDriven = false
        )
        {
            IsVisible = isVisible;
            Position = position;
            Size = size;
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            Title = title;
            WindowState = windowState;
            WindowBorder = windowBorder;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            PreferredDepthBufferBits = preferredDepthBufferBits;
            TransparentFramebuffer = transparentFramebuffer;
            IsEventDriven = isEventDriven;
            VSync = isVSync;
        }

        static WindowOptions()
        {
            string name = "Silk.NET Window";
            try
            {
                var asmName = Assembly.GetEntryAssembly()?.GetName().Name;
                if (asmName is not null)
                    name = asmName;
            }
            catch { /* cannot use reflection */ }
            
            Default = new WindowOptions
            (
                true, new Point(50, 50), new Size(1280, 720), 0.0, 0.0, GraphicsAPI.Default,
                name, WindowState.Normal,
                WindowBorder.Resizable, true, true, VideoMode.Default
            );

            DefaultVulkan = new WindowOptions
            (
                true, new Point(50, 50), new Size(1280, 720), 0.0, 0.0, GraphicsAPI.DefaultVulkan,
                name, WindowState.Normal,
                WindowBorder.Resizable, false, false, VideoMode.Default
            );
        }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible defaults.
        /// </summary>
        public static WindowOptions Default { get; }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible values, intended for use with Vulkan.
        /// </summary>
        public static WindowOptions DefaultVulkan { get; }
    }
}