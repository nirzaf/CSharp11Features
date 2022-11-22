// See https://aka.ms/new-console-template for more information

using CSharp11Features;

using static System.Console;

WriteLine("Testing new C# 11 Features...!");

/*
StringLiterals stringLiterals = new();
WriteLine(stringLiterals.EscapeStringOld());
WriteLine(stringLiterals.EscapeStringNew());

WriteLine("Json As Text Old ");
WriteLine(stringLiterals.JsonAsTextOld());
WriteLine("Json As Text New ");
WriteLine(stringLiterals.JsonAsTextNew());

WriteLine("Json As Text with string interpolation new");
WriteLine(stringLiterals.JsonWithStringInterpolationNew());
*/

var input = ReadLine();

var key = "QWWQWQWASASA";

var encrypted = Encryption.Encrypt(input, key);

WriteLine($"Encrypted: {encrypted}");

var decrypted = Encryption.Decrypt(encrypted, key);

WriteLine($"Decrypted: {decrypted}");

ReadLine();

// int number = int.Parse(input);
//
// WriteLine(number.IsComposite().ToString());




ListPatterns listPatterns = new();
listPatterns.IntPattern();

