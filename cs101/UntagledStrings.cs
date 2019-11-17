using System;
using System.Collections.Generic;

namespace cs101
{
    public class UntangledStrings
    {
        public static string BlowSmoke()
        {
            return "foo bar";
        }

        /// <summary>
        ///     Tests whether or not the given string consists of unique characters.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         e.g. 'abc' => true
        ///         e.g. 'aba' => false
        ///     </para>
        /// </remarks>
        /// <param name="str">string</param>
        /// <returns>boolean</returns>
        public static bool HasNoRepeatingChars(string str)
        {
            return false;
        }

        /// <summary>
        /// Compress input string
        /// </summary>
        /// <remarks>
        /// <para>If the compressed version would be larger, return the original string.</para>
        /// <para>
        /// e.g. 'aaaaabbbcdd' => 'a5b3c1d2'
        /// e.g. 'abcdefghijk' => 'abcdefghijk'    
        /// </para>
        /// </remarks>
        /// <param name="str">string</param>
        /// <returns>string shorter or equal in length to input string</returns>
        public static string Compress(string str)
        {
            return str;
        }

        /// <summary>
        /// Test whether or not str2 is a rotation of str1.
        /// </summary>
        /// <remarks>
        /// e.g. <c>('abcde', 'cdeab') => true</c>
        /// e.g. <c>('abcde', 'cdeba') => false</c>
        /// </remarks>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>boolean</returns>
        public static bool IsRotation(string str1, string str2)
        {
            return false;
        }

        /// <summary>
        /// Test whether or not the given words are anagrams of each other.
        /// </summary>
        /// <remarks>
        /// e.g. <c>('abba', 'baab', 'abab') => true</c>
        /// e.g. <c>('abba', 'baab', 'abbb') => false</c>
        /// </remarks>
        /// <param name="words">IEnumerable<string></param>
        /// <returns>boolean</returns>
        public static bool IsAnagram(IEnumerable<string> words)
        {
            return false;
        }

        /// <summary>
        /// Parses a seven-segment display as a string of digits
        /// </summary>
        /// <param name="input">multi-line string</param>
        /// <returns>string</returns>
        public static string ParseDisplay(string input)
        {
            return input;
        }

        /// <summary>
        /// Tests if the given string is an anagram of a palindrome.
        /// </summary>
        /// <remarks>
        /// e.g. <c>'tactcoa' => true ('tacocat', 'atcocta'...)</c>
        /// e.g. <c>'aloba' => false</c>
        /// </remarks>
        /// <param name="str">string</param>
        /// <returns>boolean</returns>
        public static bool IsPalindromeAnagram(string str)
        {
            return false;
        }

        /// <summary>
        /// Tests if two given strings differ by one or zero edits (insertion, deletion or replacement).
        /// </summary>
        /// <remarks>
        /// e.g. <c>e.g. ('abcd', 'abd') => true</c>
        /// e.g. <c>e.g. ('abcd', 'abcde') => true</c>
        /// e.g. <c>e.g. ('abcd', 'afcd') => true</c>
        /// e.g. <c>e.g. ('abcd', 'afc') => false</c>
        /// e.g. <c>e.g. ('abcd', 'afc') => false</c>
        /// e.g. <c>e.g. ('abcd', 'abdcef') => false</c>
        /// </remarks>
        /// <param name="word1">string</param>
        /// <param name="word2">string</param>
        /// <returns>boolean</returns>
        public static bool IsOneEditAway(string word1, string word2)
        {
            return false;
        }
    }
}
