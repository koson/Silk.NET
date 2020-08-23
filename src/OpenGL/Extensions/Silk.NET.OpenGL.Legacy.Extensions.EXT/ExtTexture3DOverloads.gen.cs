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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtTexture3DOverloads
    {
        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

        public static unsafe void TexSubImage3D<T0>(this ExtTexture3D thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pixels) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, in pixels.GetPinnableReference());
        }

    }
}

