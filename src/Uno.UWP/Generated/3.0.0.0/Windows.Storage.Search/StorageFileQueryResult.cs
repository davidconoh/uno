#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StorageFileQueryResult : global::Windows.Storage.Search.IStorageQueryResultBase
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.StorageFolder Folder
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorageFolder StorageFileQueryResult.Folder is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StorageFolder%20StorageFileQueryResult.Folder");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Storage.StorageFile>> GetFilesAsync( uint startIndex,  uint maxNumberOfItems)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StorageFile>> StorageFileQueryResult.GetFilesAsync(uint startIndex, uint maxNumberOfItems) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStorageFile%3E%3E%20StorageFileQueryResult.GetFilesAsync%28uint%20startIndex%2C%20uint%20maxNumberOfItems%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Storage.StorageFile>> GetFilesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StorageFile>> StorageFileQueryResult.GetFilesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStorageFile%3E%3E%20StorageFileQueryResult.GetFilesAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<uint> GetItemCountAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<uint> StorageFileQueryResult.GetItemCountAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cuint%3E%20StorageFileQueryResult.GetItemCountAsync%28%29");
		}
#endif
		// Forced skipping of method Windows.Storage.Search.StorageFileQueryResult.Folder.get
		// Forced skipping of method Windows.Storage.Search.StorageFileQueryResult.ContentsChanged.add
		// Forced skipping of method Windows.Storage.Search.StorageFileQueryResult.ContentsChanged.remove
		// Forced skipping of method Windows.Storage.Search.StorageFileQueryResult.OptionsChanged.add
		// Forced skipping of method Windows.Storage.Search.StorageFileQueryResult.OptionsChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<uint> FindStartIndexAsync( object value)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<uint> StorageFileQueryResult.FindStartIndexAsync(object value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cuint%3E%20StorageFileQueryResult.FindStartIndexAsync%28object%20value%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Search.QueryOptions GetCurrentQueryOptions()
		{
			throw new global::System.NotImplementedException("The member QueryOptions StorageFileQueryResult.GetCurrentQueryOptions() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=QueryOptions%20StorageFileQueryResult.GetCurrentQueryOptions%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void ApplyNewQueryOptions( global::Windows.Storage.Search.QueryOptions newQueryOptions)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFileQueryResult", "void StorageFileQueryResult.ApplyNewQueryOptions(QueryOptions newQueryOptions)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IReadOnlyList<global::Windows.Data.Text.TextSegment>> GetMatchingPropertiesWithRanges( global::Windows.Storage.StorageFile file)
		{
			throw new global::System.NotImplementedException("The member IDictionary<string, IReadOnlyList<TextSegment>> StorageFileQueryResult.GetMatchingPropertiesWithRanges(StorageFile file) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IDictionary%3Cstring%2C%20IReadOnlyList%3CTextSegment%3E%3E%20StorageFileQueryResult.GetMatchingPropertiesWithRanges%28StorageFile%20file%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Storage.Search.IStorageQueryResultBase, object> ContentsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFileQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFileQueryResult.ContentsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFileQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFileQueryResult.ContentsChanged");
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
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFileQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFileQueryResult.OptionsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Storage.Search.StorageFileQueryResult", "event TypedEventHandler<IStorageQueryResultBase, object> StorageFileQueryResult.OptionsChanged");
			}
		}
#endif
		// Processing: Windows.Storage.Search.IStorageQueryResultBase
	}
}
