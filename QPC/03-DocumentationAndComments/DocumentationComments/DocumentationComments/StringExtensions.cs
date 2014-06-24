namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        /// <summary>
        /// Get the md5Has code of a string
        /// </summary>
        /// <returns>
        /// Returns a new Hexadecimal string
        /// </returns>
        public static string ToMd5Hash(this string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] byteArr = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder byteCollector = new StringBuilder();
            for (int i = 0; i < byteArr.Length; i++)
            {
                byteCollector.Append(byteArr[i].ToString("x2"));
            }

            
            return byteCollector.ToString();
        }
        /// <summary>
        /// Checks if a string is a positive value(ex:true,ok,yes,1,да)
        /// </summary>
        /// <returns>Returns a boolean value whether the input string has positive value</returns>
        public static bool ToBoolean(this string input)
        {
            string[] stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }
        /// <summary>
        /// Converts a string to it's 16-bit signed integer representation
        /// </summary>
        /// <returns>Returns the converted string in short value if conversion is possible, if not returns 0</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }
        /// <summary>
        /// Converts a string to it's 32-bit signed integer representation
        /// </summary>
        /// <returns>Returns the converted string in int value if conversion is possible, if not returns 0</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }
        /// <summary>
        /// Converts a string to it's 64-bit signed integer representation
        /// </summary>
        /// <returns>Returns the converted string in long value if conversion is possible, if not returns 0</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }
        /// <summary>
        /// Converts a DateTime string to it's System.DateTime representation
        /// </summary>
        /// <returns>Returns a new DateTime value if conversion is possible, if it is not returns the base DateTime 01.01.0001 00:00:00</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }
        /// <summary>
        /// Capitalizes the first letter ot a string
        /// </summary>
        /// <returns>Returns a new string with the value of the input but with capitalized first letter if the input is not null or whitespace.
        /// If the input is null or whitespace returns null or whitespace.
        /// </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }
        /// <summary>
        /// Get a string which is between other strings
        /// </summary>
        /// <param name="input">The main string where the string between other two strings is searched</param>
        /// <param name="startString">The string which is expected to be on the left of the searched string</param>
        /// <param name="endString">The string which is expected to be on the right of the searched string</param>
        /// <param name="startFrom">The index from which the search in the main string must start</param>
        /// <returns>Returns a new string which is between startString and endString. If the startString or the endString do are not passed
        /// or some of them is null or empty returns an empty string</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }
        /// <summary>
        /// Converts a string in cyrillic letters to it's latin letters representation
        /// </summary>
        /// <param name="input">The string in cyrillic letters</param>
        /// <returns>Returns the same string object with converted letters from cyrillic to latin</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }
        /// <summary>
        /// Converts a string in latin letters to it's cyrillic letters representation
        /// </summary>
        /// <param name="input">The string in cyrillic letters</param>
        /// <returns>Returns the same string object with converted letters from latin to cyrillic</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }
        /// <summary>
        /// Converts a string to a valid username
        /// </summary>
        /// <returns>Returns the passed string with replaced invalid symbols for a username</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }
        /// <summary>
        /// Converts a string to a valid username in latin letters
        /// </summary>
        /// <returns>Returns the passed string with replaced cyrillic letters to latin letters</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }
        /// <summary>
        /// Gets the first defined character sequence
        /// </summary>
        /// <returns>Returns the first defined sequence of characters in a string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }
        /// <summary>
        /// Gets the file extension of a file
        /// </summary>
        /// <param name="fileName">String representing the file name</param>
        /// <returns>Returns the file extension of a file. If a null or empty string is passed returns an empty string</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }
        /// <summary>
        /// Gets the content type of a file extension
        /// </summary>
        /// <param name="fileExtension">The string representation of the file extension</param>
        /// <returns>Returns the content type of a file extension. 
        /// If the file extension is not found returns a file extension with value:"application/octet-stream"
        /// </returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }
        /// <summary>
        /// Get's the decimal representation of the characters of a string from the ASCII table
        /// </summary>
        /// <returns>Returns a new byte array with the ASCII table values of each character of a string</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
