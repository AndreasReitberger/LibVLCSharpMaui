﻿using LibVLCSharp.Maui.Platforms.MacCatalyst;
using LibVLCSharp.Maui.Shared;
using Microsoft.Maui.Handlers;

namespace LibVLCSharp.Maui;

// All the code in this file is only included on Mac Catalyst.
public partial class MediaViewHandler : ViewHandler<IMediaView, VideoView>
{
    protected override VideoView CreatePlatformView()
    {
        throw new NotImplementedException();
    }

    public static void MapMediaPlayer(MediaViewHandler handler, IMediaView view)
    {

    }
}