using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingFileSystem;
using Moq;

namespace MockingFileSystemTests
{
	[TestClass]
	public class TestMyClass
	{
		[TestMethod]
		public void test_temp_directory_exists()
		{
			var mockFileSystem = new Mock<IFileSystem>();
			mockFileSystem.Setup(x => x.DirectoryExists("c:\\temp")).Returns(true);

			var myObject = new MyClass(mockFileSystem.Object);
			Assert.AreEqual(3, myObject.MyMethod());
		}

		[TestMethod]
		public void test_temp_directory_missing()
		{
			var mockFileSystem = new Mock<IFileSystem>();
			mockFileSystem.Setup(x => x.DirectoryExists("c:\\temp")).Returns(false);

			var myObject = new MyClass(mockFileSystem.Object);
			Assert.AreEqual(5, myObject.MyMethod());
		}
	}
}
