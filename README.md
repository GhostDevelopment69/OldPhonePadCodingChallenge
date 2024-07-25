# OldPhonePadCodingChallenge
This project implements a method to simulate typing on an old mobile phone keypad.

## Overview
The 'OldPhonePadMethod' takes a string input and converts it to the corresponding text as typed on a classic phone keypad. This method simulates the behavior of typing messages on old mobile phones, where each number key corresponds to multiple letters.

## Method

### OldPhonePadMethod

The `OldPhonePadMethod` processes a string of key presses and converts it into a readable message according to the following rules:
- Digits from 1 to 9 represent letters on a classic phone keypad.
- `*` acts as a backspace key.
- `0` acts as a space key.
- `#` represents the send key and ends the input.

### Example Usage

```csharp
using System:
public class OldPhonePad
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test case 1 \n");
        string input1 = "4433555 555666096667775553#";
        string output1 = OldPhonePadMethod(input1);
        Console.WriteLine($"Input: {input1} => Output: {output1}\n");
    }
}
```
