#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class KeyTimeHelper 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.Media.Animation.KeyTime FromTimeSpan( global::System.TimeSpan timeSpan)
		{
			throw new global::System.NotImplementedException("The member KeyTime KeyTimeHelper.FromTimeSpan(TimeSpan timeSpan) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=KeyTime%20KeyTimeHelper.FromTimeSpan%28TimeSpan%20timeSpan%29");
		}
#endif
	}
}
