# Hangman

# How does this console application work?

The Hangman console application offers a digital rendition of the classic word-guessing game. Developed in C#, users engage in interactive gameplay, attempting to decipher a hidden word by guessing individual letters within a limited number of attempts. This implementation serves as both entertainment and educational tool, fostering vocabulary skills and deductive reasoning. Through a minimalist console interface, the game ensures accessibility and focused engagement, making it suitable for diverse audiences across computing platforms.

# 1. Review of `Main` method:
![demo1](/assets/demo1.png)
The variable `words` holds the word to be guessed (in this case, "water").
An array named `guessedWord` is initialized to store guessed letters.
`PrintHiddenSign` prints dashes indicating unguessed letters.
`attemptsLeft` tracks remaining guesses.
`printHiddenLine` signals if the entire word is guessed.
`PrintMessage` displays game instructions.
`Hangmen` manages game logic (guessing letters, updating guessedWord).
`PrintResult` displays the game outcome (success/failure).
This code sets up the Hangman game, prompts the player for guesses, and reports the result.

# 2 Explantion of `Hangmen`:
![demo1](/assets/demo2.png)
This method `Hangmen` is the core logic for playing the Hangman game. Here's a breakdown of what it does:
Loop Condition: The `while` loop continues as long as the entire word is not guessed (`printHiddenLine` is false) and the player has remaining attempts (`attemptsLeft` is greater than 0).
Prompting the Player: It displays the number of attempts left and prompts the player to enter a letter.
Checking the Guess: It checks if the guessed letter is correct or not. If correct, it updates the `guessedWord` array with the correctly guessed letter(s) and notifies the player. If incorrect, it decrements the remaining attempts and notifies the player.
Checking Win Condition: After each guess, it checks if the entire word has been guessed correctly by checking if there are any dashes ("-") left in the `guessedWord` array. If not, it sets `printHiddenLine` to true, indicating that the game is won.
Exiting the Loop: The loop continues until either the entire word is guessed correctly or the player runs out of attempts.
This method efficiently manages the game's progress, allowing the player to make guesses and providing feedback on correctness and remaining attempts.

# 3 Explantion of `PrintHiddenSign`:
![demo1](/assets/demo3.png)
This method `PrintHiddenSign` initializes the `guessedWord` array with dashes ("-") representing the hidden letters of the word to be guessed. Here's a concise explanation:
Initialization: It loops through each character in the `words` string.
Dash Assignment: It assigns a dash ("-") to each element of the `guessedWord` array.
Return Value: It returns the modified `guessedWord` array.

# 4 Explantion of `PrintResult`:
![demo1](/assets/demo4.png)
This method, `PrintResult`, displays the outcome of the Hangman game to the player. Here's a brief explanation:
Outcome Check: It checks if the entire word has been correctly guessed (`printHiddenLine` is true).
Message Display: If the word is guessed correctly, it displays a congratulatory message showing the hidden word. Otherwise, it displays a message indicating that the player has run out of attempts and reveals the hidden word.

# 5 Explantion of `PrintMessage`:
![demo1](/assets/demo5.png)
This method, `PrintMessage`, is a simple utility function used to print messages to the console. Here's a concise explanation:
Message Printing: It takes a string parameter `message` and writes it to the console without appending a new line.
Console Output: The message is displayed to the user on the console window.

# 6 Demo 
![Tux, the Linux mascot](/assets/Animation.gif)
If you are interested in this kind of console application you can follow: https://github.com/YaqubAliy02
