#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments
{
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
#endif
	public partial class AppointmentStore 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Appointments.AppointmentStoreChangeTracker ChangeTracker
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppointmentStoreChangeTracker AppointmentStore.ChangeTracker is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppointmentStoreChangeTracker%20AppointmentStore.ChangeTracker");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.AppointmentStore.ChangeTracker.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.AppointmentCalendar> CreateAppointmentCalendarAsync( string name)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppointmentCalendar> AppointmentStore.CreateAppointmentCalendarAsync(string name) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointmentCalendar%3E%20AppointmentStore.CreateAppointmentCalendarAsync%28string%20name%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.AppointmentCalendar> GetAppointmentCalendarAsync( string calendarId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppointmentCalendar> AppointmentStore.GetAppointmentCalendarAsync(string calendarId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointmentCalendar%3E%20AppointmentStore.GetAppointmentCalendarAsync%28string%20calendarId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.Appointment> GetAppointmentAsync( string localId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Appointment> AppointmentStore.GetAppointmentAsync(string localId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointment%3E%20AppointmentStore.GetAppointmentAsync%28string%20localId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.Appointment> GetAppointmentInstanceAsync( string localId,  global::System.DateTimeOffset instanceStartTime)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Appointment> AppointmentStore.GetAppointmentInstanceAsync(string localId, DateTimeOffset instanceStartTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointment%3E%20AppointmentStore.GetAppointmentInstanceAsync%28string%20localId%2C%20DateTimeOffset%20instanceStartTime%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Appointments.AppointmentCalendar>> FindAppointmentCalendarsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<AppointmentCalendar>> AppointmentStore.FindAppointmentCalendarsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CAppointmentCalendar%3E%3E%20AppointmentStore.FindAppointmentCalendarsAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Appointments.AppointmentCalendar>> FindAppointmentCalendarsAsync( global::Windows.ApplicationModel.Appointments.FindAppointmentCalendarsOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<AppointmentCalendar>> AppointmentStore.FindAppointmentCalendarsAsync(FindAppointmentCalendarsOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CAppointmentCalendar%3E%3E%20AppointmentStore.FindAppointmentCalendarsAsync%28FindAppointmentCalendarsOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Appointments.Appointment>> FindAppointmentsAsync( global::System.DateTimeOffset rangeStart,  global::System.TimeSpan rangeLength)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<Appointment>> AppointmentStore.FindAppointmentsAsync(DateTimeOffset rangeStart, TimeSpan rangeLength) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CAppointment%3E%3E%20AppointmentStore.FindAppointmentsAsync%28DateTimeOffset%20rangeStart%2C%20TimeSpan%20rangeLength%29");
		}
#endif
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Appointments.Appointment>> FindAppointmentsAsync( global::System.DateTimeOffset rangeStart,  global::System.TimeSpan rangeLength,  global::Windows.ApplicationModel.Appointments.FindAppointmentsOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<Appointment>> AppointmentStore.FindAppointmentsAsync(DateTimeOffset rangeStart, TimeSpan rangeLength, FindAppointmentsOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CAppointment%3E%3E%20AppointmentStore.FindAppointmentsAsync%28DateTimeOffset%20rangeStart%2C%20TimeSpan%20rangeLength%2C%20FindAppointmentsOptions%20options%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.AppointmentConflictResult> FindConflictAsync( global::Windows.ApplicationModel.Appointments.Appointment appointment)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppointmentConflictResult> AppointmentStore.FindConflictAsync(Appointment appointment) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointmentConflictResult%3E%20AppointmentStore.FindConflictAsync%28Appointment%20appointment%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.AppointmentConflictResult> FindConflictAsync( global::Windows.ApplicationModel.Appointments.Appointment appointment,  global::System.DateTimeOffset instanceStartTime)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppointmentConflictResult> AppointmentStore.FindConflictAsync(Appointment appointment, DateTimeOffset instanceStartTime) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointmentConflictResult%3E%20AppointmentStore.FindConflictAsync%28Appointment%20appointment%2C%20DateTimeOffset%20instanceStartTime%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction MoveAppointmentAsync( global::Windows.ApplicationModel.Appointments.Appointment appointment,  global::Windows.ApplicationModel.Appointments.AppointmentCalendar destinationCalendar)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentStore.MoveAppointmentAsync(Appointment appointment, AppointmentCalendar destinationCalendar) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AppointmentStore.MoveAppointmentAsync%28Appointment%20appointment%2C%20AppointmentCalendar%20destinationCalendar%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> ShowAddAppointmentAsync( global::Windows.ApplicationModel.Appointments.Appointment appointment,  global::Windows.Foundation.Rect selection)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> AppointmentStore.ShowAddAppointmentAsync(Appointment appointment, Rect selection) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20AppointmentStore.ShowAddAppointmentAsync%28Appointment%20appointment%2C%20Rect%20selection%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> ShowReplaceAppointmentAsync( string localId,  global::Windows.ApplicationModel.Appointments.Appointment appointment,  global::Windows.Foundation.Rect selection)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> AppointmentStore.ShowReplaceAppointmentAsync(string localId, Appointment appointment, Rect selection) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20AppointmentStore.ShowReplaceAppointmentAsync%28string%20localId%2C%20Appointment%20appointment%2C%20Rect%20selection%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> ShowReplaceAppointmentAsync( string localId,  global::Windows.ApplicationModel.Appointments.Appointment appointment,  global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement,  global::System.DateTimeOffset instanceStartDate)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> AppointmentStore.ShowReplaceAppointmentAsync(string localId, Appointment appointment, Rect selection, Placement preferredPlacement, DateTimeOffset instanceStartDate) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20AppointmentStore.ShowReplaceAppointmentAsync%28string%20localId%2C%20Appointment%20appointment%2C%20Rect%20selection%2C%20Placement%20preferredPlacement%2C%20DateTimeOffset%20instanceStartDate%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> ShowRemoveAppointmentAsync( string localId,  global::Windows.Foundation.Rect selection)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> AppointmentStore.ShowRemoveAppointmentAsync(string localId, Rect selection) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20AppointmentStore.ShowRemoveAppointmentAsync%28string%20localId%2C%20Rect%20selection%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<bool> ShowRemoveAppointmentAsync( string localId,  global::Windows.Foundation.Rect selection,  global::Windows.UI.Popups.Placement preferredPlacement,  global::System.DateTimeOffset instanceStartDate)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> AppointmentStore.ShowRemoveAppointmentAsync(string localId, Rect selection, Placement preferredPlacement, DateTimeOffset instanceStartDate) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cbool%3E%20AppointmentStore.ShowRemoveAppointmentAsync%28string%20localId%2C%20Rect%20selection%2C%20Placement%20preferredPlacement%2C%20DateTimeOffset%20instanceStartDate%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ShowAppointmentDetailsAsync( string localId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentStore.ShowAppointmentDetailsAsync(string localId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AppointmentStore.ShowAppointmentDetailsAsync%28string%20localId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ShowAppointmentDetailsAsync( string localId,  global::System.DateTimeOffset instanceStartDate)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentStore.ShowAppointmentDetailsAsync(string localId, DateTimeOffset instanceStartDate) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AppointmentStore.ShowAppointmentDetailsAsync%28string%20localId%2C%20DateTimeOffset%20instanceStartDate%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<string> ShowEditNewAppointmentAsync( global::Windows.ApplicationModel.Appointments.Appointment appointment)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> AppointmentStore.ShowEditNewAppointmentAsync(Appointment appointment) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3Cstring%3E%20AppointmentStore.ShowEditNewAppointmentAsync%28Appointment%20appointment%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<string>> FindLocalIdsFromRoamingIdAsync( string roamingId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<string>> AppointmentStore.FindLocalIdsFromRoamingIdAsync(string roamingId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3Cstring%3E%3E%20AppointmentStore.FindLocalIdsFromRoamingIdAsync%28string%20roamingId%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.AppointmentStore.StoreChanged.add
		// Forced skipping of method Windows.ApplicationModel.Appointments.AppointmentStore.StoreChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Appointments.AppointmentCalendar> CreateAppointmentCalendarAsync( string name,  string userDataAccountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AppointmentCalendar> AppointmentStore.CreateAppointmentCalendarAsync(string name, string userDataAccountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAppointmentCalendar%3E%20AppointmentStore.CreateAppointmentCalendarAsync%28string%20name%2C%20string%20userDataAccountId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Appointments.AppointmentStoreChangeTracker GetChangeTracker( string identity)
		{
			throw new global::System.NotImplementedException("The member AppointmentStoreChangeTracker AppointmentStore.GetChangeTracker(string identity) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppointmentStoreChangeTracker%20AppointmentStore.GetChangeTracker%28string%20identity%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.ApplicationModel.Appointments.AppointmentStore, global::Windows.ApplicationModel.Appointments.AppointmentStoreChangedEventArgs> StoreChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Appointments.AppointmentStore", "event TypedEventHandler<AppointmentStore, AppointmentStoreChangedEventArgs> AppointmentStore.StoreChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Appointments.AppointmentStore", "event TypedEventHandler<AppointmentStore, AppointmentStoreChangedEventArgs> AppointmentStore.StoreChanged");
			}
		}
#endif
	}
}
