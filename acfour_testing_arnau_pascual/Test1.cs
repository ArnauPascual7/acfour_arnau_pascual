namespace acfour_testing_arnau_pascual
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestOrderNumbers()
        {
            // Arrange
            int[] arr = new int[] { 1005, 0, 43, 89, 245, 1, 99, 7, 999, 576, 2 , 1006 };
            int[] expArr = new int[] { 1006, 1005, 999, 576, 245, 99, 89, 43, 7, 2, 1, 0 };

            // Act
            acfour_arnau_pascual.Program.OrderNumbers(arr);

            // Assert
            CollectionAssert.AreEqual(expArr, arr);
        }
    }
}
