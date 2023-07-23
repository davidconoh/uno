#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFi
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WiFiAdapter 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Networking.Connectivity.NetworkAdapter NetworkAdapter
		{
			get
			{
				throw new global::System.NotImplementedException("The member NetworkAdapter WiFiAdapter.NetworkAdapter is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=NetworkAdapter%20WiFiAdapter.NetworkAdapter");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.WiFi.WiFiNetworkReport NetworkReport
		{
			get
			{
				throw new global::System.NotImplementedException("The member WiFiNetworkReport WiFiAdapter.NetworkReport is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WiFiNetworkReport%20WiFiAdapter.NetworkReport");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.WiFi.WiFiAdapter.NetworkAdapter.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ScanAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WiFiAdapter.ScanAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20WiFiAdapter.ScanAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Devices.WiFi.WiFiAdapter.NetworkReport.get
		// Forced skipping of method Windows.Devices.WiFi.WiFiAdapter.AvailableNetworksChanged.add
		// Forced skipping of method Windows.Devices.WiFi.WiFiAdapter.AvailableNetworksChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync( global::Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork,  global::Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiConnectionResult> WiFiAdapter.ConnectAsync(WiFiAvailableNetwork availableNetwork, WiFiReconnectionKind reconnectionKind) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiConnectionResult%3E%20WiFiAdapter.ConnectAsync%28WiFiAvailableNetwork%20availableNetwork%2C%20WiFiReconnectionKind%20reconnectionKind%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync( global::Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork,  global::Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind,  global::Windows.Security.Credentials.PasswordCredential passwordCredential)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiConnectionResult> WiFiAdapter.ConnectAsync(WiFiAvailableNetwork availableNetwork, WiFiReconnectionKind reconnectionKind, PasswordCredential passwordCredential) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiConnectionResult%3E%20WiFiAdapter.ConnectAsync%28WiFiAvailableNetwork%20availableNetwork%2C%20WiFiReconnectionKind%20reconnectionKind%2C%20PasswordCredential%20passwordCredential%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync( global::Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork,  global::Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind,  global::Windows.Security.Credentials.PasswordCredential passwordCredential,  string ssid)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiConnectionResult> WiFiAdapter.ConnectAsync(WiFiAvailableNetwork availableNetwork, WiFiReconnectionKind reconnectionKind, PasswordCredential passwordCredential, string ssid) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiConnectionResult%3E%20WiFiAdapter.ConnectAsync%28WiFiAvailableNetwork%20availableNetwork%2C%20WiFiReconnectionKind%20reconnectionKind%2C%20PasswordCredential%20passwordCredential%2C%20string%20ssid%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Disconnect()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFi.WiFiAdapter", "void WiFiAdapter.Disconnect()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiWpsConfigurationResult> GetWpsConfigurationAsync( global::Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiWpsConfigurationResult> WiFiAdapter.GetWpsConfigurationAsync(WiFiAvailableNetwork availableNetwork) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiWpsConfigurationResult%3E%20WiFiAdapter.GetWpsConfigurationAsync%28WiFiAvailableNetwork%20availableNetwork%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync( global::Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork,  global::Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind,  global::Windows.Security.Credentials.PasswordCredential passwordCredential,  string ssid,  global::Windows.Devices.WiFi.WiFiConnectionMethod connectionMethod)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiConnectionResult> WiFiAdapter.ConnectAsync(WiFiAvailableNetwork availableNetwork, WiFiReconnectionKind reconnectionKind, PasswordCredential passwordCredential, string ssid, WiFiConnectionMethod connectionMethod) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiConnectionResult%3E%20WiFiAdapter.ConnectAsync%28WiFiAvailableNetwork%20availableNetwork%2C%20WiFiReconnectionKind%20reconnectionKind%2C%20PasswordCredential%20passwordCredential%2C%20string%20ssid%2C%20WiFiConnectionMethod%20connectionMethod%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.WiFi.WiFiAdapter>> FindAllAdaptersAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<WiFiAdapter>> WiFiAdapter.FindAllAdaptersAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CWiFiAdapter%3E%3E%20WiFiAdapter.FindAllAdaptersAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string WiFiAdapter.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WiFiAdapter.GetDeviceSelector%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiAdapter> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiAdapter> WiFiAdapter.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiAdapter%3E%20WiFiAdapter.FromIdAsync%28string%20deviceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.WiFi.WiFiAccessStatus> RequestAccessAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WiFiAccessStatus> WiFiAdapter.RequestAccessAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CWiFiAccessStatus%3E%20WiFiAdapter.RequestAccessAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.WiFi.WiFiAdapter, object> AvailableNetworksChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFi.WiFiAdapter", "event TypedEventHandler<WiFiAdapter, object> WiFiAdapter.AvailableNetworksChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.WiFi.WiFiAdapter", "event TypedEventHandler<WiFiAdapter, object> WiFiAdapter.AvailableNetworksChanged");
			}
		}
#endif
	}
}
