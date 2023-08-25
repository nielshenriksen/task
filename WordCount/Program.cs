
if (args.Length == 0) {
    Console.WriteLine("There are missing file(s) with words");
}

var core = new WordCountLib.Core();

// run through all files
foreach(var arg in args) {

    if(!File.Exists(arg)) {
        Console.WriteLine($"Missing file: {arg}");
        break;
    }

    var file = File.ReadAllText(arg);
    core.AddText(file);
}

Console.WriteLine(core.ToString());
Console.ReadLine();
