#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AggregateContactManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.Contact>> FindRawContactsAsync( global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<Contact>> AggregateContactManager.FindRawContactsAsync(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CContact%3E%3E%20AggregateContactManager.FindRawContactsAsync%28Contact%20contact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.Contact> TryLinkContactsAsync( global::Windows.ApplicationModel.Contacts.Contact primaryContact,  global::Windows.ApplicationModel.Contacts.Contact secondaryContact)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Contact> AggregateContactManager.TryLinkContactsAsync(Contact primaryContact, Contact secondaryContact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContact%3E%20AggregateContactManager.TryLinkContactsAsync%28Contact%20primaryContact%2C%20Contact%20secondaryContact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction UnlinkRawContactAsync( global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AggregateContactManager.UnlinkRawContactAsync(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AggregateContactManager.UnlinkRawContactAsync%28Contact%20contact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> TrySetPreferredSourceForPictureAsync( global::Windows.ApplicationModel.Contacts.Contact aggregateContact,  global::Windows.ApplicationModel.Contacts.Contact rawContact)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> AggregateContactManager.TrySetPreferredSourceForPictureAsync(Contact aggregateContact, Contact rawContact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20AggregateContactManager.TrySetPreferredSourceForPictureAsync%28Contact%20aggregateContact%2C%20Contact%20rawContact%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction SetRemoteIdentificationInformationAsync( string contactListId,  string remoteSourceId,  string accountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AggregateContactManager.SetRemoteIdentificationInformationAsync(string contactListId, string remoteSourceId, string accountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AggregateContactManager.SetRemoteIdentificationInformationAsync%28string%20contactListId%2C%20string%20remoteSourceId%2C%20string%20accountId%29");
		}
#endif
	}
}
