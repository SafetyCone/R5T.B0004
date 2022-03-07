using System;


namespace R5T.B0004
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class UsingDirectiveBlockSortOrder : IUsingDirectiveBlockSortOrder
    {
        #region Static
        
        public static UsingDirectiveBlockSortOrder Instance { get; } = new();

        #endregion
    }
}