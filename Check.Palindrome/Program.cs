// See https://aka.ms/new-console-template for more information

bool palindrome(string data){
    char [] arrayData = data.ToCharArray();
    Array.Reverse(arrayData);
    string revData = new String(arrayData);
    return data == revData;
}

Console.WriteLine(palindrome("radar"));

