using System;


namespace R5T.B0004
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class UsingNamespaceDirectiveBlockLabel : IUsingNamespaceDirectiveBlockLabel
    {
        #region Static
        
        public static UsingNamespaceDirectiveBlockLabel Instance { get; } = new();

        #endregion
    }
}