namespace DotnetJetpack.Core.Domain
{
    public class Notification
    {
        private readonly List<string> _errors = new List<string>();

        public IReadOnlyCollection<string> Errors => _errors;

        public bool HasErrors => _errors.Count > 0;

        public void AddError(string error)
        {
            _errors.Add(error);
        }

        public void AddErrors(IEnumerable<string> errors)
        {
            _errors.AddRange(errors);
        }

        public void ClearErrors()
        {
            _errors.Clear();
        }
    }
}