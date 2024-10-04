// See https://aka.ms/new-console-template for more information

// Create a function that takes a string, replace each letter with its appropriate position in the alphabet. "a" is 1, "b" is 2, "c" is 3, etc.
// Examples
// UnoAcbIndex("Wow, does that work?")
// ➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"
// UnoAcbIndex("The river stole the gods.")
// ➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"
// UnoAcbIndex("We have a lot of rain in June.")
// ➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"
// Notes
// • If any character in the string isn't a letter, ignore it.


string returnNumbers(string data){
    List<string> result = new List<string>();
    var newData = new Dictionary<char, int>();
    for (char c = 'a'; c <= 'z'; c++){
        newData[c] = c - 'a' + 1;
    }

    Char[] chars = data.ToLower().ToCharArray();

    foreach(char c in chars){
        if (newData.ContainsKey(c)){
            result.Add(newData[c].ToString());
        }
    }

    return string.Join(" ", result);
}

Console.WriteLine(returnNumbers("We have a lot of rain in June."));
