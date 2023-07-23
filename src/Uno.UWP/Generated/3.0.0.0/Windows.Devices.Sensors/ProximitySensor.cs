#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class ProximitySensor 
	{
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ProximitySensor.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ProximitySensor.DeviceId");
			}
		}
#endif
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint? MaxDistanceInMillimeters
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? ProximitySensor.MaxDistanceInMillimeters is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%3F%20ProximitySensor.MaxDistanceInMillimeters");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint? MinDistanceInMillimeters
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? ProximitySensor.MinDistanceInMillimeters is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%3F%20ProximitySensor.MinDistanceInMillimeters");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensor.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensor.MaxDistanceInMillimeters.get
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensor.MinDistanceInMillimeters.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Sensors.ProximitySensorReading GetCurrentReading()
		{
			throw new global::System.NotImplementedException("The member ProximitySensorReading ProximitySensor.GetCurrentReading() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ProximitySensorReading%20ProximitySensor.GetCurrentReading%28%29");
		}
#endif
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensor.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.ProximitySensor.ReadingChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Sensors.ProximitySensorDisplayOnOffController CreateDisplayOnOffController()
		{
			throw new global::System.NotImplementedException("The member ProximitySensorDisplayOnOffController ProximitySensor.CreateDisplayOnOffController() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ProximitySensorDisplayOnOffController%20ProximitySensor.CreateDisplayOnOffController%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Sensors.ProximitySensorReading> GetReadingsFromTriggerDetails( global::Windows.Devices.Sensors.SensorDataThresholdTriggerDetails triggerDetails)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ProximitySensorReading> ProximitySensor.GetReadingsFromTriggerDetails(SensorDataThresholdTriggerDetails triggerDetails) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CProximitySensorReading%3E%20ProximitySensor.GetReadingsFromTriggerDetails%28SensorDataThresholdTriggerDetails%20triggerDetails%29");
		}
#endif
		// Skipping already declared method Windows.Devices.Sensors.ProximitySensor.GetDeviceSelector()
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.ProximitySensor FromId( string sensorId)
		{
			throw new global::System.NotImplementedException("The member ProximitySensor ProximitySensor.FromId(string sensorId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ProximitySensor%20ProximitySensor.FromId%28string%20sensorId%29");
		}
#endif
#if false || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.ProximitySensor, global::Windows.Devices.Sensors.ProximitySensorReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.ProximitySensor", "event TypedEventHandler<ProximitySensor, ProximitySensorReadingChangedEventArgs> ProximitySensor.ReadingChanged");
			}
			[global::Uno.NotImplemented("__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.ProximitySensor", "event TypedEventHandler<ProximitySensor, ProximitySensorReadingChangedEventArgs> ProximitySensor.ReadingChanged");
			}
		}
#endif
	}
}
