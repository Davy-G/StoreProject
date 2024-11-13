﻿namespace Domain.Common;

public static class StringExt
{
    public static int GetLength(this string str)
    {
        return str.Length;
    }

    public static string ToSnakeCaseRename(this string str)
    {
        var newStr = str[0].ToString().ToLower();
        foreach (var c in str.Skip(1))
            if (char.IsUpper(c))
                newStr += $"_{char.ToLower(c)}";
            else
                newStr += c;

        return newStr;
    }
}