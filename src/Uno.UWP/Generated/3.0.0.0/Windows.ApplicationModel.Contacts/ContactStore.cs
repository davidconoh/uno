#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ContactStore 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.AggregateContactManager AggregateContactManager
		{
			get
			{
				throw new global::System.NotImplementedException("The member AggregateContactManager ContactStore.AggregateContactManager is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AggregateContactManager%20ContactStore.AggregateContactManager");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactChangeTracker ChangeTracker
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactChangeTracker ContactStore.ChangeTracker is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactChangeTracker%20ContactStore.ChangeTracker");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.Contact>> FindContactsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<Contact>> ContactStore.FindContactsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CContact%3E%3E%20ContactStore.FindContactsAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.Contact>> FindContactsAsync( string searchText)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<Contact>> ContactStore.FindContactsAsync(string searchText) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CContact%3E%3E%20ContactStore.FindContactsAsync%28string%20searchText%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.Contact> GetContactAsync( string contactId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Contact> ContactStore.GetContactAsync(string contactId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContact%3E%20ContactStore.GetContactAsync%28string%20contactId%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactStore.ChangeTracker.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactStore.ContactChanged.add
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactStore.ContactChanged.remove
		// Forced skipping of method Windows.ApplicationModel.Contacts.ContactStore.AggregateContactManager.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactList>> FindContactListsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactList>> ContactStore.FindContactListsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CContactList%3E%3E%20ContactStore.FindContactListsAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactList> GetContactListAsync( string contactListId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactList> ContactStore.GetContactListAsync(string contactListId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactList%3E%20ContactStore.GetContactListAsync%28string%20contactListId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactList> CreateContactListAsync( string displayName)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactList> ContactStore.CreateContactListAsync(string displayName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactList%3E%20ContactStore.CreateContactListAsync%28string%20displayName%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.Contact> GetMeContactAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Contact> ContactStore.GetMeContactAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContact%3E%20ContactStore.GetMeContactAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactReader GetContactReader()
		{
			throw new global::System.NotImplementedException("The member ContactReader ContactStore.GetContactReader() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactReader%20ContactStore.GetContactReader%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactReader GetContactReader( global::Windows.ApplicationModel.Contacts.ContactQueryOptions options)
		{
			throw new global::System.NotImplementedException("The member ContactReader ContactStore.GetContactReader(ContactQueryOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactReader%20ContactStore.GetContactReader%28ContactQueryOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactList> CreateContactListAsync( string displayName,  string userDataAccountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactList> ContactStore.CreateContactListAsync(string displayName, string userDataAccountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactList%3E%20ContactStore.CreateContactListAsync%28string%20displayName%2C%20string%20userDataAccountId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactChangeTracker GetChangeTracker( string identity)
		{
			throw new global::System.NotImplementedException("The member ContactChangeTracker ContactStore.GetChangeTracker(string identity) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactChangeTracker%20ContactStore.GetChangeTracker%28string%20identity%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Contacts.ContactStore, global::Windows.ApplicationModel.Contacts.ContactChangedEventArgs> ContactChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactStore", "event TypedEventHandler<ContactStore, ContactChangedEventArgs> ContactStore.ContactChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Contacts.ContactStore", "event TypedEventHandler<ContactStore, ContactChangedEventArgs> ContactStore.ContactChanged");
			}
		}
#endif
	}
}
