var GameInit;
(function(GameInit) {
    function start() {
        var HIGHSCORE_STRING = '<<< HighScores >>>';
        var localStorageName = 'GameSheepAndRams';
        var localStoreHandler = new HighScore.LocalStorageHandler(localStorageName);

        var inputField = document.getElementById('input');
        var guessButton = document.getElementById('play-game');
        var clearHighScores = document.getElementById('clear');
        var displayHighScores = document.getElementById('high-scores');

        displayHighScores.addEventListener('click', function() {
            jsConsole.writeLine(HIGHSCORE_STRING);
            var highScore = localStoreHandler.getHighScores();

            if (highScore && highScore.length > 0) {
                highScore.sort(function(playerOne, playerTwo) {
                    return playerOne.playerScore - playerTwo.playerScore;
                });

                highScore.forEach(function(playerEntry) {
                    jsConsole.writeLine('Player: ' + playerEntry.playerName + ' - Score: ' + playerEntry.playerScore);
                });
            }
        });

        clearHighScores.addEventListener('click', function() {
            HighScore.LocalStorageHandler.clearLocalStorage();
        });

        var resultPrintFunction = function(str) {
            jsConsole.writeLine(str);
        };
        var userPrompt = function(message, defaultValue) {
            return window.prompt(message, defaultValue);
        };

        var savePlayerScoreFunc = function(playerName, playerScore) {
            localStoreHandler.savePlayer(playerName, playerScore);
        };

        var game = new SheepAndRams.Game(_.random, resultPrintFunction, userPrompt, savePlayerScoreFunc, true);

        guessButton.addEventListener('click', function() {
            game.userGuess(inputField.value);
        });
    }
    GameInit.start = start;
})(GameInit || (GameInit = {}));

window.addEventListener('load', GameInit.start);