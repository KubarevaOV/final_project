
string [] wordsArray = new string[]{"Lada", "Kia", "Ford", "Yo", "Zaz", "Ferrari"};
List<string> resultArray = new List<string>();

for (int counter = 0; counter < wordsArray.Length; counter++) {
    if (wordsArray[counter].Length <= 3) {
        resultArray.Add(wordsArray[counter]);
    }
}

String[] str = resultArray.ToArray();

for (int i = 0; i < str.Length; i++) {
    Console.Write("{0} ", str[i]);
}
Console.WriteLine();