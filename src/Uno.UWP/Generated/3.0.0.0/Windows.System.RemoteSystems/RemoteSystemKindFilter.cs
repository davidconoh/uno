#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RemoteSystemKindFilter : global::Windows.System.RemoteSystems.IRemoteSystemFilter
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<string> RemoteSystemKinds
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> RemoteSystemKindFilter.RemoteSystemKinds is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20RemoteSystemKindFilter.RemoteSystemKinds");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public RemoteSystemKindFilter( global::System.Collections.Generic.IEnumerable<string> remoteSystemKinds) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemKindFilter", "RemoteSystemKindFilter.RemoteSystemKindFilter(IEnumerable<string> remoteSystemKinds)");
		}
#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemKindFilter.RemoteSystemKindFilter(System.Collections.Generic.IEnumerable<string>)
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemKindFilter.RemoteSystemKinds.get
		// Processing: Windows.System.RemoteSystems.IRemoteSystemFilter
	}
}
