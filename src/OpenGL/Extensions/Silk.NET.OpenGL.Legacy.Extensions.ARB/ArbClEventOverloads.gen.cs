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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbClEventOverloads
    {
        public static unsafe IntPtr CreateSyncFromCLevent(this ArbClEvent thisApi, [Flow(FlowDirection.Out)] IntPtr* context, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.In)] uint flags)
        {
            // SpanOverloader
            return thisApi.CreateSyncFromCLevent(context, out @event.GetPinnableReference(), flags);
        }

        public static unsafe IntPtr CreateSyncFromCLevent(this ArbClEvent thisApi, [Flow(FlowDirection.Out)] Span<IntPtr> context, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.In)] uint flags)
        {
            // SpanOverloader
            return thisApi.CreateSyncFromCLevent(out context.GetPinnableReference(), @event, flags);
        }

        public static unsafe IntPtr CreateSyncFromCLevent(this ArbClEvent thisApi, [Flow(FlowDirection.Out)] Span<IntPtr> context, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.In)] uint flags)
        {
            // SpanOverloader
            return thisApi.CreateSyncFromCLevent(out context.GetPinnableReference(), out @event.GetPinnableReference(), flags);
        }

    }
}

