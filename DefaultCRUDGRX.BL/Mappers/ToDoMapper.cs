using DefaultCRUDGRX.BL.DTO;
using DefaultCRUDGRX.BL.Interfaces;
using DefaultCRUDGRX.DAL.Models;

namespace DefaultCRUDGRX.BL.Mappers
{
    public static class ToDoMapper : IMap<ToDo, ToDoDTO>
    {
        
        public static ToDoDTO Down(ToDo model)
        {
            return new ToDoDTO() { Name = model.Name, Description = model.Description, Status_Name = model!.Status!.Status_Name};
        }

        public static ToDo Up(ToDoDTO modelDTO)
        {
            return new ToDo() { Name = modelDTO.Name, Description = modelDTO.Description };
        }
    }
}
