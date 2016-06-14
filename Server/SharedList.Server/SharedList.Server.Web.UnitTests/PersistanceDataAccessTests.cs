using SharedList.Server.Web.ApplicationService.Concrete;
using SharedList.Server.Web.Model;

namespace SharedList.Server.Web.UnitTests
{

    using Xunit;
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class PersistanceDataAccessTests
    {

        [Fact]
        public void AddNewItem_NewItem_ItemAdded()
        {
            // Arrange
            var dut = new PersistanceDataAccess();

            // act
            var item = dut.AddNewItem("test text");

            // assert
            Assert.True("test text" == item.Text);
        }
    }
}
