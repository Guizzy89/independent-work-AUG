namespace independent_work_AUG.Models
{
    public class Order
    {        
        public int OrderId { get; set; } // Ключевое поле заявки
        public int Number { get; set; } // Номер заявки
        public DateTime CreateDate { get; set; } // Дата создания заявки
        public DateTime CLoseDate { get; set; } // Дата закрытия заявки
        public string EquipmentName { get; set; } // Наименование оборудования
        public string FaultType { get; set; } // Тип неисправности
        public string ProblemDescription { get; set; } // Описание проблемы        
        public DateTime UpdatedAt { get; set; } // Дата последнего обновления заявки
        public StatusEnum Status { get; set; } // Статус заявки
        public virtual Client Client { get; set; } // Клиент, создавший заявку
        public virtual Employee ResponsibleEmployee { get; set; } // Ответственный сотрудник
        public virtual ICollection<Comment> Comments { get; set; } // Комментарии к заявке
    }

    public enum StatusEnum
    {
        Awaiting,
        InProgress,
        Completed
    }
}
