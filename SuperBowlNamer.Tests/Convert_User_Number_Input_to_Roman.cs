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

        [Fact]
        public void Convert_User_Input_29_to_Roman_XXIX()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "29";
            var expectedOutput = "XXIX";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_44_to_Roman_XLIV()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "44";
            var expectedOutput = "XLIV";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_45_to_Roman_XLV()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "45";
            var expectedOutput = "XLV";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_68_to_Roman_LXVIII()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "68";
            var expectedOutput = "LXVIII";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_83_to_Roman_LXXXIII()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "83";
            var expectedOutput = "LXXXIII";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_97_to_Roman_XCVII()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "97";
            var expectedOutput = "XCVII";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_99_to_Roman_XCIX()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "99";
            var expectedOutput = "XCIX";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_500_to_Roman_D()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "500";
            var expectedOutput = "D";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_501_to_Roman_DI()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "501";
            var expectedOutput = "DI";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_649_to_Roman_DCXLIX()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "649";
            var expectedOutput = "DCXLIX";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_798_to_Roman_DCCXCVIII()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "798";
            var expectedOutput = "DCCXCVIII";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_891_to_Roman_DCCCXCI()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "891";
            var expectedOutput = "DCCCXCI";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_1000_to_Roman_M()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "1000";
            var expectedOutput = "M";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

        [Fact]
        public void Convert_User_Input_1004_to_Roman_MIV()
        {
            // Arrange
            var converter = new IntToRomanConverter();
            var input = "1004";
            var expectedOutput = "MIV";
            // Act
            var actualResult = converter.ConvertToRomanNumerals(input);

            // Assert
            Assert.Equal(expectedOutput, actualResult);
        }

    }
}
