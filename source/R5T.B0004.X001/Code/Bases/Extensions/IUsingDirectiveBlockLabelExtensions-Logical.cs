using System;

using R5T.B0004;
using R5T.B0004.X001;


namespace System
{
    public static partial class IUsingDirectiveBlockLabelExtensions
    {
        public static string Default(this IUsingDirectiveBlockLabel _)
        {
            return UsingDirectiveBlockLabels.Default;
        }

        public static string First(this IUsingDirectiveBlockLabel _)
        {
            return UsingDirectiveBlockLabels.First;
        }

        public static string Last(this IUsingDirectiveBlockLabel _)
        {
            return UsingDirectiveBlockLabels.Last;
        }

        public static string LocalNamespace(this IUsingDirectiveBlockLabel _)
        {
            return UsingDirectiveBlockLabels.LocalNamespace;
        }

        public static string Special(this IUsingDirectiveBlockLabel _)
        {
            return UsingDirectiveBlockLabels.Special;
        }
    }
}