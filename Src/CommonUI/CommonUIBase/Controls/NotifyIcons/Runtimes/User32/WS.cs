﻿/*
 代码出自项目：https://github.com/WPFDevelopersOrg/WPFDevelopers.git
 */

namespace CommonUIBase.Controls.Runtimes.User32
{
    [Flags]
    public enum WS : uint
    {
        OVERLAPPED = 0U,
        POPUP = 2147483648U,
        CHILD = 1073741824U,
        MINIMIZE = 536870912U,
        VISIBLE = 268435456U,
        DISABLED = 134217728U,
        CLIPSIBLINGS = 67108864U,
        CLIPCHILDREN = 33554432U,
        MAXIMIZE = 16777216U,
        BORDER = 8388608U,
        DLGFRAME = 4194304U,
        VSCROLL = 2097152U,
        HSCROLL = 1048576U,
        SYSMENU = 524288U,
        THICKFRAME = 262144U,
        GROUP = 131072U,
        TABSTOP = 65536U,
        MINIMIZEBOX = 131072U,
        MAXIMIZEBOX = 65536U,
        CAPTION = 12582912U,
        TILED = 0U,
        ICONIC = 536870912U,
        SIZEBOX = 262144U,
        TILEDWINDOW = 13565952U,
        OVERLAPPEDWINDOW = 13565952U,
        POPUPWINDOW = 2156396544U,
        CHILDWINDOW = 1073741824U
    }
}