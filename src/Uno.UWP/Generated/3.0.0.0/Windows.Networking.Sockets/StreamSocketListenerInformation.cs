#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StreamSocketListenerInformation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string LocalPort
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StreamSocketListenerInformation.LocalPort is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StreamSocketListenerInformation.LocalPort");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.Sockets.StreamSocketListenerInformation.LocalPort.get
	}
}
