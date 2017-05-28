namespace MockingFileSystem
{
	public class MyClass
	{
		private readonly IFileSystem _fileSystem;

		public MyClass(IFileSystem fileSystem)
		{
			_fileSystem = fileSystem;
		}

		public MyClass()
		{
			_fileSystem = new FileSystem();
		}

		public int MyMethod()
		{
			if (_fileSystem.DirectoryExists("c:\\temp"))
			{
				return 3;
			}
			return 5;
		}
	}
}
