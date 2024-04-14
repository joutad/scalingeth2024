# scalingeth2024

## Global leaderboard

Simple leaderboard contract written in Solidity. It's used to keep track of players who participate in some kind of game or competition, such as wins and losses of a game. 

Breakdown of this smart contract:

1. Defines a struct called `Player` which holds two uint256 variables - `wins` and `losses`.
2. Defines a public mapping called `players` which maps addresses to Player structs. This allows you to access a Player's wins and losses by providing their address. 
3. Maintains a list of player addresses (playerAddresses) and a counter for `playerCount` to keep track of how many players have registered.
4. The MatchResult event is emitted whenever a match result is recorded for a player. It includes the address of the player and a boolean indicating whether they won (true) or lost (false).
5. The recordMatchResult function is used to record a match result for a player. It first checks if a Player struct exists for the provided address. If not, it calls `registerPlayer` to register a new Player for them. It then increments either the wins or losses count based on whether they won (true) or lost (false). Finally, it emits a MatchResult event.
6. The `registerPlayer` function is used to register a new player with their address. It pushes their address to playerAddresses array and increments `playerCount`.
7. The `getPlayers` function returns a copy of playerAddresses array (all registered players' addresses). 
8. The `getPlayerCount` function returns current count of players (playerCount). 

The data is stored onchain so it can be verified by anyone who has access to the blockchain.