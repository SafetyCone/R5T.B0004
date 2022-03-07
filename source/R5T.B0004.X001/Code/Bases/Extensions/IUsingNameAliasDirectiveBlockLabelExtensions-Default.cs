using System;

using R5T.B0004;
using R5T.B0004.X001;


namespace System
{
    public static partial class IUsingNameAliasDirectiveBlockLabelExtensions
    {
        public static string Classes(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Classes;
        }

        public static string Default(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Default;
        }

        public static string Interfaces(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Interfaces;
        }
    }
}
