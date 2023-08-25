
var file1 = "Go do that thing that you do so well";
var file2 = "I play football well";

var core = new WordCountLib.Core();

core.AddText(file1);
core.AddText(file2);

Console.WriteLine(core.ToString());
Console.ReadLine();
