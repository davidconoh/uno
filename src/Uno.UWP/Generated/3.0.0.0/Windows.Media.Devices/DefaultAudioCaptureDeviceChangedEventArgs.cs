#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class DefaultAudioCaptureDeviceChangedEventArgs : global::Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string DefaultAudioCaptureDeviceChangedEventArgs.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20DefaultAudioCaptureDeviceChangedEventArgs.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Devices.AudioDeviceRole Role
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceRole DefaultAudioCaptureDeviceChangedEventArgs.Role is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioDeviceRole%20DefaultAudioCaptureDeviceChangedEventArgs.Role");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Devices.DefaultAudioCaptureDeviceChangedEventArgs.Id.get
		// Forced skipping of method Windows.Media.Devices.DefaultAudioCaptureDeviceChangedEventArgs.Role.get
		// Processing: Windows.Media.Devices.IDefaultAudioDeviceChangedEventArgs
	}
}
