using Xunit;
using OldPhonePadCodingChallenge;

namespace OldPhonePadUnitTests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData("4433555 555666096667775553#", "HELLO WORLD")]
		[InlineData("69997777833777999 044466222", "MYSTERY INC")]
		[InlineData("8 88777444666 * 664#", "TURING")]
		[InlineData("55544466887777 083322244 084447 7777#", "LINUS TECH TIPS")]
		[InlineData("33#", "E")]
		[InlineData("5533 337 0222 25556 02663 02226663 33 0666 66", "KEEP CALM AND CODE ON")]
		public void OldPhonePadMethod_ShouldReturnExpectedOutput(string input, string expected)
		{
			// Act
			var result = OldPhonePad.OldPhonePadMethod(input);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}