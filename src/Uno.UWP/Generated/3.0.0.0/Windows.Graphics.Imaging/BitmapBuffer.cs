#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class BitmapBuffer : global::Windows.Foundation.IMemoryBuffer,global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int GetPlaneCount()
		{
			throw new global::System.NotImplementedException("The member int BitmapBuffer.GetPlaneCount() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20BitmapBuffer.GetPlaneCount%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Graphics.Imaging.BitmapPlaneDescription GetPlaneDescription( int index)
		{
			throw new global::System.NotImplementedException("The member BitmapPlaneDescription BitmapBuffer.GetPlaneDescription(int index) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=BitmapPlaneDescription%20BitmapBuffer.GetPlaneDescription%28int%20index%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IMemoryBufferReference CreateReference()
		{
			throw new global::System.NotImplementedException("The member IMemoryBufferReference BitmapBuffer.CreateReference() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IMemoryBufferReference%20BitmapBuffer.CreateReference%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.BitmapBuffer", "void BitmapBuffer.Dispose()");
		}
#endif
		// Processing: Windows.Foundation.IMemoryBuffer
		// Processing: System.IDisposable
	}
}
