#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Devices
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SceneModeControl 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Devices.CaptureSceneMode> SupportedModes
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<CaptureSceneMode> SceneModeControl.SupportedModes is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CCaptureSceneMode%3E%20SceneModeControl.SupportedModes");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Devices.CaptureSceneMode Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member CaptureSceneMode SceneModeControl.Value is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CaptureSceneMode%20SceneModeControl.Value");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Devices.SceneModeControl.SupportedModes.get
		// Forced skipping of method Windows.Media.Devices.SceneModeControl.Value.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetValueAsync( global::Windows.Media.Devices.CaptureSceneMode sceneMode)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction SceneModeControl.SetValueAsync(CaptureSceneMode sceneMode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20SceneModeControl.SetValueAsync%28CaptureSceneMode%20sceneMode%29");
		}
#endif
	}
}
