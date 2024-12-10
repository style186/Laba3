using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using LABA3.Models;

namespace LABA3.ViewModels
{
    public class TodoViewModel : BindableObject
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }
        public ICommand ToggleCommand { get; }

        private string newTodoTitle = string.Empty; // Инициализация по умолчанию

        public string NewTodoTitle
        {
            get => newTodoTitle;
            set
            {
                newTodoTitle = value;
                OnPropertyChanged();
            }
        }

        public TodoViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            AddCommand = new Command(AddTodoItem);
            RemoveCommand = new Command<TodoItem>(RemoveTodoItem);
            ToggleCommand = new Command<TodoItem>(ToggleTodoItem);
        }

        private void AddTodoItem()
        {
            if (!string.IsNullOrWhiteSpace(NewTodoTitle))
            {
                TodoItems.Add(new TodoItem { Title = NewTodoTitle });
                NewTodoTitle = string.Empty; // Очистка поля ввода
            }
        }

        private void RemoveTodoItem(TodoItem item)
        {
            if (item != null)
            {
                TodoItems.Remove(item);
            }
        }

        private void ToggleTodoItem(TodoItem item)
        {
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
                OnPropertyChanged(nameof(TodoItems)); // Обновление списка
            }
        }
    }
}