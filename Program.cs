static string SpinWord(string sentence)
{
    string[] wordArray = sentence.Split(' ');

    for (int i = 0; i < wordArray.Length; i++)
    {
        if (wordArray[i].Length > 4)
        {
            char[] arr = wordArray[i].ToCharArray();
            Array.Reverse(arr);
            string word = new string(arr);
            wordArray[i] = word;
        }
    }
    return String.Join(" ", wordArray);
}