using lab8.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class MatrixTransformation
    {
        private List<List<string>> _matrix;
        //public char? LetterFilter { get; set; }
        //public char? DigitFilter { get; set; }
        //public bool StartsWithLetter { get; set; }
        //public bool StartsWithDigit { get; set; }
        //public bool StartsWithLetterOrDigit { get; set; }
        //public bool NoFilter { get; set; }
        //public bool ToUpper { get; set; }
        //public bool ToLower { get; set; }

        public MatrixTransformation(List<List<string>> matrix)
        {
            _matrix = matrix;
        }

        public List<FilterResult> ApplyFilters(FilterSettings settings)
        {
            var results = new List<FilterResult>();

            for (int row = 0; row < _matrix.Count; row++)
            {
                var currentRow = _matrix[row];
                if (currentRow.Count == 0 || string.IsNullOrEmpty(currentRow[0])) continue;

                char firstChar = currentRow[0][0];
                if (!ShouldProcessRow(firstChar, settings)) continue;

                string transformedRow = TransformFirstLetterInFirstWord(string.Join(" ", currentRow), settings);

                string[] transformedElements = transformedRow.Split(' ');

                for (int col = 0; col < currentRow.Count; col++)
                {
                    //string original = _matrix[row, col];
                    //string transformed;

                    results.Add(new FilterResult
                    {
                        Row = row + 1,
                        Column = col + 1,
                        OriginalValue = currentRow[col],
                        TransformedValue = col < transformedElements.Length
                            ? transformedElements[col]
                            : string.Empty
                    });
                }
            }

            return results;
        }

        private bool ShouldProcessRow(char firstChar, FilterSettings settings)
        {
            if (settings.NoFilter)
                return true;

            if (settings.StartsWithLetter && char.IsLetter(firstChar))
                return firstChar == settings.LetterFilter;

            if (settings.StartsWithDigit && char.IsDigit(firstChar))
                return firstChar == settings.DigitFilter;

            if (settings.StartsWithLetterOrDigit)
            {
                return (char.IsLetter(firstChar) && firstChar == settings.LetterFilter) ||
                       (char.IsDigit(firstChar) && firstChar == settings.DigitFilter);
            }

            return false;
        }

        private string TransformFirstLetterInFirstWord(string currentRow, FilterSettings settings)
        {
            if (settings.NoTransformation) return currentRow;

            string[] words = currentRow.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0) return currentRow;

            foreach (var word in words)
            {
                // Ищем первую букву в слове
                int firstLetterIndex = -1;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        firstLetterIndex = i;
                        break;
                    }
                }

                if (firstLetterIndex != -1)
                {
                    char[] wordChars = word.ToCharArray();
                    wordChars[firstLetterIndex] = settings.ToUpper
                        ? char.ToUpper(wordChars[firstLetterIndex])
                        : char.ToLower(wordChars[firstLetterIndex]);

                    words[Array.IndexOf(words, word)] = new string(wordChars);
                    break;
                }
            }

            return string.Join(" ", words);
        }

        //private bool CheckFilter(char firstChar)
        //{
        //    if (NoFilter) return true;

        //    if (StartsWithLetter)
        //        return char.ToUpper(firstChar) == char.ToUpper(LetterFilter.Value);

        //    if (StartsWithDigit)
        //        return char.IsDigit(firstChar) && firstChar == DigitFilter.Value;

        //    if (StartsWithLetterOrDigit)
        //        return (char.ToUpper(firstChar) == char.ToUpper(LetterFilter.Value)) ||
        //               (char.IsDigit(firstChar) && firstChar == DigitFilter.Value);

        //    return false;
        //}

        //private string ApplyTransformation(string value)
        //{
        //    if (string.IsNullOrEmpty(value) || (!ToUpper && !ToLower))
        //        return value;

        //    string[] words = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //    if (words.Length == 0) return value;

        //    char firstChar = words[0][0];
        //    if (ToUpper)
        //        words[0] = char.ToUpper(firstChar) + words[0].Substring(1);
        //    else if (ToLower)
        //        words[0] = char.ToLower(firstChar) + words[0].Substring(1);

        //    return string.Join(" ", words);
        //}
    }

    public class FilterResult
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string OriginalValue { get; set; }
        public string TransformedValue { get; set; }
    }

    public class FilterSettings
    {
        public bool NoFilter { get; set; }
        public bool StartsWithLetter { get; set; }
        public bool StartsWithDigit { get; set; }
        public bool StartsWithLetterOrDigit { get; set; }
        public bool ToUpper { get; set; }
        public bool ToLower { get; set; }
        public bool NoTransformation => !ToUpper && !ToLower;
        public char? LetterFilter { get; set; }
        public char? DigitFilter { get; set; }
    }
}
