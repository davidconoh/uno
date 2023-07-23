#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ImageStream : global::Windows.Storage.Streams.IRandomAccessStreamWithContentType,global::Windows.Storage.Streams.IContentTypeProvider,global::Windows.Storage.Streams.IRandomAccessStream,global::Windows.Storage.Streams.IOutputStream,global::System.IDisposable,global::Windows.Storage.Streams.IInputStream
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ContentType
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ImageStream.ContentType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ImageStream.ContentType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ulong Size
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong ImageStream.Size is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20ImageStream.Size");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.ImageStream", "ulong ImageStream.Size");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool CanRead
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ImageStream.CanRead is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ImageStream.CanRead");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool CanWrite
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ImageStream.CanWrite is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ImageStream.CanWrite");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ulong Position
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong ImageStream.Position is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20ImageStream.Position");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Imaging.ImageStream.Size.get
		// Forced skipping of method Windows.Graphics.Imaging.ImageStream.Size.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IInputStream GetInputStreamAt( ulong position)
		{
			throw new global::System.NotImplementedException("The member IInputStream ImageStream.GetInputStreamAt(ulong position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IInputStream%20ImageStream.GetInputStreamAt%28ulong%20position%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IOutputStream GetOutputStreamAt( ulong position)
		{
			throw new global::System.NotImplementedException("The member IOutputStream ImageStream.GetOutputStreamAt(ulong position) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IOutputStream%20ImageStream.GetOutputStreamAt%28ulong%20position%29");
		}
#endif
		// Forced skipping of method Windows.Graphics.Imaging.ImageStream.Position.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Seek( ulong position)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.ImageStream", "void ImageStream.Seek(ulong position)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IRandomAccessStream CloneStream()
		{
			throw new global::System.NotImplementedException("The member IRandomAccessStream ImageStream.CloneStream() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IRandomAccessStream%20ImageStream.CloneStream%28%29");
		}
#endif
		// Forced skipping of method Windows.Graphics.Imaging.ImageStream.CanRead.get
		// Forced skipping of method Windows.Graphics.Imaging.ImageStream.CanWrite.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Graphics.Imaging.ImageStream", "void ImageStream.Dispose()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Storage.Streams.IBuffer, uint> ReadAsync( global::Windows.Storage.Streams.IBuffer buffer,  uint count,  global::Windows.Storage.Streams.InputStreamOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<IBuffer, uint> ImageStream.ReadAsync(IBuffer buffer, uint count, InputStreamOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CIBuffer%2C%20uint%3E%20ImageStream.ReadAsync%28IBuffer%20buffer%2C%20uint%20count%2C%20InputStreamOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<uint, uint> WriteAsync( global::Windows.Storage.Streams.IBuffer buffer)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<uint, uint> ImageStream.WriteAsync(IBuffer buffer) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3Cuint%2C%20uint%3E%20ImageStream.WriteAsync%28IBuffer%20buffer%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> FlushAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ImageStream.FlushAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20ImageStream.FlushAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Graphics.Imaging.ImageStream.ContentType.get
		// Processing: Windows.Storage.Streams.IRandomAccessStreamWithContentType
		// Processing: Windows.Storage.Streams.IRandomAccessStream
		// Processing: System.IDisposable
		// Processing: Windows.Storage.Streams.IInputStream
		// Processing: Windows.Storage.Streams.IOutputStream
		// Processing: Windows.Storage.Streams.IContentTypeProvider
	}
}
