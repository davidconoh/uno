#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member AppointmentCalendarCreateOrUpdateAppointmentRequest AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AppointmentCalendarCreateOrUpdateAppointmentRequest%20AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs.Request");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs.Request.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs.GetDeferral%28%29");
		}
#endif
	}
}
