#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HolographicSpaceCameraRemovedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Graphics.Holographic.HolographicCamera Camera
		{
			get
			{
				throw new global::System.NotImplementedException("The member HolographicCamera HolographicSpaceCameraRemovedEventArgs.Camera is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=HolographicCamera%20HolographicSpaceCameraRemovedEventArgs.Camera");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Holographic.HolographicSpaceCameraRemovedEventArgs.Camera.get
	}
}
