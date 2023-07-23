#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HolographicFrameScanoutMonitor : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.Graphics.Holographic.HolographicFrameScanoutReport> ReadReports()
		{
			throw new global::System.NotImplementedException("The member IList<HolographicFrameScanoutReport> HolographicFrameScanoutMonitor.ReadReports() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CHolographicFrameScanoutReport%3E%20HolographicFrameScanoutMonitor.ReadReports%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Holographic.HolographicFrameScanoutMonitor", "void HolographicFrameScanoutMonitor.Dispose()");
		}
#endif
		// Processing: System.IDisposable
	}
}
