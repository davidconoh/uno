#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class UsbBulkOutEndpointDescriptor 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public byte EndpointNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbBulkOutEndpointDescriptor.EndpointNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=byte%20UsbBulkOutEndpointDescriptor.EndpointNumber");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint MaxPacketSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UsbBulkOutEndpointDescriptor.MaxPacketSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20UsbBulkOutEndpointDescriptor.MaxPacketSize");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Usb.UsbBulkOutPipe Pipe
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbBulkOutPipe UsbBulkOutEndpointDescriptor.Pipe is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UsbBulkOutPipe%20UsbBulkOutEndpointDescriptor.Pipe");
			}
		}
#endif
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutEndpointDescriptor.MaxPacketSize.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutEndpointDescriptor.EndpointNumber.get
		// Forced skipping of method Windows.Devices.Usb.UsbBulkOutEndpointDescriptor.Pipe.get
	}
}
