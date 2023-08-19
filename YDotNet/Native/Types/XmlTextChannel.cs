using System.Runtime.InteropServices;

namespace YDotNet.Native.Types;

internal static class XmlTextChannel
{
    [DllImport(ChannelSettings.NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yxmltext_len")]
    public static extern uint Length(nint handle, nint transaction);

    [DllImport(ChannelSettings.NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yxmltext_insert")]
    public static extern uint Insert(nint handle, nint transaction, uint index, nint value, nint attributes);
}
