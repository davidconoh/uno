#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StorageFolderQueryResult : global::Windows.Storage.Search.IStorageQueryResultBase
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.StorageFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder StorageFolderQueryResult.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20StorageFolderQueryResult.Folder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Storage.StorageFolder>> GetFoldersAsync( uint startIndex,  uint maxNumberOfItems)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StorageFolder>> StorageFolderQueryResult.GetFoldersAsync(uint startIndex, uint maxNumberOfItems) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStorageFolder%3E%3E%20StorageFolderQueryResult.GetFoldersAsync%28uint%20startIndex%2C%20uint%20maxNumberOfItems%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Storage.StorageFolder>> GetFoldersAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StorageFolder>> StorageFolderQueryResult.GetFoldersAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStorageFolder%3E%3E%20StorageFolderQueryResult.GetFoldersAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<uint> GetItemCountAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<uint> StorageFolderQueryResult.GetItemCountAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cuint%3E%20StorageFolderQueryResult.GetItemCountAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Storage.Search.StorageFolderQueryResult.Folder.get
		// Forced skipping of method Windows.Storage.Search.StorageFolderQueryResult.ContentsChanged.add
		// Forced skipping of method Windows.Storage.Search.StorageFolderQueryResult.ContentsChanged.remove
		// Forced skipping of method Windows.Storage.Search.StorageFolderQueryResult.OptionsChanged.add
		// Forced skipping of method Windows.Storage.Search.StorageFolderQueryResult.OptionsChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<uint> FindStartIndexAsync( object value)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<uint> StorageFolderQueryResult.FindStartIndexAsync(object value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cuint%3E%20StorageFolderQueryResult.FindStartIndexAsync%28object%20value%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Search.QueryOptions GetCurrentQueryOptions()
		{
			throw new global::System.NotImplementedException("The member QueryOptions StorageFolderQueryResult.GetCurrentQueryOptions() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=QueryOptions%20StorageFolderQueryResult.GetCurrentQueryOptions%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void ApplyNewQueryOptions( global::Windows.Storage.Search.QueryOptions newQueryOptions)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFolderQueryResult", "void StorageFolderQueryResult.ApplyNewQueryOptions(QueryOptions newQueryOptions)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Storage.Search.IStorageQueryResultBase, object> ContentsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFolderQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFolderQueryResult.ContentsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFolderQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFolderQueryResult.ContentsChanged");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Storage.Search.IStorageQueryResultBase, object> OptionsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFolderQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFolderQueryResult.OptionsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFolderQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFolderQueryResult.OptionsChanged");
			}
		}
#endif
		// Processing: Windows.Storage.Search.IStorageQueryResultBase
	}
}
