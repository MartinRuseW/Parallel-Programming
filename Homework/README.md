The program starts by setting the output encoding of the console to UTF-8. This ensures that the console can display characters from various languages correctly.
It initializes a stopwatch to measure the time it takes to perform the analysis.
The program reads the content of a text file named "Joanne-Rowling - HP - 6. Hari Potyr i Nechistokryvnija prints - 1911.txt" and stores it in the text variable.
The ExtractWords method is called to split the text into words. It uses a regular expression to filter out non-Cyrillic characters and words with a length less than 3 characters. The resulting words are converted to lowercase and stored in a list.
The program calculates and stores the total number of words in the document.
It finds the shortest and longest words in the list of extracted words by iterating through the list and comparing word lengths.
It calculates the average word length in the document by summing the lengths of all words and dividing by the total number of words.
The CalculateWordFrequency method generates a dictionary that maps each unique word to the number of times it appears in the document.
The program displays the five most common and five least common words in the document. It uses the DisplayWordFrequency function to sort the words by frequency and display the results.
The program calculates the time taken to perform the analysis using the stopwatch and displays it in milliseconds.
