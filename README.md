# Prescript Generator

A small C# console application that generates randomized "Prescript" instructions. Each run creates a short, surreal, often absurd directive based on a large pool of phrases, locations, relationships, activities, and timing patterns.

## What it does

The project builds a random text generator that combines:

- time references such as "Tomorrow" or "Within 3 days"
- locations like districts, rooftops, alleys, and homes
- relationships such as neighbors, friends, rivals, and family members
- surreal activities and consequences
- optional postscript modifiers and extra requirements

The result is a Prescript that reads like a strange, ominous task or challenge.

## Project structure

- `Program.cs` - entry point; runs the generator in a loop until the user exits
- `Prescripts.cs` - core random text generation logic and phrase libraries
- `Prescript generator.csproj` - C# project definition
- `Prescripts.txt` - generated sample presets / output draft data

## How to run

1. Open the solution in Visual Studio or build with `dotnet`.
2. Run the project.
3. The app repeatedly generates a new Prescript and waits for a key press before creating another one.

Example:

```csharp
string output = Prescripts.newPrescriptText();
Console.WriteLine(output);
```

## Notes

This project is a lightweight generator rather than a traditional application with persistent storage or a web UI. It is designed to produce varied text output from a predefined library of words and templates, making it useful for procedural writing, creative prompts, or simulated in-world task generation.

## License

This project does not currently include a license file. If you plan to reuse or distribute it, check the repository for any licensing information or add one before publishing.
