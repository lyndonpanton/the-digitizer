using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment4
{
    /// <summary>
    /// Converts words to digits
    /// </summary>
    public class Digitizer
    {
        #region Fields

        // declare your Dictionary field and create the Dictionary object for it here
        Dictionary<string, int> digitizedNumbers = new Dictionary<string, int>();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Digitizer()
        {
            // populate your dictionary field here
            digitizedNumbers.Add("zero", 0);
            digitizedNumbers.Add("one", 1);
            digitizedNumbers.Add("two", 2);
            digitizedNumbers.Add("three", 3);
            digitizedNumbers.Add("four", 4);
            digitizedNumbers.Add("five", 5);
            digitizedNumbers.Add("six", 6);
            digitizedNumbers.Add("seven", 7);
            digitizedNumbers.Add("eight", 8);
            digitizedNumbers.Add("nine", 9);

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Converts the given word to the corresponding digit.
        /// If the word isn't a valid digit name, returns -1
        /// </summary>
        /// <param name="word">word to convert</param>
        /// <returns>corresponding digit or -1</returns>
        public int ConvertWordToDigit(string word)
        {
            word = word.ToLower();

            if (digitizedNumbers.ContainsKey(word))
            {
                return digitizedNumbers[word];
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
