# Example of some concepts that we used in our application:

## Type system 
specific types are declared as the attributes of our classes
## String interpolation 
(CSVReader.cs - line 19)
## Classes, structs and enums 
CSVReader, League, Team, TableDK, ToStringTableDK are classes, MatchResult is an enum
## Properties 
f.eks.: getters and setters in our Team class to work with the values of those private fields
## Named parameters
## Exception and DataValidation 
if we call a setter with a null value parameter we'll get a 'ArgumentNullException'
## Arrays / Collections 
a 'List<Team>' as an attribute of a League object that we iterate over, and the 'CSVReader' class the fileReader returns an array of the read values