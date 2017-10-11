namespace _08.Military_Elite.Entities.Utils
{
    using Interfaces;

    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; }

        public string State { get; private set; }

        public void CompleteMission()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
