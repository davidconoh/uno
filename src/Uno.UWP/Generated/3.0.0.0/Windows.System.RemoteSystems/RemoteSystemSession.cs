#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RemoteSystemSession : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ControllerDisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemSession.ControllerDisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20RemoteSystemSession.ControllerDisplayName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemSession.DisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20RemoteSystemSession.DisplayName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemSession.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20RemoteSystemSession.Id");
			}
		}
#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSession.Id.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSession.DisplayName.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSession.ControllerDisplayName.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSession.Disconnected.add
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSession.Disconnected.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcher CreateParticipantWatcher()
		{
			throw new global::System.NotImplementedException("The member RemoteSystemSessionParticipantWatcher RemoteSystemSession.CreateParticipantWatcher() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemSessionParticipantWatcher%20RemoteSystemSession.CreateParticipantWatcher%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> SendInvitationAsync( global::Windows.System.RemoteSystems.RemoteSystem invitee)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> RemoteSystemSession.SendInvitationAsync(RemoteSystem invitee) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20RemoteSystemSession.SendInvitationAsync%28RemoteSystem%20invitee%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemSession", "void RemoteSystemSession.Dispose()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.RemoteSystems.RemoteSystemSessionWatcher CreateWatcher()
		{
			throw new global::System.NotImplementedException("The member RemoteSystemSessionWatcher RemoteSystemSession.CreateWatcher() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemSessionWatcher%20RemoteSystemSession.CreateWatcher%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.System.RemoteSystems.RemoteSystemSession, global::Windows.System.RemoteSystems.RemoteSystemSessionDisconnectedEventArgs> Disconnected
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemSession", "event TypedEventHandler<RemoteSystemSession, RemoteSystemSessionDisconnectedEventArgs> RemoteSystemSession.Disconnected");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.System.RemoteSystems.RemoteSystemSession", "event TypedEventHandler<RemoteSystemSession, RemoteSystemSessionDisconnectedEventArgs> RemoteSystemSession.Disconnected");
			}
		}
#endif
		// Processing: System.IDisposable
	}
}
