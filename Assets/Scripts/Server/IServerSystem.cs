namespace Server
{
    public interface IServerSystem
    {
        public ServerCommand CommandKey { get; }

        void Handle(int peer, byte[] data);
        void Poll();
    }
}