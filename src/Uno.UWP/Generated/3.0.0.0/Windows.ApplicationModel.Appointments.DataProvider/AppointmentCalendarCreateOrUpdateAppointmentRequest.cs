#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AppointmentCalendarCreateOrUpdateAppointmentRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Appointments.Appointment Appointment
		{
			get
			{
				throw new global::System.NotImplementedException("The member Appointment AppointmentCalendarCreateOrUpdateAppointmentRequest.Appointment is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Appointment%20AppointmentCalendarCreateOrUpdateAppointmentRequest.Appointment");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string AppointmentCalendarLocalId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AppointmentCalendarCreateOrUpdateAppointmentRequest.AppointmentCalendarLocalId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AppointmentCalendarCreateOrUpdateAppointmentRequest.AppointmentCalendarLocalId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<string> ChangedProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> AppointmentCalendarCreateOrUpdateAppointmentRequest.ChangedProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cstring%3E%20AppointmentCalendarCreateOrUpdateAppointmentRequest.ChangedProperties");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool NotifyInvitees
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppointmentCalendarCreateOrUpdateAppointmentRequest.NotifyInvitees is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20AppointmentCalendarCreateOrUpdateAppointmentRequest.NotifyInvitees");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequest.AppointmentCalendarLocalId.get
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequest.Appointment.get
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequest.NotifyInvitees.get
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequest.ChangedProperties.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ReportCompletedAsync( global::Windows.ApplicationModel.Appointments.Appointment createdOrUpdatedAppointment)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentCalendarCreateOrUpdateAppointmentRequest.ReportCompletedAsync(Appointment createdOrUpdatedAppointment) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AppointmentCalendarCreateOrUpdateAppointmentRequest.ReportCompletedAsync%28Appointment%20createdOrUpdatedAppointment%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AppointmentCalendarCreateOrUpdateAppointmentRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AppointmentCalendarCreateOrUpdateAppointmentRequest.ReportFailedAsync%28%29");
		}
#endif
	}
}
