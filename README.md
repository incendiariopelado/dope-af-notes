<<<<<<< HEAD
# dope-af-notes

Note Representation---
	Single directory with metadata XML file and the "note" itself
	Metadata file---
		Title, DateCreated, Date&Time Edited, Tags, Keywords(Added to the metadata upon file creation), (Regex Search?)

## Basic use

```bash
noteapp [operation]
```

```bash
[operation]:
list [filters] [sort] // lists all files in the notebook that meet the following filter constraints, sorted according to [sort].

open [filepath] // opens file at [filepath] in Vim

listopen [filters] [sort] // behaves like list(filter, sort) , except: prints a letter code next to each note.
// Prompts the user for input. open(filepath) is then run on the file corresponding
// to the letter code that the user inputs.

listtags // lists all tags that have been used

addtag [tags] // adds each tag in addtag to the global tag set

deletetag [tags] // deletes each tag in tags from the global tag set and iterates through each note in the notebook and removes the tags from their tagsets

```

```bash
[tags]:
tag1;tag2;tag3
```


```bash
[filters]:
[filter] [filters] // each filter is implicitly ANDed together

[filter]:
[filter_by_date_created]:
mmddyyyy // filter returns only set of notes created on mmddyyyy
mmddyyyy;mmddyyyy // filter returns only the set of notes created on the interval \[mmddyyyy_1, mmddyyyy_2\]
[filter_by_last_edited]:
mmddyyyy // filter returns only set of notes last edited on mmddyyyy
mmddyyyy;mmddyyyy // filter returns only the set of notes edited on the interval \[mmddyyyy_1, mmddyyyy_2\]
[filter_by_tags]
example:(tag1&!tag2)|(tag3) // filter returns only the set of notes that contain the tags of the given boolean expression
[filter_by_title]
titleIsMatch([regex]) // filter returns only the set of notes with a title that matches regex // hard
[filter_by_body]
titleIsMatch([regex]) // filter returns only the set of notes with a body containing something that matches regex // hard
```

```bash
[sort]:
[sort_by_date/time_created]
[sort_by_date/time_last_edited]
[sort_by_tags] // alphabetical order
[sort_by_title] // alphabetical order

```

```bash
[filepath]: // self explanatory

```

## Solution organization

Note::Class (Object)
Properties:
string Title
Date dateCreated
DateTime datetimeLastEdited
Set<Tag> tags
string body

Methods:

/// A list of notebooks. Represents an entire notebook which contains each note (.note) file in the repository. Has functions for returning filtered and sorted aspects of this notebook.
Notebook::Class (extends List<Note>)
Properties:
/// A set containing all tags available for use in this notebook.
public Set<Tag> tags

Methods:
/// Constructs an empty notebook
public Notebook()

/// Constructs a notebook containing all of the notes in *notelist*
public Notebook(List<Note> noteList)

/// Returns a List of notes that meet all of the filters in *filterSet*, sorted according to the order prescribed by *sort*
public List<Note> GetNotebookSlice(Set<Filter> filterSet, Func<List<Note>,List<Note>> sort)

///  Adds a tag *tag* to this.tags
public void AddTag(string tag)

/// Deletes the tag *tag* from this.tags and removes each occurence of *tag* from each tag set of each Note in this Notebook.
public void DeleteTag(string tag)

/// Creates a new commit of this notebook (which is a repository) on the local machine -- integrates with Git.
public void Commit(string commitMessage)

/// Pushes the state of this notebook (which is a repository) onto origin master -- integrates with Git.
public void Push()


Tag::Class
// TODO

/// Encapsulates a function that filters a list of notes to return a smaller list of notes that meet the requirements prescribed by filter.
Filter::Class
Properties:
private Func< List<Note>, List<Note> > filter

Methods:
/// Constructs a new Filter which has a this.filter of filterFunction
public Filter(Func<List<Note>, List<Note>> filterFunction)

/// Applies this Filter to the input list. Returns the filtered list.
public List<Note> Apply(List<Note> noteList)

FilterLibrary::Class (library)
// TODO

SortLibrary::Class (library)

Methods:

public List<Note> SortByDateTimeCreated(List<Note> noteList)

public List<Note> SortByDateTimeLastEdited(List<Note> noteList)

public List<Note> SortByTagsAlphabetical(List<Note> noteList)

public List<Note> SortByTitleAlphabetical(List<Note> noteList)
=======
# dope-af-notes
>>>>>>> 16f4fb007a70ef1ee5013697efad3e0b3655c754
