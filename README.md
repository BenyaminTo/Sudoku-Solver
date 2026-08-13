#Sudoku_Solver

A powerful and efficient Sudoku Solver implemented in C#. This project uses classic algorithmic techniques like Backtracking and Constraint Satisfaction to automatically solve Sudoku puzzles of varying difficulty levels.

📖 Overview

Sudoku is a logic-based, combinatorial number-placement puzzle. The objective is to fill a 9×9 grid with digits so that each column, each row, and each of the nine 3×3 subgrids contain all of the digits from 1 to 9.

This solver takes an incomplete Sudoku grid as input and efficiently finds the correct solution using intelligent search strategies.

🧠 Algorithm

The solver primarily uses the Backtracking Algorithm, which is a form of depth-first search:

1. Find Empty Cell: Locate the next empty cell in the grid.
2. Try Valid Numbers: Attempt to place digits 1-9 in the empty cell.
3. Validate: Check if the number satisfies Sudoku constraints (row, column, and 3x3 box).
4. Recurse: If valid, move to the next empty cell.
5. Backtrack: If no valid number can be placed, backtrack to the previous cell and try a different number.

Optimizations
- **Constraint Checking:** Fast validation of row, column, and box rules.
- **Early Exit:** Stops searching once a valid solution is found.

## 📂 Repository Structure

```text
Sudoku-Solver/
├── Solve Algoritm.cs    # Core solving algorithm and logic
├── sudoku.sln           # Visual Studio Solution file
└── README.md            # Project documentation
