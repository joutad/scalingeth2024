// SPDX-License-Identifier: MIT
pragma solidity ^0.8.0;

contract Leaderboard {
    struct Player {
        uint256 wins;
        uint256 losses;
    }

    mapping(address => Player) public players;
    address[] public playerAddresses; // Maintain an array of player addresses
    uint256 public playerCount; // Counter to track the number of registered players

    event MatchResult(address indexed player, bool win);

    // Function to record match results
    function recordMatchResult(address player, bool win) external {
        if (players[player].wins == 0 && players[player].losses == 0) {
            registerPlayer(player);
        }
        if (win) {
            players[player].wins++;
        } else {
            players[player].losses++;
        }
        emit MatchResult(player, win);
    }

    // Function to register a new player
    function registerPlayer(address player) internal {
        playerAddresses.push(player);
        playerCount++;
    }

    // Function to get all players' addresses
    function getPlayers() external view returns (address[] memory) {
        return playerAddresses;
    }

    // Function to get the number of registered players
    function getPlayerCount() external view returns (uint256) {
        return playerCount;
    }
}
