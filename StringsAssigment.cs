using System.Text.RegularExpressions;

string assignment = "Starlight is the light emitted by stars.[1] It typically refers to visible electromagnetic " +
    "radiation from stars other than the Sun, observable from Earth at night, although a component of starlight is " +
    "observable from Earth during daytime. Sunlight is the term used for the Sun's starlight observed during daytime.[2] " +
    "During nighttime, albedo describes solar reflections from other Solar System objects, including moonlight, planet " +
    "shine, and zodiacal light.[3]";


// 1. Extract the First 15 characters from “observable” (Line 2) and merge with the first 10 characters before “Zodiacal” (Line4) 
string charactersAfterObservable = assignment.Substring(assignment.IndexOf("observable") + 10, 15);
string charactersBeforeZodiacal = assignment.Substring(assignment.IndexOf("zodiacal") - 10, 10);

Console.WriteLine(charactersAfterObservable + charactersBeforeZodiacal);
Console.WriteLine();

// 2. Replace Sun in the text to “Solar Emission” then extract all the replaced indexe
string replaceAssignment = assignment.Replace("Sun", "Solar Emission");
Console.WriteLine(replaceAssignment);

Console.WriteLine("***********************************");
    /* Getting the index*/ 
string keyword = "Solar Emission";
int index = replaceAssignment.IndexOf(keyword);
while(index != -1)
{
    Console.WriteLine("{0} found at index: {1}", keyword, index);
    index = replaceAssignment.IndexOf(keyword, index + 1);
}
Console.WriteLine("***********************************");


// 3. Split the text based on each sentences, then merge the first element with the last element to create a new text
string[] delimiters = { ".", "[", "]", "1", "2", "3" };
string[] strArr = replaceAssignment.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine();
foreach(string str in strArr)
{
    Console.WriteLine("***********************************");
    Console.WriteLine(str);
    Console.WriteLine("***********************************");
}

// 4. Extract all the reference numbers from the text above
char[] assignmentCharArray = assignment.ToCharArray();
List<int> refNumbers = new List<int> { };
for(int i = 0; i < assignmentCharArray.Length; i++)
{
    if (Char.IsDigit(assignmentCharArray[i]))
    {
        refNumbers.Add(assignmentCharArray[i]);
    }
    else
    {
        // Do nothing
    }
}

foreach(int i in refNumbers)
{
    Console.WriteLine(i);   
}

// 5.Create a list of items that holds all the Vowel Characters, Consonant Characters, Numbers and Special Character
string[] vowel = { "a", "e", "i", "o", "u" };
string[] consonant = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
string[] nums = { "1", "2", "3" };
string[] specialChars = { ".", "[", "]", ",", "\'" };


for(int i = 0; i < assignmentCharArray.Length; i++)
{
    for(int j = 0; j < vowel.Length; j++)
    {

    }
}
