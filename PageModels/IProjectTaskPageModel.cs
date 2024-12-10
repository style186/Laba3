using CommunityToolkit.Mvvm.Input;
using LABA3.Models;

namespace LABA3.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}