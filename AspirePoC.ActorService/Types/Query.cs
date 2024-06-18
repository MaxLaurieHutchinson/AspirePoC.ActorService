namespace AspirePoC.ActorService.Types;

[QueryType]
public static class Query
{
    public static Actor GetActor()
    => new Actor("Tom Cruise", new DateTime(1962, 7, 3));
}
