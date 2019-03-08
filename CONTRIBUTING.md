<!-- TOC -->

- [**1. Commits Guidelines**](#1-commits-guidelines)
    - [1.1. Commit](#11-commit)
    - [1.2. Commit Message](#12-commit-message)
    - [1.3. Submitting Pull Requests](#13-submitting-pull-requests)
- [**2. XAML Coding Guidelines**](#2-xaml-coding-guidelines)
    - [2.1. Naming](#21-naming)
    - [2.2. Spacing](#22-spacing)
    - [2.3. Code readability](#23-code-readability)
- [**3. UI Guidelines**](#3-ui-guidelines)
    - [3.1. Layout](#31-layout)
    - [3.2. Typography](#32-typography)
    - [3.3. More Guidelines](#33-more-guidelines)
- [**4. C# coding guidelines**](#4-c-coding-guidelines)
    - [4.1. Variables Naming Conventions](#41-variables-naming-conventions)
    - [4.2. Layout Conventions](#42-layout-conventions)
    - [4.3. Commenting Conventions](#43-commenting-conventions)
    - [4.4. Class ordering](#44-class-ordering)
    - [4.5. More Guidelines](#45-more-guidelines)

<!-- /TOC -->

## 1. Commits Guidelines

### 1.1. Commit

- Commits **shouldn't contain multiple unrelated changes**; try and make piecemeal changes if you can, to make it easier to review and merge. In particular, don't commit style/whitespace changes and functionality changes in a single commit.
- Modify **one file** per commit. This will make merging and pulling easier for everyone.
- Make sure that the App still **runs** before making a commit.

### 1.2. Commit Message

- Separate subject from body with a **blank line**.
- **Do not** end the subject line with a **period**.
- **Capitalize** the subject line and each paragraph.
- Use the **imperative mood** in the subject line.
- Wrap lines of the body at **72 characters**.
- **Asterisks** are used for the bullets in message's body.
- **Punctuate** your commit message's body.
- Add **two blank lines** followed by **Co-authors**, if found, at the end of your commit message.
- Example:

``` unix shell

Add comments and other XAML code edits

 * Add x:Name attribute to all fields and buttons.
 * Use Pascal Case in naming instead of Camel Case.
 * Add Comments to make it easier to read the code.
 * Add whitespaces between code blocks.


Co-authored-by: Michael Safwat <michaelsafwat.hanna@gmail.com>
Co-authored-by: Micheline Medhat <MichelineMedhat@gmail.com>
Co-authored-by: Mina Ossama <mina.oss.tadros@gmail.com>
Co-authored-by: Monica Atef <monicaatef46@gmail.com>
Co-authored-by: Youssef Raafat <YoussefRaafatNasry@gmail.com>

```

### 1.3. Submitting Pull Requests

1. [Fork](https://github.com/MichaelSafwatHanna/fitness-and-weight-loss-app/fork) and clone the repository.
1. Create a new branch based on `master`: `git checkout -b <my-branch-name>`
1. Make your changes, and make sure the app still runs.
1. Push to your fork and [submit a pull request](https://github.com/MichaelSafwatHanna/fitness-and-weight-loss-app/compare) from your branch to `master`

> **Here are a few things you have to do:**
> - Write a good commit message.
> - Follow the style guide where possible.
> - Keep your change as focused as possible. If there are multiple changes you would like to make that are not dependent upon each other, consider submitting them as  separate pull requests.

---

## 2. XAML Coding Guidelines

### 2.1. Naming

- Name elements with the ```x:Name``` attribute.
- Use Pascal Casing *(i.e. first char of each word should be capitalized)*.
- Suffix XAML names with a type indication.
- Example:

``` XAML

x:Name = "EmailTextBox"

```

### 2.2. Spacing

- If the tag is self closing, **leave a whitespace** before closing it.
- Else, just close it *(without any whitespaces)*.

``` XAML

<Grid Width="5">
    <TextBlock Text="Some Text" />
</Grid>

```

### 2.3. Code readability

- Put one attribute per line.
- Put the first attribute on the element line.
- Put the ```x:Name``` or ```x:Key``` as the first attribute.
- Put the attached properties at the beginning of the element, eventually after the ```x:Name``` or ```x:Key```
- Order Attributes in the following order:

``` XAML

1. x:Key and x:Name
 
2. Attached properties
    - Grid.Row
    - Grid.Column
    - Grid.RowSpan
    - Grid.ColumnSpan
 
3. Positioning
    - HorizontalAlignment
    - VerticalAlignment
    - Margin
    - Padding
    - Stretch
    - Canvas
    - Grid
 
4. Box model
   - Width (always first)
   - Height
 
5. Typography
    - FontFamily
    - FontWeight
    - FontSize
    - Foreground (if related to text item)
    - Text
    - Content
    - TextWrapping
 
6. Visual
    - Background
    - Fill
    - Foreground
    - BorderBrush
    - BorderThickness
    - Stroke
    - StrokeThickness
    - Opacity
    - Visibility
    - Style
 
7. Misc
    - Material Design

8. Commands

9. Event handlers

```

---

## 3. UI Guidelines

### 3.1. Layout

- Use the **Grid** layout to make margins.
- Add **15px** spacing between rows and columns.
- Add **25px** whitespace border in cards and windows.

### 3.2. Typography

- Use **Product Sans** Font for buttons and headings.
- Else, use **Roboto** Font.

### 3.3. More Guidelines

- [Google Material Design](https://material.io/design/)

---

## 4. C# coding guidelines

### 4.1. Variables Naming Conventions

| Object Name               | Notation   |
| :------------------------ | :--------- |
| Class name                | PascalCase |
| Constructor name          | PascalCase |
| Function name             | PascalCase |
| Constants name            | PascalCase |
| Properties name           | PascalCase |
| Private variables         | _camelCase |
| Function arguments        | camelCase  |
| Local variables           | camelCase  |

### 4.2. Layout Conventions

- Write only one statement per line.
- Write only one declaration per line.
- If continuation lines are not indented 
matically, indent them one tab stop (four spaces).
- Add at least one blank line between method definitions and property definitions.
- Use parentheses to make clauses in an expression apparent, as shown in the following code.

```C#

if ((val1 > val2) && (val1 > val3))
{
    // Take appropriate action.
}

```

### 4.3. Commenting Conventions

Place the comment on a separate line, not at the end of a line of code.
Begin comment text with an uppercase letter.
End comment text with a period.
Insert one space between the comment delimiter (//) and the comment text, as shown in the following example.

```C#

// The following declaration creates a query. It does not run
// the query.

```

### 4.4. Class ordering

1. Constant Fields/variables
1. Fields/variables
1. Constructors
1. Destructors
1. Properties
1. Methods

### 4.5. More Guidelines

- Check the following [Link](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).