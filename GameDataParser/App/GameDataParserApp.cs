public class GameDataParserApp
{
    private readonly IUserInteractor _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _fileReader;



    public GameDataParserApp(IUserInteractor userInteractor,
        IGamesPrinter gamesPrinter,
        IVideoGamesDeserializer videoGamesDeserializer,
        IFileReader reader)
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _fileReader = reader;
    }

    public void Run()
    {
        string fileName = _userInteractor.ReadValidFile();
        var fileContents = _fileReader.Read(fileName);
        var videoGames = _videoGamesDeserializer.DeserializeFrom(
            fileName, fileContents);
        _gamesPrinter.Print(videoGames);
    }
    
}
