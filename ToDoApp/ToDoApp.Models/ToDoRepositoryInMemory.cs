using System.Collections.Generic;
using System.Linq;

namespace ToDoApp.Models
{
    // In-Memory-DB 사용 영역
    public class ToDoRepositoryInMemory : IToDoRepository
    {
        private static List<ToDo> _toDos = new List<ToDo>();
        public ToDoRepositoryInMemory()
        {
            _toDos = new List<ToDo>
            {
                new ToDo { Id = 1, Title = "C# 학습", IsDone = true},
                new ToDo { Id = 2, Title = "ASP.Net Core 학습", IsDone = false},
                new ToDo { Id = 3, Title = "Blazer 학습", IsDone = false},
            };
        }
        public void Add(ToDo model)
        {
            model.Id = _toDos.Max(t => t.Id) + 1;
            _toDos.Add(model);
        }

        public List<ToDo> GetAll()
        {
            return _toDos.ToList();
        }
    }
}
