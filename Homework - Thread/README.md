This C# program is designed to read and analyze a text file. It extracts various statistics about the words in the book and uses multithreading to perform these operations concurrently, potentially improving performance.

File Reading:
The program reads the content of a text file named "Joanne-Rowling - HP - 6. Hari Potyr i Nechistokryvnija prints - 1911.txt" and stores it in a string variable called text.

Multithreading:
Multiple threads are employed to execute various word analysis tasks simultaneously. These tasks include:

Counting the number of words.
Finding the shortest word.
Finding the longest word.
Calculating the average word length.
Calculating word frequency (the number of times each word appears).

Word Extraction (ExtractWords method):
This method extracts words from the text by splitting it into tokens using spaces, tabs, and newline characters as delimiters. It then removes non-Cyrillic characters and words with less than 3 characters, converting the remaining words to lowercase. Extracted words are stored in a list called words.

Word Analysis:
Several methods are defined to analyze the extracted words:

FindShortestWord identifies the shortest word in the list.
FindLongestWord identifies the longest word in the list.
CalculateAverageWordLength computes the average word length.
CalculateWordFrequency determines the frequency of each word in the text.
Display Word Frequency (DisplayWordFrequency method):
This method presents word frequencies, either the most common or the least common words, based on the mostCommon parameter. It sorts the words by frequency and then displays a specified number of them.

Thread Creation and Execution:
Multiple threads are created to execute the word analysis tasks concurrently. Each thread is responsible for one of the tasks.

The Join method ensures that the main program waits for all threads to complete before proceeding.

The program uses a Stopwatch to measure the execution time of the analysis.

The program displays the results of the word analysis tasks, including the word count, shortest word, longest word, average word length, and word frequency.
