#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ActivitySensorReading 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Sensors.ActivityType Activity
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivityType ActivitySensorReading.Activity is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivityType%20ActivitySensorReading.Activity");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Sensors.ActivitySensorReadingConfidence Confidence
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivitySensorReadingConfidence ActivitySensorReading.Confidence is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivitySensorReadingConfidence%20ActivitySensorReading.Confidence");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.DateTimeOffset Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset ActivitySensorReading.Timestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20ActivitySensorReading.Timestamp");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensorReading.Timestamp.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensorReading.Activity.get
		// Forced skipping of method Windows.Devices.Sensors.ActivitySensorReading.Confidence.get
	}
}
