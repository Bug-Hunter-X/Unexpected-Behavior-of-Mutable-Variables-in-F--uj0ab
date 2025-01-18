# Unexpected Behavior of Mutable Variables in F#

This example demonstrates a potential source of confusion for programmers new to F#, specifically regarding the behavior of mutable variables and how changes to them do not automatically update variables that have previously been assigned their values.  This is a consequence of F#'s functional nature and immutable default behavior.

## The Bug
The program initially sets two mutable variables, `x` and `y`, and calculates their sum assigning the result to `z`. Subsequently, `x` and `y` are modified. One might expect that `z` would reflect these changes; however, it retains its initial value.  This is because the initial calculation of `z` creates a copy of the values of `x` and `y` at that specific time.  Subsequent changes to `x` and `y` do not affect `z`.

## The Solution
The solution involves recalculating `z` after modifying `x` and `y` to reflect the updated values.