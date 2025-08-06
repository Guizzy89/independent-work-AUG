using System.ComponentModel.DataAnnotations;

namespace independent_work_AUG.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } // Ключевое поле заявки
        public int Number { get; set; } // Номер заявки
        public DateTime CreateDate { get; set; } // Дата создания заявки
        public DateTime CloseDate { get; set; } // Дата закрытия заявки
        public string EquipmentName { get; set; } // Наименование оборудования
        public string FaultType { get; set; } // Тип неисправности
        public string ProblemDescription { get; set; } // Описание проблемы        
        public DateTime UpdatedAt { get; set; } // Дата последнего обновления заявки
        public StatusEnum Status { get; set; } // Статус заявки
        public string Client { get; set; } // Клиент, создавший заявку
        public string ClientEMail { get; set; } // Клиент, создавший заявку
        public string Employee { get; set; } // Ответственный сотрудник
        public string Comment { get; set; } // Комментарии к заявке
    }

    public enum StatusEnum
    {
        Awaiting,
        InProgress,
        Completed
    }
}
