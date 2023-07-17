namespace DotnetJetpack.Core.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }

        public virtual Notification Notification { get; protected set; } = new Notification();

        public void AddError(string error)
        {
            Notification.AddError(error);
        }

        public void AddErrors(Notification notification)
        {
            Notification.AddErrors(notification.Errors);
        }

        public void ClearErrors()
        {
            Notification.ClearErrors();
        }

        public bool HasErrors()
        {
            return Notification.HasErrors;
        }
    }
}