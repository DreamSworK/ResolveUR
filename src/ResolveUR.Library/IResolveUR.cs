namespace ResolveUR.Library
{
    public delegate void HasBuildErrorsEventHandler(string projectName);

    public delegate void ProjectResolveCompleteEventHandler();

    public interface IResolve
    {
        System.Threading.Tasks.Task ResolveAsync();

        void Clean();

        void Cancel();
    }

    public interface IResolveUR : IResolve
    {
        string BuilderPath { get; set; }

        string FilePath { get; set; }

        bool ShouldResolvePackage { get; set; }

        event HasBuildErrorsEventHandler HasBuildErrorsEvent;
        event ProjectResolveCompleteEventHandler ProjectResolveCompleteEvent;
    }
}