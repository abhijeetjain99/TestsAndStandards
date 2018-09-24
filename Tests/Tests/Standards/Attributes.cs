namespace Tests.Standards
{
    using System;

    /// <summary>
    /// [Flags] attribute allows to use HasFlas method on enum 
    /// which behind the scene operate like a Bitwise AND (both true then true)
    /// Example- 
    ///         10110
    ///         01101 &
    ///        -------
    ///         00100
    /// </summary>
    [Flags]
    public enum Attributes : long
    {
        /// <summary>
        /// Represents Bitwise 1 = 0001 shifted 0 times.
        /// </summary>
        Setting1 = 1L << 0,

        /// <summary>
        /// Represents Bitwise 1 = 0010 shifted 1 times.
        /// </summary>
        Setting2 = 1L << 1,

        /// <summary>
        /// Represents Bitwise 1 = 0100 shifted 2 times.
        /// </summary>
        Setting3 = 1L << 2,

        /// <summary>
        /// Represents Bitwise 1 = 1000 shifted 3 times.
        /// </summary>
        Setting4 = 1L << 3
    }
}
