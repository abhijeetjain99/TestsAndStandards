namespace Tests.Standards
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for BitwiseArgumentsInMethodTests
    /// </summary>
    [TestClass]
    public class BitwiseArgumentsInMethodTests
    {
        /// <summary>
        /// check the functionality of the Bitwise operator  when Enum is attributed as [Flags].
        /// </summary>
        [TestMethod]
        public void BitwiseArgumentsInMethodTests1()
        {
            Attributes attributeObject = Attributes.Setting1 | Attributes.Setting3;

            attributeObject.HasFlag(Attributes.Setting2).Should().BeFalse("attributeObject do not have flag fot setting2");
            attributeObject.HasFlag(Attributes.Setting1).Should().BeTrue("attributeObject has flag for setting1");
        }
    }
}