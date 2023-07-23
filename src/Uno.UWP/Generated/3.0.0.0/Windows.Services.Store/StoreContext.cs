#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class StoreContext 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User StoreContext.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20StoreContext.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool CanSilentlyDownloadStorePackageUpdates
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StoreContext.CanSilentlyDownloadStorePackageUpdates is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20StoreContext.CanSilentlyDownloadStorePackageUpdates");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreContext.User.get
		// Forced skipping of method Windows.Services.Store.StoreContext.OfflineLicensesChanged.add
		// Forced skipping of method Windows.Services.Store.StoreContext.OfflineLicensesChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> GetCustomerPurchaseIdAsync( string serviceTicket,  string publisherUserId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> StoreContext.GetCustomerPurchaseIdAsync(string serviceTicket, string publisherUserId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20StoreContext.GetCustomerPurchaseIdAsync%28string%20serviceTicket%2C%20string%20publisherUserId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> GetCustomerCollectionsIdAsync( string serviceTicket,  string publisherUserId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> StoreContext.GetCustomerCollectionsIdAsync(string serviceTicket, string publisherUserId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20StoreContext.GetCustomerCollectionsIdAsync%28string%20serviceTicket%2C%20string%20publisherUserId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreAppLicense> GetAppLicenseAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreAppLicense> StoreContext.GetAppLicenseAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreAppLicense%3E%20StoreContext.GetAppLicenseAsync%28%29");
		}
#endif
#if false || false || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductResult> GetStoreProductForCurrentAppAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductResult> StoreContext.GetStoreProductForCurrentAppAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductResult%3E%20StoreContext.GetStoreProductForCurrentAppAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductQueryResult> GetStoreProductsAsync( global::System.Collections.Generic.IEnumerable<string> productKinds,  global::System.Collections.Generic.IEnumerable<string> storeIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductQueryResult> StoreContext.GetStoreProductsAsync(IEnumerable<string> productKinds, IEnumerable<string> storeIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductQueryResult%3E%20StoreContext.GetStoreProductsAsync%28IEnumerable%3Cstring%3E%20productKinds%2C%20IEnumerable%3Cstring%3E%20storeIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductQueryResult> GetAssociatedStoreProductsAsync( global::System.Collections.Generic.IEnumerable<string> productKinds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductQueryResult> StoreContext.GetAssociatedStoreProductsAsync(IEnumerable<string> productKinds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductQueryResult%3E%20StoreContext.GetAssociatedStoreProductsAsync%28IEnumerable%3Cstring%3E%20productKinds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductPagedQueryResult> GetAssociatedStoreProductsWithPagingAsync( global::System.Collections.Generic.IEnumerable<string> productKinds,  uint maxItemsToRetrievePerPage)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductPagedQueryResult> StoreContext.GetAssociatedStoreProductsWithPagingAsync(IEnumerable<string> productKinds, uint maxItemsToRetrievePerPage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductPagedQueryResult%3E%20StoreContext.GetAssociatedStoreProductsWithPagingAsync%28IEnumerable%3Cstring%3E%20productKinds%2C%20uint%20maxItemsToRetrievePerPage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductQueryResult> GetUserCollectionAsync( global::System.Collections.Generic.IEnumerable<string> productKinds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductQueryResult> StoreContext.GetUserCollectionAsync(IEnumerable<string> productKinds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductQueryResult%3E%20StoreContext.GetUserCollectionAsync%28IEnumerable%3Cstring%3E%20productKinds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductPagedQueryResult> GetUserCollectionWithPagingAsync( global::System.Collections.Generic.IEnumerable<string> productKinds,  uint maxItemsToRetrievePerPage)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductPagedQueryResult> StoreContext.GetUserCollectionWithPagingAsync(IEnumerable<string> productKinds, uint maxItemsToRetrievePerPage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductPagedQueryResult%3E%20StoreContext.GetUserCollectionWithPagingAsync%28IEnumerable%3Cstring%3E%20productKinds%2C%20uint%20maxItemsToRetrievePerPage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreConsumableResult> ReportConsumableFulfillmentAsync( string productStoreId,  uint quantity,  global::System.Guid trackingId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreConsumableResult> StoreContext.ReportConsumableFulfillmentAsync(string productStoreId, uint quantity, Guid trackingId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreConsumableResult%3E%20StoreContext.ReportConsumableFulfillmentAsync%28string%20productStoreId%2C%20uint%20quantity%2C%20Guid%20trackingId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreConsumableResult> GetConsumableBalanceRemainingAsync( string productStoreId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreConsumableResult> StoreContext.GetConsumableBalanceRemainingAsync(string productStoreId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreConsumableResult%3E%20StoreContext.GetConsumableBalanceRemainingAsync%28string%20productStoreId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreAcquireLicenseResult> AcquireStoreLicenseForOptionalPackageAsync( global::Windows.ApplicationModel.Package optionalPackage)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreAcquireLicenseResult> StoreContext.AcquireStoreLicenseForOptionalPackageAsync(Package optionalPackage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreAcquireLicenseResult%3E%20StoreContext.AcquireStoreLicenseForOptionalPackageAsync%28Package%20optionalPackage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StorePurchaseResult> RequestPurchaseAsync( string storeId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorePurchaseResult> StoreContext.RequestPurchaseAsync(string storeId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStorePurchaseResult%3E%20StoreContext.RequestPurchaseAsync%28string%20storeId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StorePurchaseResult> RequestPurchaseAsync( string storeId,  global::Windows.Services.Store.StorePurchaseProperties storePurchaseProperties)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StorePurchaseResult> StoreContext.RequestPurchaseAsync(string storeId, StorePurchaseProperties storePurchaseProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStorePurchaseResult%3E%20StoreContext.RequestPurchaseAsync%28string%20storeId%2C%20StorePurchaseProperties%20storePurchaseProperties%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Services.Store.StorePackageUpdate>> GetAppAndOptionalStorePackageUpdatesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StorePackageUpdate>> StoreContext.GetAppAndOptionalStorePackageUpdatesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStorePackageUpdate%3E%3E%20StoreContext.GetAppAndOptionalStorePackageUpdatesAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadStorePackageUpdatesAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Store.StorePackageUpdate> storePackageUpdates)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.RequestDownloadStorePackageUpdatesAsync(IEnumerable<StorePackageUpdate> storePackageUpdates) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.RequestDownloadStorePackageUpdatesAsync%28IEnumerable%3CStorePackageUpdate%3E%20storePackageUpdates%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadAndInstallStorePackageUpdatesAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Store.StorePackageUpdate> storePackageUpdates)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.RequestDownloadAndInstallStorePackageUpdatesAsync(IEnumerable<StorePackageUpdate> storePackageUpdates) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.RequestDownloadAndInstallStorePackageUpdatesAsync%28IEnumerable%3CStorePackageUpdate%3E%20storePackageUpdates%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadAndInstallStorePackagesAsync( global::System.Collections.Generic.IEnumerable<string> storeIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.RequestDownloadAndInstallStorePackagesAsync(IEnumerable<string> storeIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.RequestDownloadAndInstallStorePackagesAsync%28IEnumerable%3Cstring%3E%20storeIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductResult> FindStoreProductForPackageAsync( global::System.Collections.Generic.IEnumerable<string> productKinds,  global::Windows.ApplicationModel.Package package)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductResult> StoreContext.FindStoreProductForPackageAsync(IEnumerable<string> productKinds, Package package) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductResult%3E%20StoreContext.FindStoreProductForPackageAsync%28IEnumerable%3Cstring%3E%20productKinds%2C%20Package%20package%29");
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreContext.CanSilentlyDownloadStorePackageUpdates.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> TrySilentDownloadStorePackageUpdatesAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Store.StorePackageUpdate> storePackageUpdates)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.TrySilentDownloadStorePackageUpdatesAsync(IEnumerable<StorePackageUpdate> storePackageUpdates) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.TrySilentDownloadStorePackageUpdatesAsync%28IEnumerable%3CStorePackageUpdate%3E%20storePackageUpdates%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> TrySilentDownloadAndInstallStorePackageUpdatesAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Store.StorePackageUpdate> storePackageUpdates)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.TrySilentDownloadAndInstallStorePackageUpdatesAsync(IEnumerable<StorePackageUpdate> storePackageUpdates) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.TrySilentDownloadAndInstallStorePackageUpdatesAsync%28IEnumerable%3CStorePackageUpdate%3E%20storePackageUpdates%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreCanAcquireLicenseResult> CanAcquireStoreLicenseForOptionalPackageAsync( global::Windows.ApplicationModel.Package optionalPackage)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreCanAcquireLicenseResult> StoreContext.CanAcquireStoreLicenseForOptionalPackageAsync(Package optionalPackage) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreCanAcquireLicenseResult%3E%20StoreContext.CanAcquireStoreLicenseForOptionalPackageAsync%28Package%20optionalPackage%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreCanAcquireLicenseResult> CanAcquireStoreLicenseAsync( string productStoreId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreCanAcquireLicenseResult> StoreContext.CanAcquireStoreLicenseAsync(string productStoreId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreCanAcquireLicenseResult%3E%20StoreContext.CanAcquireStoreLicenseAsync%28string%20productStoreId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreProductQueryResult> GetStoreProductsAsync( global::System.Collections.Generic.IEnumerable<string> productKinds,  global::System.Collections.Generic.IEnumerable<string> storeIds,  global::Windows.Services.Store.StoreProductOptions storeProductOptions)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreProductQueryResult> StoreContext.GetStoreProductsAsync(IEnumerable<string> productKinds, IEnumerable<string> storeIds, StoreProductOptions storeProductOptions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreProductQueryResult%3E%20StoreContext.GetStoreProductsAsync%28IEnumerable%3Cstring%3E%20productKinds%2C%20IEnumerable%3Cstring%3E%20storeIds%2C%20StoreProductOptions%20storeProductOptions%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Services.Store.StoreQueueItem>> GetAssociatedStoreQueueItemsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StoreQueueItem>> StoreContext.GetAssociatedStoreQueueItemsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStoreQueueItem%3E%3E%20StoreContext.GetAssociatedStoreQueueItemsAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Services.Store.StoreQueueItem>> GetStoreQueueItemsAsync( global::System.Collections.Generic.IEnumerable<string> storeIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StoreQueueItem>> StoreContext.GetStoreQueueItemsAsync(IEnumerable<string> storeIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStoreQueueItem%3E%3E%20StoreContext.GetStoreQueueItemsAsync%28IEnumerable%3Cstring%3E%20storeIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> RequestDownloadAndInstallStorePackagesAsync( global::System.Collections.Generic.IEnumerable<string> storeIds,  global::Windows.Services.Store.StorePackageInstallOptions storePackageInstallOptions)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.RequestDownloadAndInstallStorePackagesAsync(IEnumerable<string> storeIds, StorePackageInstallOptions storePackageInstallOptions) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.RequestDownloadAndInstallStorePackagesAsync%28IEnumerable%3Cstring%3E%20storeIds%2C%20StorePackageInstallOptions%20storePackageInstallOptions%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperationWithProgress<global::Windows.Services.Store.StorePackageUpdateResult, global::Windows.Services.Store.StorePackageUpdateStatus> DownloadAndInstallStorePackagesAsync( global::System.Collections.Generic.IEnumerable<string> storeIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus> StoreContext.DownloadAndInstallStorePackagesAsync(IEnumerable<string> storeIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperationWithProgress%3CStorePackageUpdateResult%2C%20StorePackageUpdateStatus%3E%20StoreContext.DownloadAndInstallStorePackagesAsync%28IEnumerable%3Cstring%3E%20storeIds%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreUninstallStorePackageResult> RequestUninstallStorePackageAsync( global::Windows.ApplicationModel.Package package)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.RequestUninstallStorePackageAsync(Package package) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreUninstallStorePackageResult%3E%20StoreContext.RequestUninstallStorePackageAsync%28Package%20package%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreUninstallStorePackageResult> RequestUninstallStorePackageByStoreIdAsync( string storeId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.RequestUninstallStorePackageByStoreIdAsync(string storeId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreUninstallStorePackageResult%3E%20StoreContext.RequestUninstallStorePackageByStoreIdAsync%28string%20storeId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreUninstallStorePackageResult> UninstallStorePackageAsync( global::Windows.ApplicationModel.Package package)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.UninstallStorePackageAsync(Package package) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreUninstallStorePackageResult%3E%20StoreContext.UninstallStorePackageAsync%28Package%20package%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreUninstallStorePackageResult> UninstallStorePackageByStoreIdAsync( string storeId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.UninstallStorePackageByStoreIdAsync(string storeId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreUninstallStorePackageResult%3E%20StoreContext.UninstallStorePackageByStoreIdAsync%28string%20storeId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Services.Store.StoreRateAndReviewResult> RequestRateAndReviewAppAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StoreRateAndReviewResult> StoreContext.RequestRateAndReviewAppAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CStoreRateAndReviewResult%3E%20StoreContext.RequestRateAndReviewAppAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Services.Store.StoreQueueItem>> SetInstallOrderForAssociatedStoreQueueItemsAsync( global::System.Collections.Generic.IEnumerable<global::Windows.Services.Store.StoreQueueItem> items)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<StoreQueueItem>> StoreContext.SetInstallOrderForAssociatedStoreQueueItemsAsync(IEnumerable<StoreQueueItem> items) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CStoreQueueItem%3E%3E%20StoreContext.SetInstallOrderForAssociatedStoreQueueItemsAsync%28IEnumerable%3CStoreQueueItem%3E%20items%29");
		}
#endif
		// Skipping already declared method Windows.Services.Store.StoreContext.GetDefault()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Services.Store.StoreContext GetForUser( global::Windows.System.User user)
		{
			throw new global::System.NotImplementedException("The member StoreContext StoreContext.GetForUser(User user) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreContext%20StoreContext.GetForUser%28User%20user%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Services.Store.StoreContext, object> OfflineLicensesChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StoreContext", "event TypedEventHandler<StoreContext, object> StoreContext.OfflineLicensesChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StoreContext", "event TypedEventHandler<StoreContext, object> StoreContext.OfflineLicensesChanged");
			}
		}
#endif
	}
}
