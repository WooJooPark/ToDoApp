using System.Collections.Generic;

namespace ToDoApp.Models
{
    public interface IToDoRepository
    {
        // 앞으로 구현할 기본 메서드 선언
        // BREAD'S COP
        void Add(ToDo model); // 입력 메서드 선언
        List<ToDo> GetAll(); // 출력
    }
}
