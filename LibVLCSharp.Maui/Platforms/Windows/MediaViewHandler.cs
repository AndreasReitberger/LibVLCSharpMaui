﻿using LibVLCSharp.Maui.Platforms.Windows;
using LibVLCSharp.Maui.Shared;
using Microsoft.Maui.Handlers;

namespace LibVLCSharp.Maui;

// All the code in this file is only included on Windows.
public partial class MediaViewHandler : ViewHandler<IMediaView, VideoView>
{
    protected override VideoView CreatePlatformView()
    {
        return new VideoView();
    }

    public static void MapMediaPlayer(MediaViewHandler handler, IMediaView view)
    {

    }
}