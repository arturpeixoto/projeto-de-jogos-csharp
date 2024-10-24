using System.Security.Cryptography;

namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var games = 
                from game in Games
                where game.DeveloperStudio == gameStudio.Id
                select game;
        return games.ToList();
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        var games = 
                from game in Games
                where player.GamesOwned.Contains(game.Id)
                select game;
        return games.ToList();
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var games = 
                from game in Games
                where playerEntry.GamesOwned.Contains(game.Id)
                select game;
        return games.ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        var gamesList = 
                    from game in Games
                    from studio in GameStudios
                        where game.DeveloperStudio == studio.Id
                    select new GameWithStudio {GameName = game.Name, StudioName = studio.Name, NumberOfPlayers = game.Players.Count };
        return gamesList.ToList();
    }
    
    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        var gameTypes = 
                    (from game in Games
                    select game.GameType).Distinct();
        return gameTypes.ToList();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        var studioGamesPlayersList = (from studio in GameStudios
                                        let studioGames = Games.Where(game => game.DeveloperStudio == studio.Id).ToList()
                                        select new StudioGamesPlayers
                                        {
                                            GameStudioName = studio.Name,
                                            Games = (from game in studioGames
                                                    select new GamePlayer
                                                    {
                                                        GameName = game.Name,
                                                        Players = (from player in Players
                                                                    where game.Players.Contains(player.Id)
                                                                    select player).ToList()
                                                    }).ToList()
                                        }).ToList();

        return studioGamesPlayersList;
    }
}
