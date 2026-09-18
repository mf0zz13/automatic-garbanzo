# MSSA C# Assignments

> **Status:** Early-learning archive from Microsoft Software and Systems Academy coursework. This is a collection of independent exercises rather than one application, and it is not maintained as a polished portfolio project.

The repository records C# practice across user interfaces, input handling, collections, data structures, algorithms, serialization, and LINQ. Most projects target .NET 8; some use Windows Forms or reference `System.Windows.Forms` and therefore target `net8.0-windows`.

## Exercise index

| Area | Contents |
| --- | --- |
| [Week 4](Assignments/Week_4/) | Windows Forms account-creation and login prototype with an in-memory teacher-account dictionary |
| [Week 5](Assignments/Week_5/) | Small console projects covering input validation, exceptions, strings, arrays, duplicate checks, and coding exercises |
| [Week 6](Assignments/Week_6/) | Menu-driven practice with a custom linked list and stack, a queue, array transformations, matrices, and dictionary challenges |
| [Week 7](Assignments/Week_7/) | Selection and Shell sorting, string interleaving, vowel reversal, anagram checking, a binary search tree, and a parking-space exercise |
| [Week 10](Assignments/Week_10/) | Binary/XML/JSON serialization practice, LINQ filtering, and two algorithm challenges |
| [Week 11](Assignments/Week_11/) | Array-ordering and character-frequency challenge attempts |

Nested READMEs preserve several original prompts and pseudocode notes. Each `.csproj` is intended to be opened or run independently; there is no repository-level solution that combines every week.

## Running an individual project

Install the .NET 8 SDK and use the project path for the exercise you want to inspect. For example, on Windows:

```powershell
dotnet run --project "Assignments/Week_7/Week_7.csproj"
```

Some exercises require Windows, and the Week 10 serialization project contains machine-specific file paths. That project is not portable without source changes. The repository also has no consolidated automated test suite, so the presence of an exercise does not establish current correctness for every input.

## Context

These files show progression through training assignments and retain the structure, prompts, and rough edges of the original work. They are best used as a learning-history reference. Course prompts and scaffolding may be present alongside the authored solutions.
