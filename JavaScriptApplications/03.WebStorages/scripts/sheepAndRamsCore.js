var SheepAndRams;
(function(SheepAndRams) {
    var DIGITS = 4;
    var RAM = 'R';
    var SHEEP = 'S';
    var USED = 'U';
    var WIN_TEXT = 'You Won!';
    var MIN = 1000;
    var MAX = 9999;
    var VALIDATION = 'Bad input! The number mus be between ' + MIN + ' and ' + MAX;
    var DEFAULT_NAME = 'Unknown';

    var Game = (function() {
        function Game(randomFunction, resultPrint, highScorePrompt, saveState) {
            this.randomFunction = randomFunction;
            this.resultPrint = resultPrint;
            this.highScorePrompt = highScorePrompt;
            this.saveState = saveState;
            this.numberOfTries = 0;
            this.numberToBeGuessed = this.randomFunction(MIN, MAX);
            console.log('Oops ' + this.numberToBeGuessed);

        }

        Game.parseUserInput = function(userInput) {
            var userInputAsInt = parseInt(userInput, 10);
            if (isNaN(userInputAsInt) || userInputAsInt < MIN || userInputAsInt > MAX) {
                throw new RangeError(VALIDATION);
            }

            SheepAndRams.Game.convertToCharArray(userInputAsInt.toString());
            return (userInputAsInt.toString());
        };

        Game.prototype.userGuess = function(userInput) {
            var guess;

            try {
                guess = SheepAndRams.Game.parseUserInput(userInput);
                this.numberOfTries += 1;
                var result = this.evaluateUserGuess(guess);
                var resultString = 'Rams: ' + result.ramsCount + ' | Sheeps: ' + result.sheepCount + ' | Score: ' + this.numberOfTries;
                this.resultPrint(resultString);
            } catch (err) {
                if (err instanceof RangeError) {
                    this.resultPrint(VALIDATION);
                } else {
                    throw err;
                }
            }
        };

        Game.prototype.playerHasWon = function() {
            this.resultPrint(WIN_TEXT);
            var player = this.highScorePrompt('Please enter your name', DEFAULT_NAME) || DEFAULT_NAME;
            this.saveState(player, this.numberOfTries.toString());
        };

        Game.prototype.evaluateUserGuess = function(guess) {
            var sheep = 0;

            var rams = this.checkForRams(guess);

            if (rams.ramsCount < 4) {
                sheep = this.checkForSheep(guess, rams.leftToGuess);
            } else {
                this.playerHasWon();
            }

            return {
                sheepCount: sheep,
                ramsCount: rams.ramsCount
            };
        };

        Game.convertToCharArray = function(str) {
            var result = [],
                i;

            for (i = 0; i < str.length; i += 1) {
                result.push(str[i]);
            }

            return result;
        };

        Game.prototype.checkForRams = function(guess) {
            var numberToBeGuessedAsString = SheepAndRams.Game.convertToCharArray(this.numberToBeGuessed.toString());
            var leftToGuess = [];
            var ramsCount = 0;

            for (var index = 0; index < DIGITS; index += 1) {
                var currentChar = guess[index];
                if (currentChar === numberToBeGuessedAsString[index]) {
                    ramsCount += 1;
                    leftToGuess[index] = RAM;
                    guess[index] = USED;
                } else {
                    leftToGuess[index] = numberToBeGuessedAsString[index];
                }
            }

            return {
                ramsCount: ramsCount,
                leftToGuess: leftToGuess
            };
        };

        Game.prototype.checkForSheep = function(userGuess, leftToGuess) {
            var sheepCount = 0;

            for (var i = 0; i < DIGITS; i += 1) {
                for (var j = 0; j < DIGITS; j += 1) {
                    if ((userGuess[i] === leftToGuess[j])) {
                        sheepCount += 1;
                        userGuess[i] = USED;
                        leftToGuess[j] = SHEEP;
                    }
                }
            }

            return sheepCount;
        };
        return Game;
    })();
    SheepAndRams.Game = Game;
})(SheepAndRams || (SheepAndRams = {}));