# Solution to the 'Football tables' assigment
made by 'CODO' team

## This is a console application written in C#. The program utilizes a fileReader method to process .csv files to setup the league with the teams and process match results round by round.
Inside the application's root directory there's a folder called 'scores'. This folder contains another folder called 's2022-2023'. If we wish to process further games you need to make a new folder starting with the letter 's' for season, followed by the years.
The setup and the teams are fixed, so in case we want to modify that we need to change the original files.

### Other features:
- if a match if cancelled it's marked by 'X' in the .csv file and the processing of the games continue and the missing game is signified by the number of matches attribute of the concerning teams
- the teams in the table are ranked and displayed by points, goal difference, goals for, goals against, and alphabetically (in this order), and in case their order is alphabetical, they occupy the same position
- a certain colorcode marks the special placements of the table: 
1. ![#1589F0](https://placehold.co/15x15/1589F0/1589F0.png) `#1589F0` champions league
2. ![#c5f015](https://placehold.co/15x15/c5f015/c5f015.png) `#c5f015` UEFA-cup
3. ![#f03c15](https://placehold.co/15x15/f03c15/f03c15.png) `#f03c15` falling down to second league
- the table and the standings are displayed after each processed round

### Testing:
We included a test folder with folder inside named after the special test cases. They contain individual files with one round of matches to test the positioning and the cancelled game.
