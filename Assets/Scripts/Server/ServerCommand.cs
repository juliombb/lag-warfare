namespace Server
{
    public enum ServerCommand: byte
    {
        PositionOfPlayer,
        PositionOfPlayers,
        ClientPeerId,
        Shot,
        InitialTime
    }
}