using System;


namespace R5T.B0004
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class UsingDirectiveBlockLabel : IUsingDirectiveBlockLabel
    {
        #region Static
        
        public static UsingDirectiveBlockLabel Instance { get; } = new();

        #endregion
    }
}