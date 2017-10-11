public abstract class MineWorker
{
    private string id;

    protected MineWorker(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }
}
