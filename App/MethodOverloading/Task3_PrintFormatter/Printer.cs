// Задача: Перегрузка методов — Print
// Реализуйте перегруженные методы Print согласно README. Методы должны возвращать строку.


using System;
using System.Collections.Generic;
using System.Linq;

namespace App.MethodOverloading.Task3_PrintFormatter;

public static class Printer
{
    public static string Print(int value)
    {
        return value.ToString();
    }

    public static string Print(double value, int decimals)
    {
        return value.ToString($"F{decimals}");
    }

    public static string Print(params int[] values)
    {
        return string.Join(", ", values);
    }

    public static string Print<T>(IEnumerable<T> values)
    {
        if (values == null)
            return string.Empty;
        return string.Join(", ", values);
    }
}