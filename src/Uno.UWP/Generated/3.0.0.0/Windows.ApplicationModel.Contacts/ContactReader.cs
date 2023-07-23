#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ContactReader 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactBatch> ReadBatchAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactBatch> ContactReader.ReadBatchAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CContactBatch%3E%20ContactReader.ReadBatchAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactMatchReason> GetMatchingPropertiesWithMatchReason( global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ContactMatchReason> ContactReader.GetMatchingPropertiesWithMatchReason(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CContactMatchReason%3E%20ContactReader.GetMatchingPropertiesWithMatchReason%28Contact%20contact%29");
		}
#endif
	}
}
