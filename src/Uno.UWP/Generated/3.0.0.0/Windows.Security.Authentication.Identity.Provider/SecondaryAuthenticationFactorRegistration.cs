#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Identity.Provider
{
	// This type is deprecated. Consider not implementing it.
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SecondaryAuthenticationFactorRegistration 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction FinishRegisteringDeviceAsync( global::Windows.Storage.Streams.IBuffer deviceConfigurationData)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SecondaryAuthenticationFactorRegistration.FinishRegisteringDeviceAsync(IBuffer deviceConfigurationData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SecondaryAuthenticationFactorRegistration.FinishRegisteringDeviceAsync%28IBuffer%20deviceConfigurationData%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction AbortRegisteringDeviceAsync( string errorLogMessage)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SecondaryAuthenticationFactorRegistration.AbortRegisteringDeviceAsync(string errorLogMessage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SecondaryAuthenticationFactorRegistration.AbortRegisteringDeviceAsync%28string%20errorLogMessage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync( string deviceId,  string deviceInstancePath,  global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync(string deviceId, string deviceInstancePath, SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CSecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus%3E%20SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync%28string%20deviceId%2C%20string%20deviceInstancePath%2C%20SecondaryAuthenticationFactorDevicePresenceMonitoringMode%20monitoringMode%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> RegisterDevicePresenceMonitoringAsync( string deviceId,  string deviceInstancePath,  global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode,  string deviceFriendlyName,  string deviceModelNumber,  global::Windows.Storage.Streams.IBuffer deviceConfigurationData)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync(string deviceId, string deviceInstancePath, SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode, string deviceFriendlyName, string deviceModelNumber, IBuffer deviceConfigurationData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CSecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus%3E%20SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync%28string%20deviceId%2C%20string%20deviceInstancePath%2C%20SecondaryAuthenticationFactorDevicePresenceMonitoringMode%20monitoringMode%2C%20string%20deviceFriendlyName%2C%20string%20deviceModelNumber%2C%20IBuffer%20deviceConfigurationData%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction UnregisterDevicePresenceMonitoringAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SecondaryAuthenticationFactorRegistration.UnregisterDevicePresenceMonitoringAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SecondaryAuthenticationFactorRegistration.UnregisterDevicePresenceMonitoringAsync%28string%20deviceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsDevicePresenceMonitoringSupported()
		{
			throw new global::System.NotImplementedException("The member bool SecondaryAuthenticationFactorRegistration.IsDevicePresenceMonitoringSupported() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20SecondaryAuthenticationFactorRegistration.IsDevicePresenceMonitoringSupported%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationResult> RequestStartRegisteringDeviceAsync( string deviceId,  global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities capabilities,  string deviceFriendlyName,  string deviceModelNumber,  global::Windows.Storage.Streams.IBuffer deviceKey,  global::Windows.Storage.Streams.IBuffer mutualAuthenticationKey)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<SecondaryAuthenticationFactorRegistrationResult> SecondaryAuthenticationFactorRegistration.RequestStartRegisteringDeviceAsync(string deviceId, SecondaryAuthenticationFactorDeviceCapabilities capabilities, string deviceFriendlyName, string deviceModelNumber, IBuffer deviceKey, IBuffer mutualAuthenticationKey) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CSecondaryAuthenticationFactorRegistrationResult%3E%20SecondaryAuthenticationFactorRegistration.RequestStartRegisteringDeviceAsync%28string%20deviceId%2C%20SecondaryAuthenticationFactorDeviceCapabilities%20capabilities%2C%20string%20deviceFriendlyName%2C%20string%20deviceModelNumber%2C%20IBuffer%20deviceKey%2C%20IBuffer%20mutualAuthenticationKey%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo>> FindAllRegisteredDeviceInfoAsync( global::Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceFindScope queryType)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<SecondaryAuthenticationFactorInfo>> SecondaryAuthenticationFactorRegistration.FindAllRegisteredDeviceInfoAsync(SecondaryAuthenticationFactorDeviceFindScope queryType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CSecondaryAuthenticationFactorInfo%3E%3E%20SecondaryAuthenticationFactorRegistration.FindAllRegisteredDeviceInfoAsync%28SecondaryAuthenticationFactorDeviceFindScope%20queryType%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction UnregisterDeviceAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SecondaryAuthenticationFactorRegistration.UnregisterDeviceAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SecondaryAuthenticationFactorRegistration.UnregisterDeviceAsync%28string%20deviceId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction UpdateDeviceConfigurationDataAsync( string deviceId,  global::Windows.Storage.Streams.IBuffer deviceConfigurationData)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SecondaryAuthenticationFactorRegistration.UpdateDeviceConfigurationDataAsync(string deviceId, IBuffer deviceConfigurationData) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SecondaryAuthenticationFactorRegistration.UpdateDeviceConfigurationDataAsync%28string%20deviceId%2C%20IBuffer%20deviceConfigurationData%29");
		}
#endif
	}
}
