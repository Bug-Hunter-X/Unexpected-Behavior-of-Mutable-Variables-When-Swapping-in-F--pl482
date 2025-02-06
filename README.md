# F# Mutable Variable Swapping Bug

This repository demonstrates an unexpected behavior of mutable variables in F# when attempting to swap their values outside of functions that use `byref` parameters.

## Problem Description

When swapping two mutable variables directly within a function, the original variables remain unchanged.  However, using `byref` parameters allows for proper value swapping.  The `bug.fs` file illustrates this issue.

## Solution

The `bugSolution.fs` file shows the correct way to swap mutable variables using `byref` parameters. This approach correctly updates the original variables.

## How to reproduce

1.  Clone this repository.
2.  Open `bug.fs` and `bugSolution.fs` in a F# editor (e.g., Visual Studio, Ionide).
3.  Compile and run both files. Observe the different outputs.