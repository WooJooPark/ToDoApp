using System;
using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IToDoRepository _repository = new ToDoRepositoryInMemory();
            List<ToDo> toDos = new List<ToDo>();
            toDos = _repository.GetAll();
            // [1] 기본 데이터 출력
            foreach (var t in toDos)
            {
                Console.WriteLine($"{t.Id} - {t.Title} ; {t.IsDone}");
            }
            Console.WriteLine();
            // [2] 추가 데이터 입력
            ToDo toDo = new ToDo { Title = "DataBase 학습", IsDone = true };
            _repository.Add(toDo);
            toDos = _repository.GetAll(); // 다시 로드
            // [3] 변경 데이터 출력
            foreach (var t in toDos)
            {
                Console.WriteLine($"{t.Id} - {t.Title} ; {t.IsDone}");
            }
            Console.WriteLine();
        }
    }
}
