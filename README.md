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
### The Result

The result of this code snippet should give you the output "HELLO WORLD". 
The program detects spaces in your input and resets the lastChar to avoid misinterpretation

# How To Run
## Prerequisites
- Visual Studio 2019 or later
- .NET Core SDK 3.1 or later (optional if you export the program to .exe)

## Steps to run
### 1. Clone Repo
```bash
git clone https://github.com/GhostDevelopment69/OldPhonePadCodingChallenge.git
cd OldPhonePadCodingChallenge
```
### 2. Open the Solution
- Open 'OldPhonePadCodingChallenge.sln' in Visual Studio

### 3. Build the Solution
- Go to 'Build > Build Solution'

### 4. Run the Project
- Press 'F5' or go to  'Debug > Start Debugging'
- Alternatively, Run without Debugging

## Modifying Input
To test different input strings, modfiy the test cases in the 'Main' method.

```csharp
public static void Main(string[] args)
{
    //Test case 1
    Console.WriteLine("Test case 1 \n");
    string input1 = "4433555 555666096667775553#";
    string output1 = OldPhonePadMethod(input1);
    Console.WriteLine($"Input: {input1} => Output: {output1}\n");

    //Test case 2
    Console.WriteLine("Test case 2 \n");
    string input2 = "4433555 555344488833777 7777#";
    string output2 = OldPhonePadMethod(input2);
    Console.WriteLine($"Input: {input2} => Output: {output2}\n");

    //Test case 3
    Console.WriteLine("Test case 3 \n");
    string input3 = "8 88777444666 * 664#";
    string output3 = OldPhonePadMethod(input3);
    Console.WriteLine($"Input: {input3} => Output: {output3} \n");

    //Test case 4
    Console.WriteLine("Test case 4 \n");
    string input4 = "55544466887777 083322244 084447 7777#";
    string output4 = OldPhonePadMethod(input4);
    Console.WriteLine($"Input: {input4} => Output: {output4} \n");
}
```
