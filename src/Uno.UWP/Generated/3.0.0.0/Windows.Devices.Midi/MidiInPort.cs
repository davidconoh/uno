#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Midi
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class MidiInPort : global::System.IDisposable
	{
#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
		public string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MidiInPort.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MidiInPort.DeviceId");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Midi.MidiInPort.MessageReceived.add
		// Forced skipping of method Windows.Devices.Midi.MidiInPort.MessageReceived.remove
		// Forced skipping of method Windows.Devices.Midi.MidiInPort.DeviceId.get
#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
		public void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Midi.MidiInPort", "void MidiInPort.Dispose()");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Midi.MidiInPort> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<MidiInPort> MidiInPort.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CMidiInPort%3E%20MidiInPort.FromIdAsync%28string%20deviceId%29");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string MidiInPort.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20MidiInPort.GetDeviceSelector%28%29");
		}
#endif
#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Midi.MidiInPort, global::Windows.Devices.Midi.MidiMessageReceivedEventArgs> MessageReceived
		{
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Midi.MidiInPort", "event TypedEventHandler<MidiInPort, MidiMessageReceivedEventArgs> MidiInPort.MessageReceived");
			}
			[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Midi.MidiInPort", "event TypedEventHandler<MidiInPort, MidiMessageReceivedEventArgs> MidiInPort.MessageReceived");
			}
		}
#endif
		// Processing: System.IDisposable
	}
}
