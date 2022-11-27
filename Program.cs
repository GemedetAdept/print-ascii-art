// Print list of options from text files in directory
// Change color of printed text

string workingDirectory = Directory.GetCurrentDirectory();
string asciiFolder = workingDirectory + "\\asciiArtFiles";

DirectoryInfo asciiFolderInfo = new DirectoryInfo(asciiFolder);

FileInfo[] asciiFiles = asciiFolderInfo.GetFiles();

for (int i = 0; i < asciiFiles.Length; i++) {

	Console.WriteLine($"[{i}] {asciiFiles[i].Name}");
}