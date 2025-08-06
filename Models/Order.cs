using System.ComponentModel.DataAnnotations;

namespace independent_work_AUG.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } // Ключевое поле заявки
        public int Number { get; set; } // Номер заявки
        public DateTime CreateDate { get; set; } // Дата создания заявки
        public DateTime? CloseDate { get; set; } // Дата закрытия заявки (может быть null)
        public string EquipmentName { get; set; } // Наименование оборудования
        public string FaultType { get; set; } // Тип неисправности
        public string? ProblemDescription { get; set; } // Описание проблемы (может быть null)         
        public DateTime? UpdatedAt { get; set; } // Дата последнего обновления заявки (может быть null)
        public OrderStatus Status { get; set; } // Статус заявки, автоматически устанавливается в Awaiting при создании
        public string Client { get; set; } // Клиент, создавший заявку
        public string ClientEMail { get; set; } // Клиент, создавший заявку
        public string? Employee { get; set; } // Ответственный сотрудник (может быть null)
        public string? Comment { get; set; } // Комментарии к заявке (может быть null)

        // Конструктор для установки начальных значений
        public Order()
        {
            this.Status = OrderStatus.Awaiting; // Устанавливаем статус Awaiting при создании
        }
    }



    public enum OrderStatus
    {
        Awaiting,
        InProgress,
        Completed
    }
}
