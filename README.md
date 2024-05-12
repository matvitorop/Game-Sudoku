# Game Sudoku, Matvii Torop, IPZ-22-4
## Before starting the application
In this project, I used non-relational databases with DBMS MongoDB, so before you launch the project, turn on your mongod and then start playing :).
## Program functionality
This is sudoku game, where user must login firstly, then choose sudoku size and complexity. During the game, player can saving sudoku state, to backup if got in stalemate. Also after victory, system calculating result by size and difficulty of sudoku, that he past. In menu of choosing sudoku, where user can return, user can see his progress in completing sudoku of different difficulty and total score. Also user can see all users, that played in this sudoku and their statistic.

__Difficulty, that user can choose:__
- Hard
- Normal
- Easy

__Size of sudoku, that user can choose:__
- 4x4
- 9x9 (classic)
- 16x16
## Design patterns
Main goal of this project was to use useful design patterns, programming principles and refactoring techniques. Moreover, I tried to use patterns carefully, so that they do not overload the structure with unnecessary code. So in this project I used 5 design patterns, that useful in one place or another.
### Singleton
I used `singleton pattern for objects, that must in one specimen`. So I used it for [SudokuService](./Classes/SudokuTypes/SudokuService.cs) as this class must have only one current sudoku that must be remaked in different times of program cycle. Also this pattern was useful for connection to database as a few connections can be harmful for code structure. So i placed connection to one class, that have only one specimen [DbManager](./Classes/MongoDB/DatabaseManager.cs). 
### Visitor
Benefit of this method - that it allow to add methods for already existing classes without great changes of this class. So for the purpose of use this benefit and for experiment, I created [Visitor](./Classes/Visitor/SudokuVisitor.cs) that can `prepare sudoku for game by making cells empty` by [method](./Classes/Visitor/SudokuVisitor.cs#L13-L33). Ideally it would be cool if the behavior of visitor was different for different subclasses of sudoku, but I made without it.   
### Memento
Firstly when I thought about realization of saves of sudoku states, I instantly remembered the memento pattern. So I [SudokuCaretaker](./Classes/Memento/SudokuCaretaker.cs) as caretaker and [SudokuCaretaker](./Classes/Memento/SudokuSnapshot.cs) as memento. I program I `created caretaker` and put into current sudoku class. Then, in different moments user can make saves and backup to them if he need, in program changes demonstrating instantly.  
### Chain of responsibility
This pattern was created mostly as experiment, but it also serves an `important role` in program - `returning required sudoku factories`. So I made parts of chain like [EasyFactoryReturn](./Classes/CoR/ReturnEasyFactory.cs). Which element in the queue will work depends on the input data and chain construction but result will be the always the same - return of factory. 
### Abstract factory
As in my program avaible different sudoku by difficulty and size, It incorrect to create different if...else method to create sudoku that user need. In my program, I made different factories like [EasyFactory](./Classes/Factory/EasyFactory.cs), that without linking to subclasses of sudoku, can creating different sudoku by size and complexity. This simplifies the code and makes it more compact without structure compaction.
## Programming principles
