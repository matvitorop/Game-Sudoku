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
### Memento
### Chain of responsibility
### Abstract factory
