using System;
using Xunit;

namespace SuperBowlNamer.Tests
{
    /* Numbers to test conversion
     * 1    I
     * 5	V
     * 9	IX
     * 12	XII
     * 16	XVI
     * 29	XXIX
     * 44	XLIV
     * 45	XLV
     * 68	LXVIII
     * 83	LXXXIII
     * 97	XCVII
     * 99	XCIX
     * 500	D
     * 501	DI
     * 649	DCXLIX
     * 798	DCCXCVIII
     * 891	DCCCXCI
     * 1000	M
     * 1004	MIV
     * 1006	MVI
     * 1023	MXXIII
     * 2014	MMXIV
     * 3999	MMMCMXCIX
     */

    public class Convert_User_Number_Input_to_Roman
    {
        [Fact]
        public void Convert_User_Input_1_to_Roman_I()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "1";
            var expectedOutput = "I";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);

        }

        [Fact]
        public void Convert_User_Input_5_to_Roman_V()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "5";
            var expectedOutput = "V";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
            
        }

        [Fact]
        public void Convert_User_Input_9_to_Roman_IX()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "9";
            var expectedOutput = "IX";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_12_to_Roman_XII()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "12";
            var expectedOutput = "XII";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_16_to_Roman_XVI()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "16";
            var expectedOutput = "XVI";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }
    }
}
