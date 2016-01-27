namespace NancyApplicationSelfHostingSandbox
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/IndexModule"] = parameters => View["index"];
            
        }
    }
}