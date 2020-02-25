using System;

namespace CreateAppointment.DTO
{
    public class AppointmentDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string ServiceName { get; set; }
        public string Address { get; set; }
    }
}
