# Development Notes for the ***Water*** task app

I have settled on two packages that will form the basis for the application:

- LiteGraphDb : A graph database overtop of sqlite.  It has local file, and in-memory options so it is a good fit.
- Spectre.Console : This is a great package with lots of classes for creating a really nice TUI.  Also, and probably
  more importantly, it has `Spectre.Console.Cli` which is a set of classes that make it super easy to build command line
  options.


So, because I'm using Spectre, it has a specific way that the program options are set up; the `Command` and `Settings`
classes.  That means that i need to know what the command line interface is going to look like...

I'm going with the name `Water` as in *Mind like water* from GTD, but I might change that ...

I think the most appropriate way to start is with how we get work items into the data base.
``` sh
$> water add "This is my first task" --tags 'garden', 'spring'
```

I like the idea of being able to "brand" the different work items as "Task", "Project", "Goal", etc.  but they are all
fundementally the same... A title, some meta-data, and 0 or more parents, and 0 or more children.  This is why I don't
want to have the word `task` in the name of the app, or the "thing" that we are storing.

``` sh
$> water add "This is my big goal" --type Goal --area 'Personal Finance'
```
The `--area` made me think about this point:


Thinking about the data as a graph, then `area` is a node and it has vertices to 0 or more nodes

So there are two types of nodes now... one that is a `WorkItem` and then another that is basically just metadata.
Ok, so third type of node I thought of... a `Note`, these are text heavy

## Data types

In the graph, there are the following Node types:

- **WorkItem** : This represents the *Thing that needs to be done or has been done*.  It needs all the typical
  properties of a task:
  - **Title** : Obviously, it needs a textual representation of the work
  - **Description** : Maybe more detail here, especially for things like projects or goals.
  - **Status** : this could also be called **State** it is basically which column in the kanban chart the Item is in.
- **Metadata** : These are things like `tag`, `label`, `board`, etc.  Basically the descriminating difference between
  this type of metadata, and the properties of a WorkItem, is that these can relate to more than one Item.  Although two
  Items could potentially share the same due-date, that might be a better property than a separate node with a vector to
  traverse.
