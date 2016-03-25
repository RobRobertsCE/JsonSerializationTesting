namespace SetupModels
{
    public enum Vehicle
    {
        SkModified = 31,
        LateModel = 50
    }
    public interface ISetupInfo
    {

    }

    public class TelemetrySessionInfo<T>
    {
        public int Id { get; set; }
        public SessionInfo SessionInfo { get; set; }
        public Weekendinfo Weekendinfo { get; set; }
        public T SetupInfo { get; set; }
    }   

    public class SessionInfo
    {
        public string SessionType { get; set; }
    }
    public class Weekendinfo
    {
        public string TrackName { get; set; }
    }
}
