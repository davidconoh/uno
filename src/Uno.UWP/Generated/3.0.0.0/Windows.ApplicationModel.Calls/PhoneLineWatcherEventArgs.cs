#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Calls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PhoneLineWatcherEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Guid LineId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid PhoneLineWatcherEventArgs.LineId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Guid%20PhoneLineWatcherEventArgs.LineId");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs.LineId.get
	}
}
