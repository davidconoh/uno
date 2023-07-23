#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
#if false || false || IS_UNIT_TESTS || false || false || false || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS")]
#endif
	public partial class ApplicationData : global::System.IDisposable
	{
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.StorageFolder LocalFolder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder ApplicationData.LocalFolder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20ApplicationData.LocalFolder");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.ApplicationDataContainer LocalSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationDataContainer ApplicationData.LocalSettings is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationDataContainer%20ApplicationData.LocalSettings");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.StorageFolder RoamingFolder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder ApplicationData.RoamingFolder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20ApplicationData.RoamingFolder");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.ApplicationDataContainer RoamingSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationDataContainer ApplicationData.RoamingSettings is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationDataContainer%20ApplicationData.RoamingSettings");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public ulong RoamingStorageQuota
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong ApplicationData.RoamingStorageQuota is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ulong%20ApplicationData.RoamingStorageQuota");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.StorageFolder TemporaryFolder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder ApplicationData.TemporaryFolder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20ApplicationData.TemporaryFolder");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public uint Version
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint ApplicationData.Version is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20ApplicationData.Version");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.StorageFolder LocalCacheFolder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder ApplicationData.LocalCacheFolder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20ApplicationData.LocalCacheFolder");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.StorageFolder SharedLocalFolder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder ApplicationData.SharedLocalFolder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20ApplicationData.SharedLocalFolder");
			}
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public static global::Windows.Storage.ApplicationData Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationData ApplicationData.Current is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationData%20ApplicationData.Current");
			}
		}
#endif
		// Forced skipping of method Windows.Storage.ApplicationData.Version.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetVersionAsync( uint desiredVersion,  global::Windows.Storage.ApplicationDataSetVersionHandler handler)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationData.SetVersionAsync(uint desiredVersion, ApplicationDataSetVersionHandler handler) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ApplicationData.SetVersionAsync%28uint%20desiredVersion%2C%20ApplicationDataSetVersionHandler%20handler%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ClearAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationData.ClearAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ApplicationData.ClearAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ClearAsync( global::Windows.Storage.ApplicationDataLocality locality)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationData.ClearAsync(ApplicationDataLocality locality) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ApplicationData.ClearAsync%28ApplicationDataLocality%20locality%29");
		}
#endif
		// Forced skipping of method Windows.Storage.ApplicationData.LocalSettings.get
		// Forced skipping of method Windows.Storage.ApplicationData.RoamingSettings.get
		// Forced skipping of method Windows.Storage.ApplicationData.LocalFolder.get
		// Forced skipping of method Windows.Storage.ApplicationData.RoamingFolder.get
		// Forced skipping of method Windows.Storage.ApplicationData.TemporaryFolder.get
		// Forced skipping of method Windows.Storage.ApplicationData.DataChanged.add
		// Forced skipping of method Windows.Storage.ApplicationData.DataChanged.remove
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public void SignalDataChanged()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationData", "void ApplicationData.SignalDataChanged()");
		}
#endif
		// Forced skipping of method Windows.Storage.ApplicationData.RoamingStorageQuota.get
		// Forced skipping of method Windows.Storage.ApplicationData.LocalCacheFolder.get
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Storage.StorageFolder GetPublisherCacheFolder( string folderName)
		{
			throw new global::System.NotImplementedException("The member StorageFolder ApplicationData.GetPublisherCacheFolder(string folderName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20ApplicationData.GetPublisherCacheFolder%28string%20folderName%29");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public global::Windows.Foundation.IAsyncAction ClearPublisherCacheFolderAsync( string folderName)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationData.ClearPublisherCacheFolderAsync(string folderName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20ApplicationData.ClearPublisherCacheFolderAsync%28string%20folderName%29");
		}
#endif
		// Forced skipping of method Windows.Storage.ApplicationData.SharedLocalFolder.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationData", "void ApplicationData.Dispose()");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Storage.ApplicationData> GetForUserAsync( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ApplicationData> ApplicationData.GetForUserAsync(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CApplicationData%3E%20ApplicationData.GetForUserAsync%28User%20user%29");
		}
#endif
		// Forced skipping of method Windows.Storage.ApplicationData.Current.get
#if false || false || IS_UNIT_TESTS || false || false || false || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Storage.ApplicationData, object> DataChanged
		{
			[global::Uno.NotImplemented("IS_UNIT_TESTS")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationData", "event TypedEventHandler<ApplicationData, object> ApplicationData.DataChanged");
			}
			[global::Uno.NotImplemented("IS_UNIT_TESTS")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.ApplicationData", "event TypedEventHandler<ApplicationData, object> ApplicationData.DataChanged");
			}
		}
#endif
		// Processing: System.IDisposable
	}
}
