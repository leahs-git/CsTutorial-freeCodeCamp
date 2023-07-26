// line break
Console.WriteLine("Good\nDay");

//keep the quotation marks in the print output
Console.WriteLine("Good\"Day");

//store a string as a variable

string phrase = "-...Good Day" + " -Voi ei";

//find number of characters inside the string. Inculding punctuation and spaces.
Console.WriteLine(phrase.Length); 

//using methods to find out or modify strings

Console.WriteLine(phrase.ToUpper());
Console.WriteLine(phrase.ToLower());

//Looking for contents within the string
Console.WriteLine(phrase.Contains("voi"));

//printout the index of the character in the string
Console.WriteLine(phrase[0]);


