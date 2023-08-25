// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var file1 = "Go do that thing that you do so well";
var file2 = "I play football well";

var f = file1 + " " + file2;

var found = f.Split(" ");

var words = new Dictionary<string, int>();

foreach (var word in found) { 
    if(words.ContainsKey(word)) 
    { 
        words[word]++;
    }
    else {
        words.Add(word, 1);
    }
}    

foreach(var word in words) {
    Console.WriteLine(word.Key  + " " + word.Value);
}

Console.ReadLine();
