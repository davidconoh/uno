#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial interface IStorageFile : global::Windows.Storage.IStorageItem,global::Windows.Storage.Streams.IRandomAccessStreamReference,global::Windows.Storage.Streams.IInputStreamReference
	{
		// Skipping already declared property ContentType
		// Skipping already declared property FileType
		// Forced skipping of method Windows.Storage.IStorageFile.FileType.get
		// Forced skipping of method Windows.Storage.IStorageFile.ContentType.get
		// Skipping already declared method Windows.Storage.IStorageFile.OpenAsync(Windows.Storage.FileAccessMode)
		// Skipping already declared method Windows.Storage.IStorageFile.OpenTransactedWriteAsync()
		// Skipping already declared method Windows.Storage.IStorageFile.CopyAsync(Windows.Storage.IStorageFolder)
		// Skipping already declared method Windows.Storage.IStorageFile.CopyAsync(Windows.Storage.IStorageFolder, string)
		// Skipping already declared method Windows.Storage.IStorageFile.CopyAsync(Windows.Storage.IStorageFolder, string, Windows.Storage.NameCollisionOption)
		// Skipping already declared method Windows.Storage.IStorageFile.CopyAndReplaceAsync(Windows.Storage.IStorageFile)
		// Skipping already declared method Windows.Storage.IStorageFile.MoveAsync(Windows.Storage.IStorageFolder)
		// Skipping already declared method Windows.Storage.IStorageFile.MoveAsync(Windows.Storage.IStorageFolder, string)
		// Skipping already declared method Windows.Storage.IStorageFile.MoveAsync(Windows.Storage.IStorageFolder, string, Windows.Storage.NameCollisionOption)
		// Skipping already declared method Windows.Storage.IStorageFile.MoveAndReplaceAsync(Windows.Storage.IStorageFile)
	}
}
