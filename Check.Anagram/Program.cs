// See https://aka.ms/new-console-template for more information

bool checkAnagram(string str1, string str2){
    if (str1.Length != str2.Length){
        return false;
    }
    var s1 = str1.ToLower().ToCharArray();
    var s2 = str2.ToLower().ToCharArray();
    Array.Sort(s1);
    Array.Sort(s2);
    str1 = new String(s1);
    str2 = new String(s2);
    return str1 == str2;
}

Console.WriteLine(checkAnagram("listen", "silent"));
Console.WriteLine(checkAnagram("hello", "world"));
