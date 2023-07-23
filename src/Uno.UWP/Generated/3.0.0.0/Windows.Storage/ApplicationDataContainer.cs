#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class ApplicationDataContainer : global::System.IDisposable
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.Storage.ApplicationDataContainer> Containers
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, ApplicationDataContainer> ApplicationDataContainer.Containers is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20ApplicationDataContainer%3E%20ApplicationDataContainer.Containers");
			}
		}
#endif
		// Skipping already declared property Locality
		// Skipping already declared property Name
		// Skipping already declared property Values
		// Forced skipping of method Windows.Storage.ApplicationDataContainer.Name.get
		// Forced skipping of method Windows.Storage.ApplicationDataContainer.Locality.get
		// Forced skipping of method Windows.Storage.ApplicationDataContainer.Values.get
		// Forced skipping of method Windows.Storage.ApplicationDataContainer.Containers.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.ApplicationDataContainer CreateContainer( string name,  global::Windows.Storage.ApplicationDataCreateDisposition disposition)
		{
			throw new global::System.NotImplementedException("The member ApplicationDataContainer ApplicationDataContainer.CreateContainer(string name, ApplicationDataCreateDisposition disposition) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationDataContainer%20ApplicationDataContainer.CreateContainer%28string%20name%2C%20ApplicationDataCreateDisposition%20disposition%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void DeleteContainer( string name)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationDataContainer", "void ApplicationDataContainer.DeleteContainer(string name)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationDataContainer", "void ApplicationDataContainer.Dispose()");
		}
#endif
		// Processing: System.IDisposable
	}
}
