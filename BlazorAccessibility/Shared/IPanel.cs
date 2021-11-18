namespace BlazorAccessibilityTests.Shared
{
    public interface IPanel
    {
        bool IsExpanded { get; set; }
        void Collapse();

        Task Focus();
    }
}
