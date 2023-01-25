namespace ASP_MVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }              // Номер заказа
        public string SendersCity { get; set; }         // Город отправителя
        public string SendersAddress { get; set; }      // Адрес отправителя
        public string ReceiversCity { get; set; }       // Город получателя
        public string ReceiversAddress { get; set; }    // Адрес получателя
        public int CargoWeight { get; set; }            // Вес груза
        public DateOnly DateOfCargoPickup { get; set; }   // Дата забора груза
    }
}
