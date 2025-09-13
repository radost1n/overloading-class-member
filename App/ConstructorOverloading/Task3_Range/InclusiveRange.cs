// Задача: Перегрузка конструкторов — InclusiveRange
// Реализуйте класс InclusiveRange согласно README. Диапазон включительный.

namespace App.ConstructorOverloading.Task3_Range;

public class InclusiveRange
{
    public int Start { get; private set; }
    public int End { get; private set; }

    public InclusiveRange(int start, int end)
    {
        if (start <= end)
        {
            Start = start;
            End = end;
        }
        else
        {
            Start = end;
            End = start;
        }
    }

    public InclusiveRange(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            throw new ArgumentException("Input string cannot be null or empty.");

        string[] parts = s.Split("..");
        if (parts.Length != 2)
            throw new FormatException("Input string must be in the format 'start..end'.");

        if (!int.TryParse(parts[0].Trim(), out int start))
            throw new FormatException("Start value is not a valid integer.");

        if (!int.TryParse(parts[1].Trim(), out int end))
            throw new FormatException("End value is not a valid integer.");

        if (start <= end)
        {
            Start = start;
            End = end;
        }
        else
        {
            Start = end;
            End = start;
        }
    }

    public InclusiveRange(int single)
    {
        Start = single;
        End = single;
    }
}